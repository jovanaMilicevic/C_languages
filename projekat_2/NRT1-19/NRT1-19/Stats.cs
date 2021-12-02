using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRT1_19
{
    class Stats
    {
        private string naziv;
        private int kolicina, id;
        private double procenat;

        public Stats(string naziv, int kolicina, double procenat, int id)
        {
            this.Naziv = naziv;
            this.Kolicina = kolicina;
            this.Procenat = procenat;
            this.Id = id;
        }

        public string Naziv { get => naziv; set => naziv = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }
        public double Procenat { get => procenat; set => procenat = value; }
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            return $"{naziv}  ( {kolicina} ) => {procenat}%";
        }
    }
}
