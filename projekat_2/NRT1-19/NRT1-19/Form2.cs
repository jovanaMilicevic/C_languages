using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NRT1_19
{
    public partial class Form2 : Form
    {
        tvpbazaDataSet ds = new tvpbazaDataSet();

        tvpbazaDataSetTableAdapters.Statistika_proizvodTableAdapter satistike = new tvpbazaDataSetTableAdapters.Statistika_proizvodTableAdapter();
        tvpbazaDataSetTableAdapters.ProizvodTableAdapter proizvodi = new tvpbazaDataSetTableAdapters.ProizvodTableAdapter();
        tvpbazaDataSetTableAdapters.RacunTableAdapter racuni = new tvpbazaDataSetTableAdapters.RacunTableAdapter();

        List<Stats> stats = new List<Stats>();

        public Form2()
        {
            InitializeComponent();
            proizvodi.Fill(ds.Proizvod);
        }
        public Form2(tvpbazaDataSet ds) : this()
        {
            this.ds = ds;
            proizvodi.Fill(ds.Proizvod);
            racuni.Fill(ds.Racun);
            satistike.Fill(ds.Statistika_proizvod);
        }
        private void proizvodBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cbKategorija.DisplayMember = "naziv";
            cbKategorija.DataSource = ds.Kategorija;

        }

        private void proizvodBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            tvpbazaDataSet.ProizvodRow red = ds.Proizvod.NewProizvodRow();
            if (nazivTextBox.Text.Trim().Length != 0 && cenaTextBox.Text.Trim().Length != 0)
            {
                int b;
                
                if (nazivTextBox.Text.Trim().Length != 0)
                {
                    char[] tekst = nazivTextBox.Text.ToCharArray();
                    foreach (char c in tekst)
                    {
                        if (char.IsDigit(c))
                        {
                            MessageBox.Show("Naziv moze da sadrzi samo slova");
                            return;
                        }
                    }
                }
                if(!int.TryParse(cenaTextBox.Text, out b))
                {
                    MessageBox.Show("Cena mora da bude broj");
                    return;
                }
                red.IDK = cbKategorija.SelectedIndex + 1;
                red.naziv = nazivTextBox.Text;
                red.cena = int.Parse(cenaTextBox.Text);
                ds.Proizvod.AddProizvodRow(red);
                MessageBox.Show("Uspesno ste dodali proizvod u bazu");

                nazivTextBox.Text = "";
                cenaTextBox.Text = "";
            }
            else if (cenaTextBox.Text.Trim().Length == 0 || nazivTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Niste uneli potrebne stavke");
                return;
            }
            

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            proizvodi.Update(ds.Proizvod);
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            if (dtKrajnji.Value < dtPocetni.Value)
            {
                MessageBox.Show("Krajnji datum mora biti posle pocetnog...");
                return;
            }
            var linq = from x in ds.Racun
                       where x.datum >= dtPocetni.Value && x.datum <= dtKrajnji.Value
                       select x;
            if (linq.Any())
                dgvPoDatumu.DataSource = linq.CopyToDataTable();
            else
            {
                dgvPoDatumu.DataSource = null;
                MessageBox.Show("Ne postoji racun u tom periodu");
            }
        }

        private Brush vratiCetkicu()
        {
            PropertyInfo[] nizCetkicaInfo = typeof(Brushes).GetProperties();
            Brush[] nizCetkica = new Brush[nizCetkicaInfo.Length];
            for(int i = 0; i < nizCetkicaInfo.Length; i++)
            {
                nizCetkica[i] = (Brush)nizCetkicaInfo[i].GetValue(null, null);
            }
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            return nizCetkica[rnd.Next(1, nizCetkica.Length)];
        }


        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(Pens.Black, new Rectangle(350, 390, 250, 250));
        }
        private void btnPrikaz_Click(object sender, EventArgs e)
        {
            //lbPrikaz.Items.Clear();
            double ukupno = 0;

            stats = new List<Stats>();
            DateTime dat = dtMesec.Value;

            var linq = from s in ds.Statistika_proizvod
                       where s.datum.Month == dat.Month
                       select s;
            if(linq.Count() == 0)
            {
                lbPrikaz.DataSource = null;
                this.Refresh();
                MessageBox.Show("Ne postoje proizvodi koji su prodati tog meseca");
                return;
            }
            foreach (var row in linq)
                ukupno += row.kolicina;

            foreach (var row in linq)
            {
                int kolicina = 0;
                var naziv = from p in ds.Proizvod
                            where p.IDP == row.IDP
                            select p.naziv;

                foreach (var red in ds.Statistika_proizvod)
                {
                    if (red.IDP == row.IDP && red.datum.Month == dat.Month)
                        kolicina += red.kolicina;
                }
                bool postoji = false;

                var id = from s in ds.Statistika_proizvod
                         where s.IDP == row.IDP
                         select s.IDP;

                foreach (Stats st in stats)
                {
                    if (st.Id == id.First())
                    {
                        postoji = true;
                    }
                }
                if (postoji == false)
                    stats.Add(new Stats(naziv.First(), kolicina, Math.Round((kolicina/ukupno)*100, 2) , id.First()));
            }
            lbPrikaz.DataSource = stats;
            this.Paint += Nacrtaj;

            this.Refresh();
        }

        private void Nacrtaj(object sender, PaintEventArgs e)
        {
            float pocetniUgao = 0;
            for(int i = 0; i < stats.Count; i++)
            {
                e.Graphics.FillPie(vratiCetkicu(), new Rectangle(350, 390, 250, 250),pocetniUgao, (float)(stats[i].Procenat/100)*360);
                pocetniUgao += (float)(stats[i].Procenat / 100) * 360;
            }
            
        }
    }
    }

