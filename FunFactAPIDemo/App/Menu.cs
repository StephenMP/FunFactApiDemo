using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FunFactAPIDemo.App
{
    public class Menu
    {
        /*
         * We will call this method when we want to have the user tell us
         * which random fact type they would like to see
         */
        public static string GetRandomFactType()
        {
            /* This is the string that we are going to return */
            string theStringToReturn = null;

            /* Show the user the instructions and options */
            Console.WriteLine("=======================================================");
            Console.WriteLine("* Instructions:");
            Console.WriteLine("*\tSelect the number correlating to the type of");
            Console.WriteLine("*\trandom fact you would like to see.");
            Console.WriteLine("=======================================================");
            Console.WriteLine("[1] - Number Trivia");
            Console.WriteLine("[2] - Mathematical Fact");
            Console.WriteLine("[3] - Historical Fact by Date");
            Console.WriteLine("[4] - Historical Fact by Year");
            Console.WriteLine("[9] - Exit Program");

            /* Get the number that the user pressed */
            int numberTheUserEntered = (int)char.GetNumericValue(Console.ReadKey(true).KeyChar);

            /* Find out which number the pressed and return something from it */
            if (numberTheUserEntered == 1)
            {
                theStringToReturn = "trivia";
            }

            else if (numberTheUserEntered == 2)
            {
                theStringToReturn = "math";
            }

            else if (numberTheUserEntered == 3)
            {
                theStringToReturn = "date";
            }

            else if (numberTheUserEntered == 4)
            {
                theStringToReturn = "year";
            }

            else if (numberTheUserEntered == 9)
            {
                theStringToReturn = null;
            }

            /* The user did not enter a number matching an option (or they entered a letter/non-number) */
            else
            {
                /* Prompt the user that they entered invalid input */
                Console.WriteLine("\nThe number you entered did not match an option!");

                PressAnyKeyToContinue();

                /* We call GetRandomFactType again */
                theStringToReturn = GetRandomFactType();
            }

            /* Clear the console */
            Console.Clear();

            /* Return the string correlating to the user's input */
            return theStringToReturn;
        }

        /*
         * We will call this method to show the user the random fact
         * that we got from the API
         */
        public static void ShowRandomFact(ApiResponse apiResponse)
        {
            string randomFact = apiResponse.RandomFact;

            Console.WriteLine(randomFact);

            PressAnyKeyToContinue();
        }

        /*
         * We will call this method anytime that we want to display
         * the "Press any key to continue" prompt.
         */
        private static void PressAnyKeyToContinue()
        {
            /* Prompt the user */
            Console.WriteLine("\nPress any key to continue.");

            /* Wait for the user to press a key */
            Console.ReadKey(true);

            /* Clear the console */
            Console.Clear();
        }
    }
}
