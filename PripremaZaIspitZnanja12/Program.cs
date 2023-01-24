using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PripremaZaIspitZnanja12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Broj;
            Console.WriteLine("Unesite pozitivan broj: ");
            string Br = Console.ReadLine();
            Broj = Convert.ToInt32(Br);
            for (int i = 1; i < Broj; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(j);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
