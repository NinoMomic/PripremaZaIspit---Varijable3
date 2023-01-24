using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PripremaZaIspitZnanja10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char Privremeno = ' ';
            int Brojac, NajveciBroj = 0;
            Console.WriteLine("Unesite riječ:");
            string niz = Console.ReadLine();
            for (int i = 0; i < niz.Length; i++)
            {
                Brojac = 0;
                for (int j = 0; j < niz.Length; j++)
                    if (niz[i] == niz[j])
                        Brojac++;
                if (Brojac > NajveciBroj)
                {
                    Privremeno = niz[i];
                    NajveciBroj = Brojac;
                }
            }
            Console.WriteLine("Znak " + Privremeno + " se pojavljuje "+ NajveciBroj +" puta ");

            Console.ReadKey();
        }
    }
}
