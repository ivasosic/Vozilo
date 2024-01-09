using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozilo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            klasaVozilo Motocikl1 = new klasaVozilo("Yamaha", 310, 2);
            klasaVozilo Automobil = new klasaVozilo("Nissan", 380, 4);


            Console.WriteLine(Motocikl1.ToString());
            Console.WriteLine(Automobil.ToString());
            Console.ReadKey();
        }
    }
}
