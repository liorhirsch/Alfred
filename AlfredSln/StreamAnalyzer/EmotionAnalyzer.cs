using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StreamAnalyzer
{
    public class EmotionAnalyzer
    {
        #region Data Members

        private PXCMSenseManager m_senseManager;
        private MovieEmotionData m_movieEmotionData;
        private Thread m_processingThread;

        #endregion

        #region Consts

        private const float EMOTION_INTENSITY_THRESHOLD = 0.5f;

        #endregion

        #region Properties

        public MovieEmotionData AnalysisData
        {
            get
            {
                return m_movieEmotionData;
            }
        }

        #endregion

        #region CTor

        public EmotionAnalyzer()
        {
            m_senseManager = PXCMSenseManager.CreateInstance();
            m_senseManager.EnableStream(PXCMCapture.StreamType.STREAM_TYPE_COLOR, 640, 480, 30);
            m_senseManager.EnableFace();

            ConfigureEmotionTracking();

            m_movieEmotionData = new MovieEmotionData();
        }

        #endregion

        #region Other methods

        public void StartStream()
        {
            m_processingThread = new Thread(new ThreadStart(ProccessStream));
            m_processingThread.Start();
        }

        public void StopStream()
        {
            m_processingThread.Abort();
            m_senseManager.Dispose();
        }

        public void Dispose()
        {
            if (m_senseManager != null)
            {
                m_senseManager.Dispose();
            }
        }

        #endregion

        #region Private Methods

        private void ConfigureEmotionTracking()
        {
            m_senseManager.EnableEmotion();
            m_senseManager.Init();
        }

        private double QueryEmotionIntensity(PXCMEmotion p_objEmotion, PXCMEmotion.Emotion p_enmEmotion)
        {
            PXCMEmotion.EmotionData emotionData;

            p_objEmotion.QueryEmotionData(0, p_enmEmotion, out emotionData);

            return emotionData.intensity;
        }

        private void ProccessStream()
        {
            var node = new Uri("http://localhost:9200");
            var settings = new ConnectionSettings(node, "alfred");
            var client = new ElasticClient(settings);

            List<emotions> bulkEmotions = new List<emotions>();
            int nFrameBulk = 0;
            
            while (m_senseManager.AcquireFrame(true) >= pxcmStatus.PXCM_STATUS_NO_ERROR)
            {
                m_movieEmotionData.TotalFramesInStream++;

                // Retrieve the emotion detection results if ready
                PXCMEmotion emotion = m_senseManager.QueryEmotion();

                Dictionary<PXCMEmotion.Emotion, double> dicEmotionIntensities = new Dictionary<PXCMEmotion.Emotion, double>();

                if (emotion != null)
                {
                    dicEmotionIntensities.Add(PXCMEmotion.Emotion.EMOTION_PRIMARY_JOY, QueryEmotionIntensity(emotion, PXCMEmotion.Emotion.EMOTION_PRIMARY_JOY));
                    dicEmotionIntensities.Add(PXCMEmotion.Emotion.EMOTION_PRIMARY_FEAR, QueryEmotionIntensity(emotion, PXCMEmotion.Emotion.EMOTION_PRIMARY_FEAR));
                    dicEmotionIntensities.Add(PXCMEmotion.Emotion.EMOTION_PRIMARY_DISGUST, QueryEmotionIntensity(emotion, PXCMEmotion.Emotion.EMOTION_PRIMARY_DISGUST));
                    dicEmotionIntensities.Add(PXCMEmotion.Emotion.EMOTION_PRIMARY_SADNESS, QueryEmotionIntensity(emotion, PXCMEmotion.Emotion.EMOTION_PRIMARY_SADNESS));
                    dicEmotionIntensities.Add(PXCMEmotion.Emotion.EMOTION_PRIMARY_SURPRISE, QueryEmotionIntensity(emotion, PXCMEmotion.Emotion.EMOTION_PRIMARY_SURPRISE));

                    emotions emotionInMovie = new emotions()
                    {
                        frame = m_movieEmotionData.TotalFramesInStream,
                        movie = "Saw",
                        user = "",
                        emotion = new Dictionary<string, double>()
                        {
                            { 
                                "joy", 
                                dicEmotionIntensities[PXCMEmotion.Emotion.EMOTION_PRIMARY_JOY]
                            },
                            { 
                                "fear", 
                                dicEmotionIntensities[PXCMEmotion.Emotion.EMOTION_PRIMARY_FEAR]
                            },
                            { 
                                "disgust", 
                                dicEmotionIntensities[PXCMEmotion.Emotion.EMOTION_PRIMARY_DISGUST]
                            },
                            { 
                                "sadness", 
                                dicEmotionIntensities[PXCMEmotion.Emotion.EMOTION_PRIMARY_SADNESS]
                            },
                            { 
                                "suprise", 
                                dicEmotionIntensities[PXCMEmotion.Emotion.EMOTION_PRIMARY_SURPRISE]
                            }
                        }
                    };

                    bulkEmotions.Add(emotionInMovie);
                    nFrameBulk++;

                    if (nFrameBulk % 500 == 0)
                    {
                        client.IndexMany(bulkEmotions);
                        bulkEmotions.Clear();
                    }
                }

                // Resume next frame processing
                m_senseManager.ReleaseFrame();
            }
        }

        #endregion
    }
}
