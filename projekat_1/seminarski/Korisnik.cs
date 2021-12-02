using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminarski
{
    [Serializable]
    class Korisnik
    {
        private string korIme;
        private string sifra;

        public Korisnik(string korIme, string sifra)
        {
            this.korIme = korIme;
            this.sifra = sifra;
        }

        public string KorIme { get => korIme; set => korIme = value; }
        public string Sifra { get => sifra; set => sifra = value; }

        public override string ToString()
        {
            return $"\n Korisnicko ime: {korIme} lozinka: {sifra}";
        }
    }
}
