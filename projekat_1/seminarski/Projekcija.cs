using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminarski
{
    [Serializable]
    class Projekcija
    {
        private int idProjekcije;
        private DateTime datProjekcije;
        private Sala sala;
        private int cena;
        private string vremePocetka;
        private Film film;
        private int slobodnaMesta;

        public Projekcija(int idProjekcije, DateTime datProjekcije, Sala sala, int cena, string vremePocetka, Film film)
        {
            this.IdProjekcije = idProjekcije;
            this.DatProjekcije = datProjekcije;
            this.Sala = sala;
            this.Cena = cena;
            this.VremePocetka = vremePocetka;
            this.Film = film;
            slobodnaMesta = sala.BrSedista;
        }

        public int IdProjekcije { get => idProjekcije; set => idProjekcije = value; }
        public DateTime DatProjekcije { get => datProjekcije; set => datProjekcije = value; }
        public int Cena { get => cena; set => cena = value; }
        public string VremePocetka { get => vremePocetka; set => vremePocetka = value; }
        internal Sala Sala { get => sala; set => sala = value; }
        internal Film Film { get => film; set => film = value; }

        public int SlobodnaMesta { get => slobodnaMesta; set => slobodnaMesta = value; }

        public override string ToString() 
        {
            return "ID Projekcije: " + this.idProjekcije + " Datum projekcije: " + datProjekcije + " Sala u kojoj je projekcija: " + sala.IdSala + " Cena karte: " + cena + " Vreme pocetka projekcije: " + vremePocetka + " Film: " + film.ToString() + " Broj slobodnih mesta: " + slobodnaMesta;
        }

        public string Shortname3
        {
            get { return $"Sala: {sala.BrSale}, Film: {film.NazivFilma}, cena karte: {cena}, vreme pocetka: { vremePocetka}, broj slobodnih mesta: {SlobodnaMesta}"; }
        }
    }
}
