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

        #endregion

        #region Private Methods

        private void ConfigureEmotionTracking()
        {
            m_senseManager.EnableEmotion();
            m_senseManager.Init();
        }

        private float QueryEmotionIntensity(PXCMEmotion p_objEmotion, PXCMEmotion.Emotion p_enmEmotion)
        {
            PXCMEmotion.EmotionData emotionData;

            p_objEmotion.QueryEmotionData(0, p_enmEmotion, out emotionData);

            return emotionData.intensity;
        }

        private void ProccessStream()
        {
            while (m_senseManager.AcquireFrame(true) >= pxcmStatus.PXCM_STATUS_NO_ERROR)
            {
                m_movieEmotionData.TotalFramesInStream++;

                // Retrieve the emotion detection results if ready
                PXCMEmotion emotion = m_senseManager.QueryEmotion();

                Dictionary<float, PXCMEmotion.Emotion> dicEmotionIntensities = new Dictionary<float, PXCMEmotion.Emotion>();

                if (emotion != null)
                {
                    dicEmotionIntensities.Add(QueryEmotionIntensity(emotion, PXCMEmotion.Emotion.EMOTION_PRIMARY_JOY), PXCMEmotion.Emotion.EMOTION_PRIMARY_JOY);
                    dicEmotionIntensities.Add(QueryEmotionIntensity(emotion, PXCMEmotion.Emotion.EMOTION_PRIMARY_FEAR), PXCMEmotion.Emotion.EMOTION_PRIMARY_FEAR);
                    dicEmotionIntensities.Add(QueryEmotionIntensity(emotion, PXCMEmotion.Emotion.EMOTION_PRIMARY_DISGUST), PXCMEmotion.Emotion.EMOTION_PRIMARY_DISGUST);
                    dicEmotionIntensities.Add(QueryEmotionIntensity(emotion, PXCMEmotion.Emotion.EMOTION_PRIMARY_SADNESS), PXCMEmotion.Emotion.EMOTION_PRIMARY_SADNESS);
                    dicEmotionIntensities.Add(QueryEmotionIntensity(emotion, PXCMEmotion.Emotion.EMOTION_PRIMARY_SURPRISE), PXCMEmotion.Emotion.EMOTION_PRIMARY_SURPRISE);

                    float maxEmotionIntensity = dicEmotionIntensities.Keys.Max();

                    if (maxEmotionIntensity > EMOTION_INTENSITY_THRESHOLD)
                    {
                        m_movieEmotionData.TotalFramesPerEmotion[dicEmotionIntensities[maxEmotionIntensity]]++;
                    }
                }

                // Resume next frame processing
                m_senseManager.ReleaseFrame();
            }
        }

        #endregion
    }
}
