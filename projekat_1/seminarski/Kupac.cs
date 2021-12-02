using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminarski
{
    [Serializable]
    class Kupac : Korisnik
    {
        private int idKupca;
        private string ime;
        private string prezime;
        private DateTime datum;
        private string brTel;
        private string pol;

        public Kupac(int idKupca, string korIme, string sifra, string ime, string prezime, DateTime datum, string brTel, string pol) : base(korIme,sifra)
        {
            this.idKupca = idKupca;
            this.ime = ime;
            this.prezime = prezime;
            this.datum = datum;
            this.brTel = brTel;
            this.pol = pol;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        public string BrTel { get => brTel; set => brTel = value; }
        public string Pol { get => pol; set => pol = value; }
        public int IdKupca { get => idKupca; set => idKupca = value; }

        public override string ToString()
        {
            return "\n ID kupca: " + idKupca + " Ime: " + ime + " Prezime: " + prezime + " Datum rodjenja: " + datum + " Broj telefona: " + brTel + " Pol: " + pol;
        }

    }

}
