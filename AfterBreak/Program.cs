using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 24;
            int j = number;
            List<int> array = new List<int>();

                bool i = true;
                while (i)
                {
                    for (int k = 2; k <= number; k++)
                    {
                        if (number % k == 0)
                        {
                            Console.WriteLine($"Liczba podzielna przez {k}");
                            number = number / k;
                            k = 1;
                            array.Add(k);
                            
                        }

                    }
                    i = false;
                }

            Console.ReadKey();
        }
    }
}
