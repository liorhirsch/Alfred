using StreamAnalyzer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StreamTester
{
    class Program
    {
        static void Main(string[] args)
        {
            EmotionAnalyzer ea = new EmotionAnalyzer();

            ea.StartStream();

            while (ea.AnalysisData.TotalFramesInStream < 144000)
            {
                Thread.Sleep(2000);

                Console.WriteLine("Joy :" + ea.AnalysisData.TotalFramesPerEmotion[PXCMEmotion.Emotion.EMOTION_PRIMARY_JOY]);
                Console.WriteLine("Sad :" + ea.AnalysisData.TotalFramesPerEmotion[PXCMEmotion.Emotion.EMOTION_PRIMARY_SADNESS]);
                Console.WriteLine("Fear :" + ea.AnalysisData.TotalFramesPerEmotion[PXCMEmotion.Emotion.EMOTION_PRIMARY_FEAR]);
                Console.WriteLine("Suprise :" + ea.AnalysisData.TotalFramesPerEmotion[PXCMEmotion.Emotion.EMOTION_PRIMARY_SURPRISE]);
                Console.WriteLine("Disgust :" + ea.AnalysisData.TotalFramesPerEmotion[PXCMEmotion.Emotion.EMOTION_PRIMARY_DISGUST]);
            }
        }
    }
}
