using Nest;
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
            //var node = new Uri("http://localhost:9200");

            //var settings = new ConnectionSettings(node, "alfred");
            //var client = new ElasticClient(settings);

            //var r = new Random();

            //for (int i=3; i<500; i+= 10)
            //{
            //    emotions e = new emotions()
            //    {
            //        emotion = new Dictionary<string, float>(){
            //        {"joy", (float)r.NextDouble()},
            //        {"sadness", (float)r.NextDouble()},
            //        {"disgust", (float)r.NextDouble()},
            //        {"fear", (float)r.NextDouble()},
            //        {"suprise", (float)r.NextDouble()}
            //    },
            //        frame = i,
            //        movie = "Matrix",
            //        user = "Liran"
            //    };

            //    client.Index(e);
            //}
            


            
            EmotionAnalyzer ea = new EmotionAnalyzer();

            ea.StartStream();

            while (ea.AnalysisData.TotalFramesInStream < 144000)
            {
                
            }

            ea.StopStream();
        }
    }
}
