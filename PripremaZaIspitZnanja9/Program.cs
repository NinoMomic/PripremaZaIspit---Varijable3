using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PripremaZaIspitZnanja9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n3.1");
            for (int i = 1900; i <= 2100; i++)
                if ((i % 400 == 0) || (i % 4 == 0 && i % 100 != 0))
                    Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
