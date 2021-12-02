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
    public partial class Form8 : Form
    {
        FileStream fs;
        string putanja = "Sale.txt";

        List<Sala> sale;
        BinaryFormatter bf = new BinaryFormatter();

        public Form8()
        {
            InitializeComponent();

            if (File.Exists(putanja))
            {
                fs = File.OpenRead(putanja);
                sale = bf.Deserialize(fs) as List<Sala>;
                fs.Close();

            }
            else
            {
                sale = new List<Sala>();
            }

            foreach(Sala s in sale)
            {
                cbIzmeni.Items.Add(s);
                cbDodaj.Items.Add(s);
                cbObrisi.Items.Add(s);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            int brSale;
            int brSedista;

            if(txtDodajBrSale.Text.Trim().Length == 0 || txtDodajBrSedista.Text.Trim().Length == 0)
            {
                MessageBox.Show("Niste uneli sve potrebne informacije");
                return;
            }
            else if(!int.TryParse(txtDodajBrSale.Text, out brSale) || !int.TryParse(txtDodajBrSedista.Text, out brSedista))
            {
                MessageBox.Show("Niste uneli broj za broj sale ili za broj sedista");
                return;
            }
            sale.Add(new Sala(sale.Count+1,brSale, brSedista));

            fs = File.OpenWrite(putanja);
            bf.Serialize(fs, sale);

            fs.Close();

            MessageBox.Show("Uspesno ste dodali salu");

            cbIzmeni.Items.Clear();
            cbDodaj.Items.Clear();
            cbObrisi.Items.Clear();
            foreach (Sala sl in sale)
            {
                cbIzmeni.Items.Add(sl);
                cbDodaj.Items.Add(sl);
                cbObrisi.Items.Add(sl);
            }

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (cbObrisi.SelectedItem == null)
            {
                MessageBox.Show("Niste izabrali salu za brisanje");
                return;
            }

            for (int i = 0; i < sale.Count; i++)
            {
                if (cbObrisi.SelectedItem as Sala == sale[i])
                {
                    sale.RemoveAt(i);
                    MessageBox.Show("Sala je uspesno obrisana");

                    fs = File.OpenWrite(putanja);
                    bf.Serialize(fs, sale);

                    fs.Close();

                    cbIzmeni.Items.Clear();
                    cbDodaj.Items.Clear();
                    cbObrisi.Items.Clear();
                    foreach (Sala s in sale)
                    {
                        cbIzmeni.Items.Add(s);
                        cbDodaj.Items.Add(s);
                        cbObrisi.Items.Add(s);
                    }
                    return;
                }
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            int brSale;
            int brSedista;
            if (cbIzmeni.SelectedItem == null)
            {
                MessageBox.Show("Niste izabrali salu");
                return;
            }
            else if (txtIzmeniBrSale.Text.Trim().Length == 0 || txtIzmeniBrSedista.Text.Trim().Length == 0)
            {
                MessageBox.Show("Niste uneli sve potrebne informacije");
                return;
            }
            else if (!int.TryParse(txtIzmeniBrSale.Text, out brSale) || !int.TryParse(txtIzmeniBrSedista.Text, out brSedista))
            {
                MessageBox.Show("Niste uneli broj za broj sale ili sedista");
                return;
            }
            for (int i = 0; i < sale.Count; i++)
            {
                if (cbIzmeni.SelectedItem as Sala == sale[i])
                {
                    sale[i].BrSale = brSale;
                    sale[i].BrSedista = brSedista;

                    MessageBox.Show("Uspesno ste azurirali podatke");

                    cbIzmeni.Items.Clear();
                    cbDodaj.Items.Clear();
                    cbObrisi.Items.Clear();
                    foreach (Sala sala in sale)
                    {
                        cbIzmeni.Items.Add(sala);
                        cbDodaj.Items.Add(sala);
                        cbObrisi.Items.Add(sala);
                    }
                    return;
                }
            }
        }

        private void cbIzmeni_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sala sala = cbIzmeni.SelectedItem as Sala;
            txtIzmeniBrSale.Text = sala.BrSale.ToString();
            txtIzmeniBrSedista.Text = sala.BrSedista.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
