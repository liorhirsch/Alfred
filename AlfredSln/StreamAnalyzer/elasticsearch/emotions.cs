using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamAnalyzer
{
    public class emotions
    {
        public string user { get; set; }

        public ulong frame { get; set; }

        public string movie { get; set; }

        public Dictionary<string, double> emotion { get; set; }
    }
}
