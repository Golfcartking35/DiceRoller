using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare stuff
            int diceSides, diceNumber, mod;
            string reader;
            int total = 0;

            Random Random = new Random();

            //get information
            Console.WriteLine("How many die?");
            reader = Console.ReadLine();
            diceNumber = Convert.ToInt32(reader);
            Console.WriteLine("How many sides on the die?");
            reader = Console.ReadLine();
            diceSides = Convert.ToInt32(reader);
            Console.WriteLine("Any mods? If none enter 0.");
            reader= Console.ReadLine();
            mod = Convert.ToInt32(reader);

            //perform rolls
            for (int i = 0; i < diceNumber; i++)
            {
                total += Random.Next(1, diceSides);
            }
            total += mod;

            //display results
            Console.WriteLine($"{diceNumber}d{diceSides} + {mod} result: {total}");
        }//end of main
    }//end of class
}   
