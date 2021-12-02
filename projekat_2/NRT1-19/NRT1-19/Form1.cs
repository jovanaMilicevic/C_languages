using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NRT1_19
{
    public partial class Form1 : Form
    {
        tvpbazaDataSet ds;
        tvpbazaDataSetTableAdapters.KategorijaTableAdapter kategorije;
        tvpbazaDataSetTableAdapters.ProizvodTableAdapter proizvodi;
        tvpbazaDataSetTableAdapters.RacunTableAdapter racuni;
        tvpbazaDataSetTableAdapters.Statistika_proizvodTableAdapter statistike;

        tvpbazaDataSet.ProizvodDataTable proizvod = new tvpbazaDataSet.ProizvodDataTable();

        string nazivk;
        int idk;
        double ukc = 0;
        //List<Statistika> statistika;
        //string putanja = "dat.bin";
        //DataTable dtk = new DataTable();
        public Form1()
        {
            InitializeComponent();
            ds = new tvpbazaDataSet();
            kategorije = new tvpbazaDataSetTableAdapters.KategorijaTableAdapter();
            proizvodi = new tvpbazaDataSetTableAdapters.ProizvodTableAdapter();
            racuni = new tvpbazaDataSetTableAdapters.RacunTableAdapter();
            statistike = new tvpbazaDataSetTableAdapters.Statistika_proizvodTableAdapter();

            /*if (File.Exists(putanja))
            {
                FileStream fs = File.OpenRead(putanja);
                BinaryFormatter bf = new BinaryFormatter();
                statistika = bf.Deserialize(fs) as List<Statistika>;
                fs.Close();
            }
            else
                statistika = new List<Statistika>();*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kategorije.Fill(ds.Kategorija);
            proizvodi.Fill(ds.Proizvod);
            racuni.Fill(ds.Racun);
            statistike.Fill(ds.Statistika_proizvod);

            dgvKategorije.DataSource = ds.Kategorija;
            dgvProizvodi.DataSource = ds.Proizvod;

            dgvKategorije.ClearSelection();
            dgvKategorije.Columns[1].ReadOnly = true;

        }

        private void dgvKategorije_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKategorije.SelectedCells.Count > 1)
            {
                for (int i = 0; i < dgvKategorije.SelectedCells.Count; i++)
                {
                    dgvKategorije.SelectedCells[i].Selected = false;
                }
                MessageBox.Show("Mozete izabrati samo jednu kategoriju");
                return;
            }

            if (dgvKategorije.SelectedCells.Count > 0)
            {
                int id = dgvKategorije.CurrentRow.Index;
                DataGridViewRow row = dgvKategorije.Rows[id];
                string p = Convert.ToString(row.Cells["naziv"].Value);
                nazivk = p;
                //MessageBox.Show(p);
            }
            else
            {
                MessageBox.Show("Ne postoji nijedna kategorija");
            }

            if (dgvKategorije.SelectedCells.Count > 0)
                idk = dgvKategorije.CurrentCell.RowIndex + 1;
            if (dgvKategorije.SelectedCells.Count > 0)
            {
                var linq = from p in ds.Proizvod
                           where p.IDK == idk
                           orderby p.naziv
                           select p;
                if (linq.Any())
                    dgvProizvodi.DataSource = linq.CopyToDataTable();
                else
                    dgvProizvodi.DataSource = null;

                
            }

        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            int p = 0;
            if(rbNaziv.Checked)
            {
                string txt = txtUpis.Text;
                var linq = from x in ds.Proizvod
                           where x.naziv.ToLower().StartsWith(txt.ToLower())
                           select x;
                if (linq.Any())
                    dgvProizvodi.DataSource = linq.CopyToDataTable();
                else
                    MessageBox.Show("Ne postoji proizvod sa trazenim nazivom");
                if (txtUpis.Text == "")
                    MessageBox.Show("Unesite prvo slovo ili naziv zeljenog proizvoda");
            }
            else if(rbKategorija.Checked)
            {
                string txt = txtUpis.Text;
                var linq = from x in ds.Kategorija join y in ds.Proizvod on x.IDK equals y.IDK
                           where x.naziv.ToLower().StartsWith(txt.ToLower())
                           select y;
                if (linq.Any())
                {
                    dgvProizvodi.DataSource = linq.CopyToDataTable();
                    p = Convert.ToInt32(linq.FirstOrDefault().IDK);
                }
                else
                {
                    dgvProizvodi.DataSource = null;
                    MessageBox.Show("Ne postoji trazena kategorija");
                }

                if (txtUpis.Text == "")
                    MessageBox.Show("Unesite prvo slovo ili naziv kategorije");
            }
            else 
            {
                MessageBox.Show("Niste odabrali po cemu trazite proizvod");
                return;
            }

        }

        private void btnDodajUKorpu_Click(object sender, EventArgs e)
        {
            int index = dgvProizvodi.SelectedCells[0].RowIndex;

            DataGridViewRow selectedRow = dgvProizvodi.Rows[index];

            if(selectedRow.Cells["cena"].Value == null)
            {
                MessageBox.Show("Molimo vas odaberite validan red");
                return;
            }

            string naziv = Convert.ToString(selectedRow.Cells["Naziv"].Value);
            string cena = Convert.ToString(selectedRow.Cells["Cena"].Value);
            int cena2 = int.Parse(cena);
            double kolicina = Convert.ToInt32(Math.Round(nmrBr.Value, 0));
            double iznos = kolicina * cena2;

            int id = int.Parse((dgvProizvodi.CurrentRow.Cells["IDP"].Value).ToString());
            dgvRacun.Rows.Add(new object[] { naziv, kolicina, cena2, iznos, id});

            nmrBr.Value = 1;

            ukc += iznos;
            txtUkupnaCena.Text = ukc.ToString();
        }

        private void btnIzbaci_Click(object sender, EventArgs e)
        {
            if(dgvRacun.Rows.Count < 2)
                MessageBox.Show("Nemate proizvode u korpi");
            else if (dgvRacun.CurrentRow.Cells["iznos"].Value == null )
                MessageBox.Show("Niste selektovali sta zelite da izbacite");
            else
            {
                int n = dgvRacun.SelectedCells[0].RowIndex;
                double c = double.Parse(dgvProizvodi.CurrentRow.Cells["cena"].Value.ToString());
                int k = int.Parse(dgvRacun.CurrentRow.Cells["kolicina"].Value.ToString());
                ukc -= c * k;
                txtUkupnaCena.Text = ukc.ToString();
                dgvRacun.Rows.RemoveAt(n);
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvRacun.Rows.Count < 2)
                MessageBox.Show("Ne postoji racun, ne mozete da ga obrisete");
            dgvRacun.Rows.Clear();
            ukc = 0;
            txtUkupnaCena.Text = ukc.ToString();
        }

        private void btnKupi_Click(object sender, EventArgs e)
        {
            if(ukc == 0)
            {
                MessageBox.Show("Nemate proizvode u korpi");
                return;
            }
            
            tvpbazaDataSet.RacunRow racun = ds.Racun.NewRacunRow();
            racun.ukupna = ukc;
            racun.datum = DateTime.Now;
            ds.Racun.AddRacunRow(racun);
            MessageBox.Show("Uspesno ste izvrsili kupovinu");

            for(int i = 0; i < dgvRacun.Rows.Count-1; i++)
            {
                tvpbazaDataSet.Statistika_proizvodRow stat = ds.Statistika_proizvod.NewStatistika_proizvodRow();
                stat.datum = racun.datum;
                stat.IDP = int.Parse((dgvRacun.Rows[i].Cells["ID"].Value).ToString());
                stat.kolicina = int.Parse((dgvRacun.Rows[i].Cells["kolicina"].Value).ToString());


                ds.Statistika_proizvod.AddStatistika_proizvodRow(stat);

            }

            nmrBr.Value = 1;
            dgvRacun.Rows.Clear();
            txtUkupnaCena.Text = "";
            ukc = 0;

            /* List<Proizvod> proizvods = new List<Proizvod>();



             for(int i = 0; i < dgvRacun.Rows.Count-1; i++)
             {
                 proizvods.Add(new Proizvod(int.Parse((dgvRacun.Rows[i].Cells["ID"].Value).ToString()), int.Parse((dgvRacun.Rows[i].Cells["kolicina"].Value).ToString())));
             }

             bool postojiProizvod;

             for (int i=0;i<statistika.Count;i++)
             {
                 if(racun.datum.Month == statistika[i].Datum.Month)
                 {
                     for(int j=0;j<statistika[i].Proizvodi.Count;j++)
                     {
                         postojiProizvod = false;
                         for (int z = 0; z < proizvods.Count; z++)
                         {
                             if (statistika[i].Proizvodi[j].Id == proizvods[z].Id)
                             {
                                 statistika[i].Proizvodi[j].Kolicina += proizvods[z].Kolicina;
                                 postojiProizvod = true;
                             }
                         }
                         if(postojiProizvod == false)
                         {
                             statistika[i].Proizvodi.Add();
                         }
                     }

                 }
                 else
                 {
                     statistika.Add(new Statistika());
                 }
             }*/
        }

        private void btnDodajProizvod_Click(object sender, EventArgs e)
        {
            statistike.Update(ds.Statistika_proizvod);
            Form form2 = new Form2(ds);
            form2.Show();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            racuni.Update(ds.Racun);
            statistike.Update(ds.Statistika_proizvod);
        }
    }
}
