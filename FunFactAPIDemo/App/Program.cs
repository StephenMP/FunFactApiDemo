using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunFactAPIDemo.App;

namespace FunFactAPIDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Get random facts forever until the user exits */
            while (true)
            {
                /* Get what type of fact to get from user */
                string type = Menu.GetRandomFactType();

                /* If something happened or the user wanted to exit, break out of the loop */
                if (type == null)
                {
                    break;
                }

                /* Get a new ApiCaller */
                ApiCaller apiCaller = new ApiCaller();

                /* Get a new ApiCommand using the type the user wanted */
                ApiCommand apiCommand = new ApiCommand(type);

                /* Download the data from the api */
                ApiResponse apiResponse = apiCaller.ExecutApiCommand(apiCommand);

                /* Show the user the random fact */
                Menu.ShowRandomFact(apiResponse);
            }
        }
    }
}
