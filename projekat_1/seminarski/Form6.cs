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
    public partial class Form6 : Form
    {
        FileStream fs;
        string putanja = "Filmovi.txt";

        List<Film> filmovi;
        BinaryFormatter bf = new BinaryFormatter();
        public Form6()
        {
            InitializeComponent();
            if(File.Exists(putanja))
            { 
                fs = File.OpenRead(putanja);
                filmovi = bf.Deserialize(fs) as List<Film>;
                fs.Close();
                
            }
            else
            {
                filmovi = new List<Film>();
            }

            foreach (Film fm in filmovi)
            {
                cbIzmeni.Items.Add(fm);
                cbDodaj.Items.Add(fm);
                cbObrisi.Items.Add(fm);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            int trajanje;
            int dozvoljeneGod;

            if(txtDodajNaziv.Text.Trim().Length == 0 || txtDodajZanr.Text.Trim().Length == 0 || txtDodajTrajanje.Text.Trim().Length == 0 || txtGodine.Text.Trim().Length == 0)
            {
                MessageBox.Show("Niste uneli potrebne informacije");
                return;
            }
            else if(!int.TryParse(txtDodajTrajanje.Text, out trajanje))
            {
                MessageBox.Show("Niste uneli broj za duzinu trajanja filma");
                return;
            }
            else if(!int.TryParse(txtGodine.Text, out dozvoljeneGod))
            {
                MessageBox.Show("Niste uneli broj za dozvoljene godine");
                return;
            }

            filmovi.Add(new Film(filmovi.Count+1,txtDodajNaziv.Text, txtDodajZanr.Text, trajanje, dozvoljeneGod));

            fs = File.OpenWrite(putanja);
            bf.Serialize(fs, filmovi);

            fs.Close();
            MessageBox.Show("Uspesno ste dodali film");

            cbIzmeni.Items.Clear();
            cbDodaj.Items.Clear();
            cbObrisi.Items.Clear();
            foreach (Film f in filmovi)
            {
                cbIzmeni.Items.Add(f);
                cbDodaj.Items.Add(f);
                cbObrisi.Items.Add(f);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if(cbObrisi.SelectedItem == null)
            {
                MessageBox.Show("Niste izabrali film za brisanje");
                return;
            }

            for(int i = 0; i < filmovi.Count; i++)
            {
                if(cbObrisi.SelectedItem as Film == filmovi[i])
                {
                    filmovi.RemoveAt(i);
                    MessageBox.Show("Film je uspesno obrisan");

                    fs = File.OpenWrite(putanja);
                    bf.Serialize(fs, filmovi);

                    fs.Close();

                    cbIzmeni.Items.Clear();
                    cbDodaj.Items.Clear();
                    cbObrisi.Items.Clear();
                    foreach (Film f in filmovi)
                    {
                        cbIzmeni.Items.Add(f);
                        cbDodaj.Items.Add(f);
                        cbObrisi.Items.Add(f);
                    }
                    return;
                }
            }
            
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            int trajanje;
            int dozvoljeneGod;

            if(cbIzmeni.SelectedItem == null)
            {
                MessageBox.Show("Niste izabrali film");
                return;
            }
            else if(txtIzmeniNaziv.Text.Trim().Length == 0 || txtIzmeniZanr.Text.Trim().Length == 0 || txtIzmeniTrajanje.Text.Trim().Length == 0 || txtIzmeniGod.Text.Trim().Length == 0)
            {
                MessageBox.Show("Niste uneli sve potrebne informacije");
                return;
            }
            else if(!int.TryParse(txtIzmeniTrajanje.Text, out trajanje) || !int.TryParse(txtIzmeniGod.Text, out dozvoljeneGod))
            {
                MessageBox.Show("Niste uneli broj za trajanje ili za dozvoljene godine");
                return;
            }

            for(int i = 0; i < filmovi.Count; i++)
            {
                if(cbIzmeni.SelectedItem as Film == filmovi[i])
                {
                    filmovi[i].NazivFilma = txtIzmeniNaziv.Text;
                    filmovi[i].Zanr = txtIzmeniZanr.Text;
                    filmovi[i].Trajanje = trajanje;
                    filmovi[i].DozvoljeneGod = dozvoljeneGod;

                    MessageBox.Show("Uspesno ste azurirali podatke");
                    cbIzmeni.Items.Clear();
                    cbDodaj.Items.Clear();
                    cbObrisi.Items.Clear();
                    foreach (Film f in filmovi)
                    {
                        cbIzmeni.Items.Add(f);
                        cbDodaj.Items.Add(f);
                        cbObrisi.Items.Add(f);
                    }
                    break;
                }
            }
        }

        private void cbIzmeni_SelectedIndexChanged(object sender, EventArgs e)
        {
            Film film = cbIzmeni.SelectedItem as Film;
            txtIzmeniNaziv.Text = film.NazivFilma;
            txtIzmeniZanr.Text = film.Zanr;
            txtIzmeniTrajanje.Text = film.Trajanje.ToString();
            txtIzmeniGod.Text = film.DozvoljeneGod.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
