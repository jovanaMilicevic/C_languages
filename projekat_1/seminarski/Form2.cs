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
    public partial class Form2 : Form
    {
        FileStream fs;
        
        List<Kupac> kupci;
        string putanja;
        Administrator admin;

        public delegate void podaci(string podatak);
        public podaci pd;

        public Form2()
        {
            InitializeComponent();
            putanja = "Registracija.txt";

            admin = new Administrator();
            if(File.Exists(putanja))
            {
                fs = File.OpenRead(putanja);
                BinaryFormatter bf = new BinaryFormatter();
                kupci = bf.Deserialize(fs) as List<Kupac>;
                fs.Close();
            }
            else
                kupci = new List<Kupac>();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if(txtKorIme.Text.Trim().Length == 0 && txtIme.Text.Trim().Length == 0 && txtPrezime.Text.Trim().Length == 0 && txtPassword.Text.Trim().Length == 0 && txtTelefon.Text.Trim().Length == 0)
            {
                MessageBox.Show("Niste uneli vase podatke");
                return;
            }
            else if(txtKorIme.Text.Trim().Length == 0)
            {
                MessageBox.Show("Niste uneli vase korisnicko ime");
                return;
            }
            else if (txtIme.Text.Trim().Length == 0)
            {
                MessageBox.Show("Niste uneli vase ime");
                return;
            }
            else if (txtPrezime.Text.Trim().Length == 0)
            {
                MessageBox.Show("Niste uneli vase prezime");
                return;
            }
            else if (txtPassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("Niste uneli vasu lozinku");
                return;
            }
            else if (txtTelefon.Text.Trim().Length == 0)
            {
                MessageBox.Show("Niste uneli vas broj telefona");
                return;
            }
            else if(txtTelefon.Text.Trim().Length != 0)
            {
                char[] c = txtTelefon.Text.ToCharArray();
                foreach(char ch in c)
                {
                    if(char.IsLetter(ch))
                    {
                        MessageBox.Show("Uneli ste karakter");
                    }
                }
                return;
            }
            else if(rbMuski.Checked == false && rbZenski.Checked == false)
            {
                MessageBox.Show("Niste odabrali vas pol");
                return;
            }


            string pol = "";
            if(rbZenski.Checked == true)
            {
                pol = "Zenski";
            }
            else if(rbMuski.Checked == true)
            {
                pol = "Muski";
            }

            BinaryFormatter bf = new BinaryFormatter();
            fs = File.OpenRead(putanja);
            kupci = bf.Deserialize(fs) as List<Kupac>;
            fs.Close();

            foreach (Kupac k in kupci)
                if (k.KorIme == txtKorIme.Text)
                {
                    MessageBox.Show("Korisnik je vec registrovan");
                    return;
                }
                else
                {
                    MessageBox.Show("Uspesno ste se registrovali.");
                }

            Kupac kupac = new Kupac(kupci.Count+1,txtKorIme.Text.Trim(), txtPassword.Text.Trim(), txtIme.Text.Trim(), txtPrezime.Text.Trim(), dtDate.Value, txtTelefon.Text.Trim(), pol );
            kupci.Add(kupac);

            MessageBox.Show("Dobro dosli");


        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if(txtKorIme2.Text.Trim().Length == 0 && txtPass2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Niste uneli vase podatke");
                return;
            }
            else if(txtKorIme2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Niste uneli vase korisnicko ime");
                return;
            }
            else if(txtPass2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Niste uneli vasu lozinku");
                return;
            }
            else
            {
                BinaryFormatter bf = new BinaryFormatter();

                fs = File.OpenWrite(putanja);
                bf.Serialize(fs,kupci);
                fs.Close();

                fs = File.OpenRead(putanja);
                kupci = bf.Deserialize(fs) as List<Kupac>;
                fs.Close();

                foreach(Kupac k in kupci)
                {
                   if(txtKorIme2.Text.Trim() == k.KorIme && txtPass2.Text.Trim() == k.Sifra)
                    {
                        MessageBox.Show("Dobrodosli");

                        this.Hide();
                        var f4 = new Form4(k.IdKupca);
                        f4.Closed += (s, args) => this.Close();
                        f4.Show();
                        return;
                    }
                }

                
                if(txtKorIme2.Text.Trim() == admin.KorIme && txtPass2.Text.Trim() == admin.Sifra)
                {
                    MessageBox.Show("Dobrodosli admine");

                    this.Hide();
                    var f3 = new Form3();
                    f3.Closed += (s, args) => this.Close();
                    f3.Show();
                    return;
                }
                MessageBox.Show("Korisnik ne postoji...");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
