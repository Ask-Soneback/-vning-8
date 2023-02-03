using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_8
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = false;
            Console.Write("ange ett heltal: ");
            double input = double.Parse(Console.ReadLine());
            double faktor = input;
            for (double i = 0; i <= input+1; i++)
            {
                if (faktor % i == 0 && i != 1 && i != faktor)
                {
                    check = true;
                    faktor = faktor / i;
                    Console.WriteLine($"en faktor är {i}");
                    //Console.WriteLine(faktor);
                    i = 0;
                }
                if(i == input && check)
                {
                    Console.WriteLine($"en faktor är {faktor}");
                }
                if (faktor == 1) { 
                    Console.WriteLine("en faktor är" + i);
                    break;
                }
            }

            if (!check)
            {
                Console.WriteLine("det är ett primtal");
            }
            else
            {
                Console.WriteLine("inte primtal");
            }
        }
    }
}
