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
    public partial class Form10 : Form
    {
        FileStream fs;
        List<Kupac> kupci;
        string putanja = "Registracija.txt";

        BinaryFormatter bf = new BinaryFormatter();
        public Form10()
        {
            InitializeComponent();

            if (File.Exists(putanja))
            {
                fs = File.OpenRead(putanja);
                kupci = bf.Deserialize(fs) as List<Kupac>;
                fs.Close();
            }
            else
            {
                kupci = new List<Kupac>();
            }

            foreach(Kupac k in kupci)
            {
                cbIzmeni.Items.Add(k);
                cbDodaj.Items.Add(k);
                cbObrisi.Items.Add(k);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if(txtDodajKor.Text.Trim().Length == 0 || txtDodajPass.Text.Trim().Length == 0 || txtDodajIme.Text.Trim().Length == 0 || txtDodajPrezime.Text.Trim().Length == 0 || cbDodajPol.SelectedItem == null || txtDodajTel.Text.Trim().Length == 0)
            {
                MessageBox.Show("Niste uneli sve potrebne informacije");
                return;
            }
            kupci.Add(new Kupac(kupci.Count+1,txtDodajKor.Text, txtDodajPass.Text, txtDodajIme.Text,txtDodajPrezime.Text,dtDodajDatum.Value,txtDodajTel.Text,cbDodajPol.SelectedItem.ToString()));

            fs = File.OpenWrite(putanja);
            bf.Serialize(fs, kupci);

            fs.Close();

            MessageBox.Show("Uspesno ste dodali korisnika");

            cbIzmeni.Items.Clear();
            cbDodaj.Items.Clear();
            cbObrisi.Items.Clear();
            foreach (Kupac k in kupci)
            {
                cbIzmeni.Items.Add(k);
                cbDodaj.Items.Add(k);
                cbObrisi.Items.Add(k);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (cbObrisi.SelectedItem == null)
            {
                MessageBox.Show("Niste izabrali korisnika");
                return;
            }
            for (int i = 0; i < kupci.Count; i++)
            {
                if (cbObrisi.SelectedItem as Kupac == kupci[i])
                {
                    kupci.RemoveAt(i);
                    MessageBox.Show("Uspesno ste obrisali korisnika");
                    break;
                }
            }

            cbIzmeni.Items.Clear();
            cbDodaj.Items.Clear();
            cbObrisi.Items.Clear();
            foreach (Kupac k in kupci)
            {
                cbIzmeni.Items.Add(k);
                cbDodaj.Items.Add(k);
                cbObrisi.Items.Add(k);
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (cbIzmeni.SelectedItem == null)
            {
                MessageBox.Show("Niste izabrali korisnika");
                return;
            }
            else if (txtIzmeniKor.Text.Trim().Length == 0 || txtIzmeniPass.Text.Trim().Length == 0 || txtIzmeniIme.Text.Trim().Length == 0 || txtIzmeniPrezime.Text.Trim().Length == 0 || cbIzmeniPol.SelectedItem == null || txtIzmeniTel.Text.Trim().Length == 0)
            {
                MessageBox.Show("Niste uneli sve potrebne informacije");
                return;
            }
            for (int i = 0; i < kupci.Count; i++)
            {
                if (kupci[i] == cbIzmeni.SelectedItem as Kupac)
                {
                    kupci[i].KorIme = txtIzmeniKor.Text;
                    kupci[i].Sifra = txtIzmeniPass.Text;
                    kupci[i].Ime = txtIzmeniIme.Text;
                    kupci[i].Prezime = txtIzmeniPrezime.Text;
                    kupci[i].Pol = cbIzmeniPol.SelectedItem.ToString();
                    kupci[i].BrTel = txtIzmeniTel.Text;
                    kupci[i].Datum = dtIzmeniDatum.Value;

                    MessageBox.Show("Uspesno ste azurirali podatke");
                    cbIzmeni.Items.Clear();
                    cbDodaj.Items.Clear();
                    cbObrisi.Items.Clear();
                    foreach (Kupac k in kupci)
                    {
                        cbIzmeni.Items.Add(k);
                        cbDodaj.Items.Add(k);
                        cbObrisi.Items.Add(k);
                    }
                    return;
                }
            }
        }

        private void cbIzmeni_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kupac kupac = cbIzmeni.SelectedItem as Kupac;
            txtIzmeniKor.Text = kupac.KorIme;
            txtIzmeniPass.Text = kupac.Sifra;
            txtIzmeniIme.Text = kupac.Ime;
            txtDodajPrezime.Text = kupac.Prezime;
            if (kupac.Pol == "musko")
                cbIzmeniPol.SelectedIndex = 0;
            else
                cbIzmeniPol.SelectedIndex = 1;
            txtIzmeniTel.Text = kupac.BrTel;
            dtIzmeniDatum.Value = kupac.Datum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
