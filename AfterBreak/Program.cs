using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AfterBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int> { 5, 2, 8, 9, 3, 1, 0, 3, 5, 4, 8, 6, 9, 3 };
            var x = 2;
            lista.Remove(0);

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}
