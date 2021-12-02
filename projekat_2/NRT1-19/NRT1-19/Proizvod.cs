using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRT1_19
{
    class Proizvod
    {
        private int id;
        private int kolicina;

        public Proizvod(int id, int kolicina)
        {
            this.Id = id;
            this.Kolicina = kolicina;
        }

        public int Id { get => id; set => id = value; }
        public int Kolicina { get => kolicina; set => kolicina = value; }
    }
}
