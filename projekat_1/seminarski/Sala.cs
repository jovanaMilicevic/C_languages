using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminarski
{
    [Serializable]
    class Sala
    {
        private int idSala;
        private int brSale;
        private int brSedista;

        public Sala(int idSala,int brSale, int brSedista)
        {
            this.BrSale = brSale;
            this.BrSedista = brSedista;
            this.idSala = idSala;
        }

        public int BrSale { get => brSale; set => brSale = value; }
        public int BrSedista { get => brSedista; set => brSedista = value; }
        public int IdSala { get => idSala; set => idSala = value; }

        public override string ToString()
        {
            return "\n ID sale: " + idSala + " Broj sale: " + brSale + " Ukupan broj sedista: " + brSedista;
        }
        public string Shortname2
        {
            get { return $"{idSala} : {brSale}, mesta: {brSedista}"; }
        }
    }
}
