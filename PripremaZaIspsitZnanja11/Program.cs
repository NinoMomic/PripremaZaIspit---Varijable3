using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PripremaZaIspsitZnanja11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Broj1, Broj2, ZajednickiDjelitelj, NajveciDjelitelj = 1;
            Console.WriteLine("Unesite prvi broj: ");
            string Brojevi = Console.ReadLine();
            Broj1 = Convert.ToInt32(Brojevi);
            Console.WriteLine("Unesite drugi broj: ");
            Brojevi = Console.ReadLine();
            Broj2 = Convert.ToInt32(Brojevi);
            ZajednickiDjelitelj = Broj1 < Broj2 ? Broj1 : Broj2;
            for(int i = ZajednickiDjelitelj; i >= 1; i--)
            {
                if(Broj1 % i == 0 && Broj2 % i == 0)
                {
                    NajveciDjelitelj = i;
                    break;
                }
            }
            Console.WriteLine("Najveci broj sakojime mozemo podijeliti ova dva broja je:" + NajveciDjelitelj);
            Console.ReadKey();
        }
    }
}
