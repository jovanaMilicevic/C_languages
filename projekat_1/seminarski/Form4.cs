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

//delimiter!!!!!!!!! 
namespace seminarski
{
    public partial class Form4 : Form
    {
        public delegate void lista(ListBox.ObjectCollection list);
        lista promeni;

        int idKor;
        FileStream fs;
        string putanja = "Rezervacije.txt";
        string putanjaProjekcije = "Projekcija.txt";

        List<Rezervacije> rezervacije;
        List<Projekcija> projekcije;

        BinaryFormatter bf = new BinaryFormatter();
        public Form4(int idKorisnika)
        {
            InitializeComponent();
            idKor = idKorisnika;

            
            if (File.Exists(putanja))
            {
                fs = File.OpenRead(putanja);
                if(fs.Length>0)
                    rezervacije = bf.Deserialize(fs) as List<Rezervacije>;
                fs.Close();
            }
            else
                rezervacije = new List<Rezervacije>();

            if (File.Exists(putanjaProjekcije))
            {
                fs = File.OpenRead(putanjaProjekcije);
                if (fs.Length > 0)
                    projekcije = bf.Deserialize(fs) as List<Projekcija>;
                fs.Close();
            }
            else
                projekcije = new List<Projekcija>();


        }

        private void btnRezervisi_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f5 = new Form5(idKor);
            f5.Closed += (s, args) => this.Close();
            f5.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

            for(int i=0; i<rezervacije.Count;i++)
            {
                if (idKor == rezervacije[i].IdKupac)
                    lbFilmovi.Items.Add(rezervacije[i]);
            }

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            
            if (lbFilmovi.SelectedItem == null)
            {
                MessageBox.Show("Izberite rezervaciju koju zelite da obrisete");
                return;
            }

            for (int i = 0; i < rezervacije.Count; i++)
            {

                if (lbFilmovi.SelectedItem as Rezervacije == rezervacije[i])
                {
                    for (int j = 0; j < projekcije.Count; j++)
                    {
                        if (projekcije[j].IdProjekcije == rezervacije[i].IdProjekat)
                        {
                            projekcije[j].SlobodnaMesta += rezervacije[i].BrojMesta;
                        }
                    }

                    fs = File.OpenWrite(putanjaProjekcije);
                    bf.Serialize(fs, projekcije);
                    fs.Close();

                    fs = File.OpenWrite(putanja);
                    bf.Serialize(fs, rezervacije);
                    fs.Close();


                    rezervacije.RemoveAt(i);
                lbFilmovi.Items.Clear();
                foreach (Rezervacije r in rezervacije)
                    lbFilmovi.Items.Add(r);

                

                fs = File.OpenWrite(putanja);
                bf.Serialize(fs, rezervacije);
                fs.Close();

                MessageBox.Show("Uspesno ste obrisali rezervaciju");
                return;
                }
              
            }
                
        }

        private void btnAzuriraj_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 f11 = new Form11(idKor);
            promeni = new lista(f11.popuniLb);
            promeni(lbFilmovi.Items);
            f11.Closed += (s, args) => this.Close();
            f11.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var f2 = new Form2();
            f2.Closed += (s, args) => this.Close();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
