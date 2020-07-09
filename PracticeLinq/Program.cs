using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //////////////////Query Syntax//////////////////
            string[] carsNames = {"Ford", "Chevy", "BMW", "Subaru", "Audi", "Toyota",};

            var letterSelection = from x in carsNames
                                  where x.ToLower().Contains("a") 
                                  orderby x descending
                                  select x;
            foreach ( var i in letterSelection)
            {
                Console.WriteLine(i);
            }

            //////////////////Method Syntax//////////////////
            var games = new List<string> { "Call of Duty", "The Division", "The Last of Us", "NHL 20", "Sonic The Hedgehog", "G.T.A." };

            IEnumerable<string> gameNameLength = games.OrderByDescending(x => x.Length);

            foreach(var i in gameNameLength)
            {
                Console.WriteLine(i);
            }


          
        }
    }
}
