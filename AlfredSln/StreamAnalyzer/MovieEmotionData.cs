using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamAnalyzer
{
    public class MovieEmotionData
    {
        public Dictionary<PXCMEmotion.Emotion, ulong> TotalFramesPerEmotion { get; set; }

        public MovieEmotionData()
        {
            TotalFramesPerEmotion = new Dictionary<PXCMEmotion.Emotion, ulong>();
            TotalFramesPerEmotion.Add(PXCMEmotion.Emotion.EMOTION_PRIMARY_JOY, 0);
            TotalFramesPerEmotion.Add(PXCMEmotion.Emotion.EMOTION_PRIMARY_SADNESS, 0);
            TotalFramesPerEmotion.Add(PXCMEmotion.Emotion.EMOTION_PRIMARY_DISGUST, 0);
            TotalFramesPerEmotion.Add(PXCMEmotion.Emotion.EMOTION_PRIMARY_FEAR, 0);
            TotalFramesPerEmotion.Add(PXCMEmotion.Emotion.EMOTION_PRIMARY_SURPRISE, 0);
        }

        public ulong TotalFramesInStream { get; set; }
    }
}
