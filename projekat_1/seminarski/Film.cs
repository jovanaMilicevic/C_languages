using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminarski
{
    [Serializable]
    class Film
    {
        private int idFilm;
        private string nazivFilma;
        private string zanr;
        private int trajanje;
        private int dozvoljeneGod;

        public Film(int idFilm, string nazivFilma, string zanr, int trajanje, int dozvoljeneGod)
        {
            IdFilm = idFilm;
            NazivFilma = nazivFilma;
            Zanr = zanr;
            Trajanje = trajanje;
            DozvoljeneGod = dozvoljeneGod;
        }

        public string NazivFilma { get => nazivFilma; set => nazivFilma = value; }
        public string Zanr { get => zanr; set => zanr = value; }
        public int Trajanje { get => trajanje; set => trajanje = value; }
        public int DozvoljeneGod { get => dozvoljeneGod; set => dozvoljeneGod = value; }
        public int IdFilm { get => idFilm; set => idFilm = value; }

        public override string ToString()
        {
            return "\n ID filma: " + idFilm + " Naziv filma: " + nazivFilma + " Zanr: " + zanr + " Duzina trajanja filma: " + trajanje + " minuta "+ " Nije preporuceno za mladje od: " + dozvoljeneGod;
        }

        public string Shortname
        {
            get { return $"{idFilm} : {NazivFilma}"; }
        }
    }
}
