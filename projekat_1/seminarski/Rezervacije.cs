using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminarski
{
    [Serializable]
    class Rezervacije
    {
        private int idProjekat;
        private int idKupac;
        private int brojMesta;
        private int cena;

        public Rezervacije(int idProjekat, int idKupac, int brojMesta, int cena)
        {
            this.idProjekat = idProjekat;
            this.idKupac = idKupac;
            this.brojMesta = brojMesta;
            this.cena = cena;
        }

        public int IdProjekat { get => idProjekat; set => idProjekat = value; }
        public int IdKupac { get => idKupac; set => idKupac = value; }
        public int BrojMesta { get => brojMesta; set => brojMesta = value; }
        public int Cena { get => cena; set => cena = value; }

        public override string ToString()
        {
            return "\n ID projekta: " + idProjekat + "ID kupca: " + idKupac + " Broj mesta: " + brojMesta + " Cena: " + cena;
        }
    }
}
