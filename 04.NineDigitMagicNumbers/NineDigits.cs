using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NineDigitMagicNumbers
{
    class NineDigits
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int diff = int.Parse(Console.ReadLine());
            List<int> result = new List<int>();
            bool notTooBig = true;

            for (int i = 1; i < 8; i++)
            {
                for (int i1 = 1; i1 < 8; i1++)
                {
                    for (int i2 = 1; i2 < 8; i2++)
                    {
                        notTooBig = true;
                        string temp = i.ToString() + i1 + i2;
                        int test = int.Parse(temp);
                        int test1 = test + diff;
                        int test2 = test1 + diff;
                        temp = test.ToString() + test1 + test2;
                        test = 0;

                        for (int i4 = 0; i4 < 9; i4++)
                        {
                            if (int.Parse(temp[i4].ToString()) > 7 || int.Parse(temp[i4].ToString()) == 0)
                            {
                                notTooBig = false;
                            }
                            
                        }

                        if (notTooBig)
                        {
                            for (int i3 = 0; i3 < 9; i3++)
                            {
                            
                                test += int.Parse(temp[i3].ToString());
                            }

                            if (test == sum && temp.Length == 9)
                            {
                                result.Add(int.Parse(temp));
                            }
                        }
                    }
                }
            }

            Array.Sort(result.ToArray());

            if (result.Count > 0)
            {

                for (int i = 0; i < result.Count; i++)
                {
                    Console.WriteLine(result[i]);
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
