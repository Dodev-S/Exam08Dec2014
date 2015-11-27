using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.JoroVratarq
{
    class JoroVratarq
    {
        static void Main(string[] args)
        {
            string leap = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int hometown = int.Parse(Console.ReadLine());

            double numberOfPlays = holidays / 2.0;
            numberOfPlays += hometown;
            numberOfPlays += ((52 - hometown) * (2.0 / 3));

            if (leap == "t")
            {
                numberOfPlays += 3;
            }

            Console.WriteLine((int)numberOfPlays);
        }
    }
}
