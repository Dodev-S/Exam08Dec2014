using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.HalfSum
{
    class HalfSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < n; i++)
            {
                sum1 += int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                sum2 += int.Parse(Console.ReadLine());
            }

            if (sum2 == sum1)
            {
                Console.WriteLine("Yes, sum={0}", sum2);
            }
            else
            {
                Console.WriteLine("No, diff={0}", Math.Abs(sum2 - sum1));
            }
        }
    }
}
