using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
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

        [JsonProperty("text")]
        public string RandomFact { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("found")]
        public bool Found { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
