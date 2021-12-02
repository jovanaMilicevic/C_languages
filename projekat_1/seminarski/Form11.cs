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
    public partial class Form11 : Form
    {
        int idKor;
        FileStream fs;
        string putanja = "Rezervacije.txt";
        string putanjaProjekcije = "Projekcija.txt";

        List<Rezervacije> rezervacije;
        List<Projekcija> projekcije;

        BinaryFormatter bf = new BinaryFormatter();
        public Form11(int idKorisnika)
        {
            InitializeComponent();
            idKor = idKorisnika;
            
            rezervacije = new List<Rezervacije>();
            if (File.Exists(putanja))
            {
                fs = File.OpenRead(putanja);
                if (fs.Length > 0)
                    rezervacije = bf.Deserialize(fs) as List<Rezervacije>;
                fs.Close();
            }

            projekcije = new List<Projekcija>();
            if (File.Exists(putanjaProjekcije))
            {
                fs = File.OpenRead(putanjaProjekcije);
                if (fs.Length > 0)
                    projekcije = bf.Deserialize(fs) as List<Projekcija>;
                fs.Close();
            }
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            if(lbFilmovi.SelectedItem == null)
            {
                MessageBox.Show("Niste odabrali rezervaciju...");
                return;
            }

            for(int i = 0; i < rezervacije.Count; i++)
            {
                rezervacije[i].BrojMesta = int.Parse(numMesta.Value.ToString());
                rezervacije[i].Cena = int.Parse(txtCena.Text);

                fs = File.OpenWrite(putanja);
                bf.Serialize(fs, rezervacije);
                fs.Close();

                MessageBox.Show("Uspesno ste azurirali listu");
                return;
            }
        }

        private void dodaj(object sender, EventArgs e)
        {
            if (lbFilmovi.SelectedItem != null)
                txtCena.Text = ((int)numMesta.Value * ((Rezervacije)lbFilmovi.SelectedItem).Cena).ToString();
            else 
            {
                MessageBox.Show("Niste izabrali projekciju");
                numMesta.Value = 1;
                return;
            }
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f4 = new Form4(idKor);
            f4.Closed += (s, args) => this.Close();
            f4.Show();
        }

        private void lbFilmovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            numMesta.Value = (lbFilmovi.SelectedItem as Rezervacije).BrojMesta;
        }

        public void popuniLb(ListBox.ObjectCollection lista)
        { 
            foreach(Object o in lista)
            {
                if(idKor == (o as Rezervacije).IdKupac)
                    lbFilmovi.Items.Add(o);
            }
        }
    }
}
