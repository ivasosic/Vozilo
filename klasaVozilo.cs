using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vozilo
{
    internal class klasaVozilo
    {
        string vrsta;
        int max_brzina;
        int br_kotaca;

        public string Vrsta { get => vrsta; set => vrsta = value; }
        public int Max_brzina { get => max_brzina; set => max_brzina = value; }
        public int Br_kotaca { get => br_kotaca; set => br_kotaca = value; }

        public klasaVozilo(string vrsta, int max_brzina, int br_kotaca)
        {
            this.Vrsta = vrsta;
            this.Max_brzina = max_brzina;
            this.Br_kotaca = br_kotaca;
        }

        public klasaVozilo()
        {
            this.Vrsta = vrsta;
            this.Max_brzina = max_brzina;
            this.Br_kotaca = br_kotaca;

        }

        public override string ToString()
        {
            string str = "Vrsta: " + vrsta + "\n Broj kotača: " + br_kotaca + "\n Max brzina: " + max_brzina;
            return str;
        }

    }
}
