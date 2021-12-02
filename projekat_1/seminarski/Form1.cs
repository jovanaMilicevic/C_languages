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
    public partial class Form1 : Form
    {
        FileStream fs;
        string putanja;
        List<Film> filmovi;
        string putanjaSale;
        List<Sala> sale;
        string putanjaProjekcija;
        List<Projekcija> projekcije;
        BinaryFormatter bf = new BinaryFormatter();

        Form2 f2;
        public Form1()
        {
            InitializeComponent();
            f2 = new Form2();
            putanja = "Filmovi.txt";
            putanjaSale = "Sale.txt";
            putanjaProjekcija = "Projekcija.txt";

            if (File.Exists(putanja))
            {
                fs = File.OpenRead(putanja);
                filmovi = bf.Deserialize(fs) as List<Film>;
                fs.Close();
            }
            else
            {
                filmovi = new List<Film>();
            }

            if (File.Exists(putanjaSale))
            {
                fs = File.OpenRead(putanjaSale);
                sale = bf.Deserialize(fs) as List<Sala>;
                fs.Close();
            }
            else
            {
                sale = new List<Sala>();
            }

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
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
            f2.Closed += (s, args) => this.Close();
            f2.Show();
            timer1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(!File.Exists(putanja))
            { 
                filmovi.Add(new Film(1,"Anabelle", "Horror", 99, 18));
                filmovi.Add(new Film(2,"Avengers: Endgame", "Action/Sci-fi", 182, 14));
                filmovi.Add(new Film(3,"Avatar", "Sci-fi/Adventure", 162, 12));
                filmovi.Add(new Film(4,"Guardians of the Galaxy", "Action/Sci-fi", 125, 14));
                filmovi.Add(new Film(5,"Titanic", "Romance/Drama", 210, 12));
            }

            if (!File.Exists(putanjaSale))
            { 
                sale.Add(new Sala(1,1, 255));
                sale.Add(new Sala(2,2, 167));
                sale.Add(new Sala(3,3, 305));
                sale.Add(new Sala(4,4, 204));
            }

            if (!File.Exists(putanjaProjekcija))
            {
                projekcije.Add(new Projekcija(1,new DateTime(2021,4,30),new Sala(5,1,255),250,"deset",new Film(1, "Anabelle", "Horror", 99, 18)));
                projekcije.Add(new Projekcija(2,new DateTime(2021, 4, 29), new Sala(6,2, 167), 250, "deset", new Film(2, "Avengers: Endgame", "Action/Sci-fi", 182, 14)));
                projekcije.Add(new Projekcija(3,new DateTime(2021, 4, 30), new Sala(7,2, 167), 270, "deset", new Film(3, "Avatar", "Sci-fi/Adventure", 162, 12)));
                projekcije.Add(new Projekcija(4,new DateTime(2021, 4, 30), new Sala(8,3, 305), 250, "dvanaest", new Film(5, "Titanic", "Romance/Drama", 210, 12)));
            }

            BinaryFormatter bf = new BinaryFormatter();

            //film
            fs = File.OpenWrite(putanja);
            bf.Serialize(fs, filmovi);
            fs.Close();

            fs = File.OpenRead(putanja);
            filmovi = bf.Deserialize(fs) as List<Film>;
            fs.Close();

            //sale
            fs = File.OpenWrite(putanjaSale);
            bf.Serialize(fs, sale);
            fs.Close();

            fs = File.OpenRead(putanjaSale);
            sale = bf.Deserialize(fs) as List<Sala>;
            fs.Close();

            //projekcije
            fs = File.OpenWrite(putanjaProjekcija);
            bf.Serialize(fs, projekcije);
            fs.Close();

            fs = File.OpenRead(putanjaProjekcija);
            projekcije = bf.Deserialize(fs) as List<Projekcija>;
            fs.Close();


            //filmovi
            if (File.Exists(putanja))
            {
                fs = File.OpenRead(putanja);
                BinaryFormatter bf2 = new BinaryFormatter();
                filmovi = bf2.Deserialize(fs) as List<Film>;
                fs.Close();
            }

            //sale
            if (File.Exists(putanjaSale))
            {
                fs = File.OpenRead(putanjaSale);
                BinaryFormatter bf3 = new BinaryFormatter();
                sale = bf3.Deserialize(fs) as List<Sala>;
                fs.Close();
            }

            //projekcije
            if (File.Exists(putanjaProjekcija))
            {
                fs = File.OpenRead(putanjaSale);
                BinaryFormatter bf4 = new BinaryFormatter();
                projekcije = bf4.Deserialize(fs) as List<Projekcija>;
                fs.Close();
            }

        }   
    }
}
