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
    public partial class Form3 : Form
    {
        FileStream fs;
        string putanja = "Registracija.txt";
        string putanjaFilm = "Filmovi.txt";
        string putanjaRezervacije = "Rezervacije.txt";

        List<Kupac> kupci;
        List<Film> filmovi;
        List<Rezervacije> rezervacije;
        public Form3()
        {
            InitializeComponent();

            fs = File.OpenRead(putanja);
            BinaryFormatter bf = new BinaryFormatter();
            kupci = bf.Deserialize(fs) as List<Kupac>;
            fs.Close();

            fs = File.OpenRead(putanjaFilm);
            BinaryFormatter bf2 = new BinaryFormatter();
            filmovi = bf2.Deserialize(fs) as List<Film>;
            fs.Close();

            fs = File.OpenRead(putanjaRezervacije);
            BinaryFormatter bf3 = new BinaryFormatter();
            rezervacije = bf3.Deserialize(fs) as List<Rezervacije>;
            fs.Close();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            cbKupac.DataSource = kupci;
        }

        private void cbDomen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDomen.SelectedItem.ToString() == "Film")
            {
                Form6 f6 = new Form6();
                f6.Show();
            }
            else if(cbDomen.SelectedItem.ToString() == "Projekcija")
            {
                Form7 f7 = new Form7();
                f7.Show();
            }
            else if (cbDomen.SelectedItem.ToString() == "Sala")
            {
                Form8 f8 = new Form8();
                f8.Show();
            }
            else if (cbDomen.SelectedItem.ToString() == "Rezervacija")
            {
                Form9 f9 = new Form9();
                f9.Show();
            }
            else if (cbDomen.SelectedItem.ToString() == "Korisnik")
            {
                Form10 f10 = new Form10();
                f10.Show();
            }
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

        private void cbKupac_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbKupac.Items.Clear();
            Kupac kupac = cbKupac.SelectedItem as Kupac;
            foreach(Rezervacije r in rezervacije)
            {
                if(r.IdKupac == kupac.IdKupca)
                {
                    lbKupac.Items.Add(r);
                }
            }
        }
    }
}
