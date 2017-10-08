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
            Console.WriteLine("Type in your dice. e.g. 2d6 or 1d20");
            reader = Console.ReadLine();
            diceNumber = reader[0];
            diceSides = reader[3 + 4];
            Console.WriteLine("Any mods? If none type 0");
            reader = Console.ReadLine();
            mod = Convert.ToInt16(reader);

            //perform rolls
            for (int i = 0; i < diceNumber; i++)
            {
                total += Random.Next(1, diceSides);
            }
            total += mod;

            //display results
            Console.WriteLine($"{diceNumber}d{diceSides} + {mod} result: {total}");
        }
    }
}
