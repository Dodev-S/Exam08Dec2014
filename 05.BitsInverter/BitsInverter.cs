using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BitsInverter
{
    class BitsInverter
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            byte step = byte.Parse(Console.ReadLine());
            byte[] result = new byte[n];
            byte positon = 0;

            for (int i = 0; i < n; i++)
            {
                result[i] = byte.Parse(Console.ReadLine());
            }


            for (int i = 0; i < result.Length; i++)
            {
                positon = (byte)(7 - positon);
                byte mask = (byte)((1) << positon);
                byte tempMask = (byte)(mask & result[i]);

                if (tempMask == 0)
                {
                    result[i] |= mask;
                }
                else
                {
                    result[i] = (byte)(result[i] & (~mask)); 
                }
                positon = (byte)(7 - positon);
                positon += step;
                if (positon > 7)
                {
                    positon = (byte)(positon - 8);
                }
                else 
                {
                    i--;
                }

                while (positon > 7)
                {
                    positon = (byte)(positon - 8);
                    i++;
                }


            }

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

        }
    }
}
