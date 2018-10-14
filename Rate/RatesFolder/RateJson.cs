using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rate_General.RatesFolder
{
    class Rate
    {
        public bool success;
        public int timestamp;

        [JsonProperty("base")]
        public string Base;
        public DateTime date;
        public rates rates;
    }
}
