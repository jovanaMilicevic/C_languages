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
/*ne radi mi cbSala*/
namespace seminarski
{
    public partial class Form7 : Form
    {
        FileStream fs;
        string putanja = "Projekcija.txt";
        string putanjaFilm = "Filmovi.txt";
        string putanjaSala = "Sale.txt";
        string putanjaRezervacije = "Rezervacije.txt";

        List<Projekcija> projekcije;
        List<Film> filmovi;
        List<Sala> sale;
        List<Rezervacije> rezervacije;
        BinaryFormatter bf = new BinaryFormatter();

        public Form7()
        {
            InitializeComponent();

            if (File.Exists(putanja))
            {
                fs = File.OpenRead(putanja);
                projekcije = bf.Deserialize(fs) as List<Projekcija>;
                fs.Close();

                fs = File.OpenRead(putanjaFilm);
                filmovi = bf.Deserialize(fs) as List<Film>;
                fs.Close();

                fs = File.OpenRead(putanjaSala);
                sale = bf.Deserialize(fs) as List<Sala>;
                fs.Close();

                fs = File.OpenRead(putanjaRezervacije);
                rezervacije = bf.Deserialize(fs) as List<Rezervacije>;
                fs.Close();
            }
            else
            {
                projekcije = new List<Projekcija>();
                filmovi = new List<Film>();
                sale = new List<Sala>();
                rezervacije = new List<Rezervacije>();
            }

            cbFilm.DisplayMember = "Shortname";
            cbIzmeniFilm.DisplayMember = "Shortname";
            cbSala.DisplayMember = "Shortname2";
            cbIzmeniSalu.DisplayMember = "Shortname2";

            foreach (Projekcija p in projekcije)
            {
                cbIzmeni.Items.Add(p);
                cbDodaj.Items.Add(p);
                cbObrisi.Items.Add(p);
            }
            foreach(Film f in filmovi)
            { 
                cbFilm.Items.Add(f);
                cbIzmeniFilm.Items.Add(f);
            }

            foreach (Sala s in sale)
            { 
                cbSala.Items.Add(s);
                cbIzmeniSalu.Items.Add(s);
            }

        }


        private void btnDodaj_Click(object sender, EventArgs e)
        {
            int cena;

            if(cbFilm.SelectedItem == null || cbSala.SelectedItem == null || txtDodajVreme.Text.Trim().Length == 0 || txtDodajCena.Text.Trim().Length == 0)
            {
                MessageBox.Show("Niste uneli potrebne informacije");
                return;
            }
            else if (!int.TryParse(txtDodajCena.Text, out cena))
            {
                MessageBox.Show("Niste uneli cenu karte");
                return;
            }
            projekcije.Add(new Projekcija(projekcije.Count+1,dateTimePicker2.Value, cbSala.SelectedItem as Sala, cena, txtDodajVreme.Text, cbFilm.SelectedItem as Film));
            

            fs = File.OpenWrite(putanja);
            bf.Serialize(fs, projekcije);

            fs.Close();

            cbIzmeni.Items.Clear();
            cbDodaj.Items.Clear();
            cbObrisi.Items.Clear();
            foreach(Projekcija p in projekcije)
            {
                cbIzmeni.Items.Add(p);
                cbDodaj.Items.Add(p);
                cbObrisi.Items.Add(p);
            }

            MessageBox.Show("Uspesno ste dodali projekciju");
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            int a;
            Projekcija pr = cbObrisi.SelectedItem as Projekcija;
            a = pr.IdProjekcije;
            foreach (Rezervacije r in rezervacije)
            {
                if (r.IdProjekat == a)
                {
                    MessageBox.Show("Ne mozete obrisati projekciju jer postoji rezervacija vezana za nju");
                    return;
                }
            }

            if (cbObrisi.SelectedItem == null)
            {
                MessageBox.Show("Niste izabrali projekciju za brisanje");
                return;
            }

            for (int i = 0; i < projekcije.Count; i++)
            {
                if (cbObrisi.SelectedItem as Projekcija == projekcije[i])
                {
                    projekcije.RemoveAt(i);
                    MessageBox.Show("Projekcija je uspesno obrisana");

                    fs = File.OpenWrite(putanja);
                    bf.Serialize(fs, projekcije);

                    fs.Close();

                    cbIzmeni.Items.Clear();
                    cbDodaj.Items.Clear();
                    cbObrisi.Items.Clear();
                    foreach (Projekcija p in projekcije)
                    {
                        cbIzmeni.Items.Add(p);
                        cbDodaj.Items.Add(p);
                        cbObrisi.Items.Add(p);
                    }
                    return;
                }
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            int cena;
            if (cbIzmeni.SelectedItem == null)
            {
                MessageBox.Show("Niste izabrali projekciju");
                return;
            }
            else if (cbIzmeniFilm.SelectedItem == null || cbIzmeniSalu.SelectedItem == null || txtIzmeniVreme.Text.Trim().Length == 0 || txtIzmeniCenu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Niste uneli sve potrebne informacije");
                return;
            }
            else if (!int.TryParse(txtIzmeniCenu.Text, out cena))
            {
                MessageBox.Show("Niste uneli broj za cenu");
                return;
            }
            for (int i = 0; i < projekcije.Count; i++)
            {
                if (cbIzmeni.SelectedItem as Projekcija == projekcije[i])
                {
                    projekcije[i].Film = cbIzmeniFilm.SelectedItem as Film;
                    projekcije[i].Sala = cbIzmeniSalu.SelectedItem as Sala;
                    projekcije[i].DatProjekcije = dtIzmeniDatum.Value;
                    projekcije[i].VremePocetka = txtIzmeniVreme.Text;
                    projekcije[i].Cena = cena;

                    MessageBox.Show("Uspesno ste azurirali podatke");

                    cbIzmeni.Items.Clear();
                    cbDodaj.Items.Clear();
                    cbObrisi.Items.Clear();
                    foreach (Projekcija pr in projekcije)
                    { 
                        cbIzmeni.Items.Add(pr);
                        cbDodaj.Items.Add(pr);
                        cbObrisi.Items.Add(pr);
                    }
                        
                    return;
                }
            }
        }

        private void cbIzmeni_SelectedIndexChanged(object sender, EventArgs e)
        {
            Projekcija projekcija = cbIzmeni.SelectedItem as Projekcija;
            for(int i = 0; i < cbIzmeniFilm.Items.Count; i++)
            {
                cbIzmeniFilm.SelectedIndex = i;
                if (cbIzmeniFilm.SelectedItem as Film == projekcija.Film)
                    break;
            }
            dtIzmeniDatum.Value = projekcija.DatProjekcije;
            txtIzmeniVreme.Text = projekcija.VremePocetka;
            txtIzmeniCenu.Text = projekcija.Cena.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
