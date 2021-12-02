using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NRT1_19
{
    class Statistika
    {
        List<Proizvod> proizvodi;
        private DateTime datum;

        public Statistika()
        {
            proizvodi = new List<Proizvod>();
        }

        public Statistika(List<Proizvod> proizvodi, DateTime datum)
        {
            this.Proizvodi = proizvodi;
            this.Datum = datum;
        }

        public DateTime Datum { get => datum; set => datum = value; }
        internal List<Proizvod> Proizvodi { get => proizvodi; set => proizvodi = value; }
    }
}
