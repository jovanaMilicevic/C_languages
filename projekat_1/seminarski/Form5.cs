using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seminarski
{
    public partial class Form5 : Form
    {
        int idKor;

        FileStream fs;
        string putanja = "Filmovi.txt";
        string putanjaProjekcija = "Projekcija.txt";
        string putanjaSala = "Sale.txt";
        string putanjaRezervacija = "Rezervacije.txt";

        List<Film> filmovi;
        List<Projekcija> projekcije;
        List<Sala> sale;
        List<Rezervacije> rezervacije;

        List<Projekcija> novaProjekcija = new List<Projekcija>();

        BinaryFormatter bf = new BinaryFormatter();
        public Form5(int idKorisnika)
        {
            InitializeComponent();
            idKor = idKorisnika;
            filmovi = new List<Film>();

            fs = File.OpenRead(putanja);
            BinaryFormatter bf = new BinaryFormatter();
            filmovi = bf.Deserialize(fs) as List<Film>;
            fs.Close();

            if (File.Exists(putanjaProjekcija))
            {
                fs = File.OpenRead(putanjaProjekcija);
                projekcije = bf.Deserialize(fs) as List<Projekcija>;
                fs.Close();

            }
            else
            {
                projekcije = new List<Projekcija>();
            }

            if (File.Exists(putanjaSala))
            {
                fs = File.OpenRead(putanjaSala);
                sale = bf.Deserialize(fs) as List<Sala>;
                fs.Close();

            }
            else
            {
                projekcije = new List<Projekcija>();
            }

            if (File.Exists(putanjaRezervacija))
            {
                fs = File.OpenRead(putanjaRezervacija);
                rezervacije = bf.Deserialize(fs) as List<Rezervacije>;
                fs.Close();
            }
            else
            {
                rezervacije = new List<Rezervacije>();
            }

            cmbNaziv.DisplayMember = "Shortname";
            cmbSala.DisplayMember = "Shortname2";
            lbRepertoar.DisplayMember = "Shortname3";

            foreach (Film f in filmovi)
                cmbNaziv.Items.Add(f);

            foreach (Sala s in sale)
                cmbSala.Items.Add(s);

        }

        private void ptnPrikazi_Click(object sender, EventArgs e)
        {
            if (cmbNaziv.SelectedItem == null || cmbSala.SelectedItem == null)
            {
                MessageBox.Show("Niste odabrali film ili salu");
                return;
            }
            else if (dtPocetni.Value > dtKrajnji.Value)
            {
                MessageBox.Show("Pocetni datum ne moze da bude veci od krajnjeg....");
                return;
            }

            novaProjekcija.Clear();


            foreach (Projekcija pr in projekcije)
            {

                if (pr.DatProjekcije >= dtPocetni.Value && pr.DatProjekcije <= dtKrajnji.Value && pr.Sala.Shortname2 == (cmbSala.SelectedItem as Sala).Shortname2 && pr.Film.Shortname == (cmbNaziv.SelectedItem as Film).Shortname)
                {
                    novaProjekcija.Add(pr);
                }
                
            }
            

            this.lbRepertoar.DataSource = null;
            this.lbRepertoar.DataSource = novaProjekcija; 
            
            if (lbRepertoar.Items.Count == 0)
                {
                    MessageBox.Show("Ne postoje projekcije za izabrane vrednosti");
                    return;
                }
        }


        private void dodaj(object sender, EventArgs e)
        {
            if (lbRepertoar.SelectedItem != null)
                txtCena.Text = ((int)numericUpDown1.Value * ((Projekcija)lbRepertoar.SelectedItem).Cena).ToString();
            else if(lbRepertoar.SelectedItem == null)
            {
                MessageBox.Show("Niste izabrali projekciju");
                numericUpDown1.Value = 1;
                return;
            }
        }

        private void btnRezervisi_Click(object sender, EventArgs e)
        {
            if(lbRepertoar.SelectedItem != null)
            {
                rezervacije.Add(new Rezervacije(
                        (lbRepertoar.SelectedItem as Projekcija).IdProjekcije, idKor, (int)numericUpDown1.Value, int.Parse(txtCena.Text)
                    ));
            }
            else
            {
                MessageBox.Show("Nisu unete sve potrebne vrednosti");
                return;
            }

            for (int i = 0; i < projekcije.Count; i++)
            {
                if (projekcije[i].IdProjekcije == rezervacije[rezervacije.Count - 1].IdProjekat)
                {
                    projekcije[i].SlobodnaMesta -= rezervacije[rezervacije.Count - 1].BrojMesta;
                }
            }

            fs = File.OpenWrite(putanjaProjekcija);
            bf.Serialize(fs, projekcije);
            fs.Close();

            fs = File.OpenWrite(putanjaRezervacija);
            bf.Serialize(fs, rezervacije);



            MessageBox.Show("Uspesna rezervacija");
            fs.Close();
            

            this.Hide();
            var f4 = new Form4(idKor);
            f4.Closed += (s, args) => this.Close();
            f4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f4 = new Form4(idKor);
            f4.Closed += (s, args) => this.Close();
            f4.Show();
        }

        private void lbRepertoar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
