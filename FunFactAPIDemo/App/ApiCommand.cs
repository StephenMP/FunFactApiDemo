using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunFactAPIDemo.App
{
    public class ApiCommand
    {
        /* This is where the API is located on the internet */
        private static readonly string BaseUri = "https://numbersapi.p.mashape.com/random/";

        /* This will hold what type of random fact we want */
        private string _type;

        /* When we call this, it will assign _type to whatever we pass in */
        public ApiCommand(string type)
        {
            this._type = type;
        }

        /* We will call this when we are ready to ask the API for a random fact */
        public string GetApiCommand()
        {
            return BaseUri + _type + "?json=true";
        }
    }
}
