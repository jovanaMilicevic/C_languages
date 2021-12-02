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
    public partial class Form9 : Form
    {
        FileStream fs;
        string putanja = "Rezervacije.txt";
        string putanjaProjekcija = "Projekcija.txt";
        string putanjaKupci = "Registracija.txt";

        List<Rezervacije> rezervacije;
        List<Projekcija> projekcije;
        List<Kupac> kupci;

        BinaryFormatter bf = new BinaryFormatter();
        public Form9()
        {
            InitializeComponent();
            rezervacije = new List<Rezervacije>();

            if (File.Exists(putanja))
            {
                fs = File.OpenRead(putanja);
                rezervacije = bf.Deserialize(fs) as List<Rezervacije>;

                fs.Close();
                foreach (Rezervacije r in rezervacije)
                {
                    cbIzmeniR.Items.Add(r);
                    cbDodaj.Items.Add(r);
                    cbObrisi.Items.Add(r);
                }
            }
            if (File.Exists(putanjaProjekcija))
            {
                fs = File.OpenRead(putanjaProjekcija);
                projekcije = bf.Deserialize(fs) as List<Projekcija>;

                fs.Close();
                foreach (Projekcija p in projekcije)
                {
                    cbDodajId.Items.Add(p.IdProjekcije);
                    cbIzmeniId.Items.Add(p.IdProjekcije);
                }
            }
            else
            {
                projekcije = new List<Projekcija>();
            }

            if (File.Exists(putanjaKupci))
            {
                fs = File.OpenRead(putanjaKupci);
                kupci = bf.Deserialize(fs) as List<Kupac>;

                fs.Close();
                foreach (Kupac k in kupci)
                {
                    cbDodajIDKupca.Items.Add(k.IdKupca);
                    cbIzmeniIdKupca.Items.Add(k.IdKupca);
                }
            }


        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            int brMesta;
            int cena;

            if(cbDodajId.SelectedItem == null || cbDodajIDKupca.SelectedItem == null || txtDodajMesta.Text.Trim().Length == 0 || txtDodajCenu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Niste uneli potrebne informacije");
                return;
            }
            else if(!int.TryParse(txtDodajMesta.Text, out brMesta) || !int.TryParse(txtDodajCenu.Text, out cena))
            {
                MessageBox.Show("Niste uneli broj za broj mesta ili za cenu");
                return;
            }

            foreach(Projekcija proj in projekcije)
            {
                if(proj.IdProjekcije == (int)cbDodajId.SelectedItem)
                {
                    txtDodajCenu.Text = (proj.Cena * brMesta).ToString();
                    break;
                }
            }

            rezervacije.Add(new Rezervacije((int)cbDodajId.SelectedItem, (int)cbDodajIDKupca.SelectedItem, brMesta, cena));


            fs = File.OpenWrite(putanja);
            bf.Serialize(fs, rezervacije);

            fs.Close();

            MessageBox.Show("Uspesno ste dodali rezervaciju");

            cbIzmeniR.Items.Clear();
            cbObrisi.Items.Clear();
            cbDodaj.Items.Clear();
            foreach (Rezervacije r in rezervacije)
            {
                cbIzmeniR.Items.Add(r);
                cbObrisi.Items.Add(r);
                cbDodaj.Items.Add(r);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {

            if (cbObrisi.SelectedItem == null)
            {
                MessageBox.Show("Niste izabrali rezervaciju");
                return;
            }
            for (int i = 0; i < rezervacije.Count; i++)
            {
                if (cbObrisi.SelectedItem as Rezervacije == rezervacije[i])
                {
                    rezervacije.RemoveAt(i);
                    MessageBox.Show("Uspesno ste obrisali rezervaciju");
                    break;
                }
            }

            cbIzmeniR.Items.Clear();
            cbObrisi.Items.Clear();
            cbDodaj.Items.Clear();
            foreach (Rezervacije r in rezervacije)
            {
                cbIzmeniR.Items.Add(r);
                cbObrisi.Items.Add(r);
                cbDodaj.Items.Add(r);
            }
        }

        private void cbIzmeni_Click(object sender, EventArgs e)
        {
            int brMesta;
            if (cbIzmeniR.SelectedItem == null)
            {
                MessageBox.Show("Niste odabrali rezervaciju");
                return;
            }
            else if (cbIzmeniId.SelectedItem == null || cbIzmeniIdKupca.SelectedItem == null || txtIzmeniMesta.Text.Trim().Length == 0)
            {
                MessageBox.Show("Niste uneli sve potrebne informacije");
                return;
            }
            else if (!int.TryParse(txtIzmeniMesta.Text, out brMesta))
            {
                MessageBox.Show("Niste uneli broj za broj mesta");
                return;
            }
          
            for (int i = 0; i < rezervacije.Count; i++)
            {
                if (rezervacije[i] == cbIzmeniR.SelectedItem as Rezervacije)
                {
                    rezervacije[i].IdProjekat = (int)cbIzmeniId.SelectedItem;
                    rezervacije[i].IdKupac = (int)cbIzmeniIdKupca.SelectedItem;
                    rezervacije[i].BrojMesta = brMesta;
                    rezervacije[i].Cena = int.Parse(txtIzmeniCenu.Text);

                    MessageBox.Show("Uspesno ste azurirali podatke");
                    cbIzmeniR.Items.Clear();
                    cbDodaj.Items.Clear();
                    cbObrisi.Items.Clear();
                    foreach (Rezervacije rez in rezervacije)
                    {
                        cbIzmeniR.Items.Add(rez);
                        cbDodaj.Items.Add(rez);
                        cbObrisi.Items.Add(rez);
                    }
                        
                    return;
                }
            }
        }

        private void cbIzmeniR_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rezervacije rezervacija = cbIzmeniR.SelectedItem as Rezervacije;
            for(int i = 0; i < cbIzmeniId.Items.Count; i++)
            {
                cbIzmeniId.SelectedIndex = i;
                if (rezervacija.IdProjekat == (int)cbIzmeniId.SelectedItem)
                    break;
            }
            for (int i = 0; i < cbIzmeniIdKupca.Items.Count; i++)
            {
                cbIzmeniIdKupca.SelectedIndex = i;
                if (rezervacija.IdKupac == (int)cbIzmeniIdKupca.SelectedItem)
                    break;
            }
            txtIzmeniMesta.Text = rezervacija.BrojMesta.ToString();
            txtIzmeniCenu.Text = rezervacija.Cena.ToString();
        }

        private void txtDodajMesta_TextChanged(object sender, EventArgs e)
        {
            int broj = 0;
            if(int.TryParse(txtDodajMesta.Text,out broj))
                broj = int.Parse(txtDodajMesta.Text);
            foreach (Projekcija proj in projekcije)
                if (proj.IdProjekcije == (int)cbDodajId.SelectedItem)
                {
                    txtDodajCenu.Text = (proj.Cena * broj).ToString();
                    break;
                }
        }

        private void txtIzmeniMesta_TextChanged(object sender, EventArgs e)
        {
            int broj = 0;
            if (int.TryParse(txtIzmeniMesta.Text, out broj))
                broj = int.Parse(txtIzmeniMesta.Text);
            if (cbIzmeniId.SelectedItem == null)
                return;

            foreach (Projekcija proj in projekcije)
                if (proj.IdProjekcije == int.Parse(cbIzmeniId.SelectedItem.ToString()))
                {
                    txtIzmeniCenu.Text = (proj.Cena * broj).ToString();
                    break;
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
