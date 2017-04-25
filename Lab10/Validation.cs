using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Validation
    {

        public static string GetValidCategory()
        {
            string input;
            input = Console.ReadLine().ToLower();

            while (true)

            {
                

                if (input != "scifi" && input != "horror" && input != "comedy" && input != "drama" && input != "animated")
            {
                    Console.WriteLine("ERROR, Please enter SciFi, Horror, Comedy, Drama, or Animated");
input = Console.ReadLine().ToLower();
                    continue;   
            }

                break;

            }return input;
            
            

        }
    }
}
