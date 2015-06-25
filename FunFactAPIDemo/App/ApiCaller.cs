using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FunFactAPIDemo.App
{
    public class ApiCaller
    {
        /*
         * We will call this method when we want to get the random
         * fact from the API
         */
        public ApiResponse ExecutApiCommand(ApiCommand apiCommand)
        {
            /* Get the command we are going to execute */
            string commandToExecute = apiCommand.GetApiCommand();

            /* Create a web client that will download the data from the internet */
            WebClient webClient = new WebClient();

            /* This tells the API that we are allowed to use it */
            webClient.Headers.Add("X-Mashape-Key", "08bVyrmWXHmshIp59Jlb22cb8JtRp1FMqtWjsnMldD0DczXC05");

            /* Download the data */
            string downloadedData = webClient.DownloadString(commandToExecute);

            /* Get the data to something tangible */
            ApiResponse apiResponse = JsonConvert.DeserializeObject<ApiResponse>(downloadedData);

            return apiResponse;
        }
    }
}
