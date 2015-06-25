using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FunFactAPIDemo.App
{
    public class ApiResponse
    {
        /*
         * This class allows us to take the data we get from the API
         * and put it into something tangible that we can use
         */
        private string _randomFact;

        [JsonProperty("text")]
        public string RandomFact { get { return WebUtility.HtmlDecode(_randomFact); } set { _randomFact = value; } }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("found")]
        public bool Found { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
