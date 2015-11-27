using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sunglasses
{
    class Sunglasses
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', 2 * n) + new string (' ', n) + new string ('*', 2 * n));
            for (int i = 0; i < n - 2; i++)
            {
                if (i == (n - 2) / 2)
                {
                    Console.WriteLine('*'
                        + new string('/', 2 * n - 2)
                        + '*'
                        + new string('|', n)
                        + '*'
                        + new string('/', 2 * n - 2)
                        + '*'
                        );
                }
                else
                {
                Console.WriteLine('*'
                    + new string('/', 2 * n - 2)
                    + '*'
                    + new string (' ', n)
                    + '*'
                    + new string('/', 2 * n - 2)
                    + '*'
                    );
                }
            }
            Console.WriteLine(new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n));
        }
    }
}
