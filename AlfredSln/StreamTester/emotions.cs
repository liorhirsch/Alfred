using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamTester
{
    public class emotions
    {
        public string user { get; set; }

        public int frame { get; set; }

        public string movie { get; set; }

        public Dictionary<string, float> emotion { get; set; }
    }
}
