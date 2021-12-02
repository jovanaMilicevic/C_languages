namespace NRT1_19
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvKategorije = new System.Windows.Forms.DataGridView();
            this.dgvProizvodi = new System.Windows.Forms.DataGridView();
            this.txtUpis = new System.Windows.Forms.TextBox();
            this.rbNaziv = new System.Windows.Forms.RadioButton();
            this.rbKategorija = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.nmrBr = new System.Windows.Forms.NumericUpDown();
            this.btnDodajUKorpu = new System.Windows.Forms.Button();
            this.btnKupi = new System.Windows.Forms.Button();
            this.dgvRacun = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIzbaci = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.txtUkupnaCena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDodajProizvod = new System.Windows.Forms.Button();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategorije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrBr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacun)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKategorije
            // 
            this.dgvKategorije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKategorije.Location = new System.Drawing.Point(12, 12);
            this.dgvKategorije.MultiSelect = false;
            this.dgvKategorije.Name = "dgvKategorije";
            this.dgvKategorije.Size = new System.Drawing.Size(382, 150);
            this.dgvKategorije.TabIndex = 0;
            this.dgvKategorije.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKategorije_CellClick);
            // 
            // dgvProizvodi
            // 
            this.dgvProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodi.Location = new System.Drawing.Point(423, 13);
            this.dgvProizvodi.Name = "dgvProizvodi";
            this.dgvProizvodi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProizvodi.Size = new System.Drawing.Size(483, 150);
            this.dgvProizvodi.TabIndex = 1;
            // 
            // txtUpis
            // 
            this.txtUpis.Location = new System.Drawing.Point(15, 242);
            this.txtUpis.Name = "txtUpis";
            this.txtUpis.Size = new System.Drawing.Size(284, 20);
            this.txtUpis.TabIndex = 2;
            // 
            // rbNaziv
            // 
            this.rbNaziv.AutoSize = true;
            this.rbNaziv.Location = new System.Drawing.Point(16, 219);
            this.rbNaziv.Name = "rbNaziv";
            this.rbNaziv.Size = new System.Drawing.Size(52, 17);
            this.rbNaziv.TabIndex = 3;
            this.rbNaziv.TabStop = true;
            this.rbNaziv.Text = "Naziv";
            this.rbNaziv.UseVisualStyleBackColor = true;
            // 
            // rbKategorija
            // 
            this.rbKategorija.AutoSize = true;
            this.rbKategorija.Location = new System.Drawing.Point(227, 219);
            this.rbKategorija.Name = "rbKategorija";
            this.rbKategorija.Size = new System.Drawing.Size(72, 17);
            this.rbKategorija.TabIndex = 4;
            this.rbKategorija.TabStop = true;
            this.rbKategorija.Text = "Kategorija";
            this.rbKategorija.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pretrazite proizvode po:";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPretrazi.Location = new System.Drawing.Point(17, 278);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(283, 37);
            this.btnPretrazi.TabIndex = 6;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // nmrBr
            // 
            this.nmrBr.Location = new System.Drawing.Point(543, 169);
            this.nmrBr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrBr.Name = "nmrBr";
            this.nmrBr.Size = new System.Drawing.Size(120, 20);
            this.nmrBr.TabIndex = 7;
            this.nmrBr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnDodajUKorpu
            // 
            this.btnDodajUKorpu.Location = new System.Drawing.Point(715, 169);
            this.btnDodajUKorpu.Name = "btnDodajUKorpu";
            this.btnDodajUKorpu.Size = new System.Drawing.Size(120, 23);
            this.btnDodajUKorpu.TabIndex = 8;
            this.btnDodajUKorpu.Text = "Dodaj u korpu";
            this.btnDodajUKorpu.UseVisualStyleBackColor = true;
            this.btnDodajUKorpu.Click += new System.EventHandler(this.btnDodajUKorpu_Click);
            // 
            // btnKupi
            // 
            this.btnKupi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKupi.Location = new System.Drawing.Point(423, 443);
            this.btnKupi.Name = "btnKupi";
            this.btnKupi.Size = new System.Drawing.Size(483, 30);
            this.btnKupi.TabIndex = 9;
            this.btnKupi.Text = "Kupi";
            this.btnKupi.UseVisualStyleBackColor = true;
            this.btnKupi.Click += new System.EventHandler(this.btnKupi_Click);
            // 
            // dgvRacun
            // 
            this.dgvRacun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacun.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Naziv,
            this.Kolicina,
            this.Cena,
            this.Iznos,
            this.ID});
            this.dgvRacun.Location = new System.Drawing.Point(422, 231);
            this.dgvRacun.Name = "dgvRacun";
            this.dgvRacun.ReadOnly = true;
            this.dgvRacun.Size = new System.Drawing.Size(483, 150);
            this.dgvRacun.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(616, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Vasa korpa:";
            // 
            // btnIzbaci
            // 
            this.btnIzbaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbaci.Location = new System.Drawing.Point(422, 493);
            this.btnIzbaci.Name = "btnIzbaci";
            this.btnIzbaci.Size = new System.Drawing.Size(237, 58);
            this.btnIzbaci.TabIndex = 12;
            this.btnIzbaci.Text = "Izbaci iz korpe";
            this.btnIzbaci.UseVisualStyleBackColor = true;
            this.btnIzbaci.Click += new System.EventHandler(this.btnIzbaci_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.Location = new System.Drawing.Point(668, 493);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(237, 58);
            this.btnObrisi.TabIndex = 13;
            this.btnObrisi.Text = "Obrisi ceo racun";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // txtUkupnaCena
            // 
            this.txtUkupnaCena.Location = new System.Drawing.Point(627, 402);
            this.txtUkupnaCena.Name = "txtUkupnaCena";
            this.txtUkupnaCena.ReadOnly = true;
            this.txtUkupnaCena.Size = new System.Drawing.Size(249, 20);
            this.txtUkupnaCena.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(513, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ukupna cena:";
            // 
            // btnDodajProizvod
            // 
            this.btnDodajProizvod.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajProizvod.Location = new System.Drawing.Point(17, 468);
            this.btnDodajProizvod.Name = "btnDodajProizvod";
            this.btnDodajProizvod.Size = new System.Drawing.Size(283, 74);
            this.btnDodajProizvod.TabIndex = 17;
            this.btnDodajProizvod.Text = "Dodaj proizvod";
            this.btnDodajProizvod.UseVisualStyleBackColor = true;
            this.btnDodajProizvod.Click += new System.EventHandler(this.btnDodajProizvod_Click);
            // 
            // Naziv
            // 
            this.Naziv.HeaderText = "naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Kolicina
            // 
            this.Kolicina.HeaderText = "kolicina";
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.ReadOnly = true;
            // 
            // Cena
            // 
            this.Cena.HeaderText = "cena";
            this.Cena.Name = "Cena";
            this.Cena.ReadOnly = true;
            // 
            // Iznos
            // 
            this.Iznos.HeaderText = "iznos";
            this.Iznos.Name = "Iznos";
            this.Iznos.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 564);
            this.Controls.Add(this.btnDodajProizvod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUkupnaCena);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnIzbaci);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvRacun);
            this.Controls.Add(this.btnKupi);
            this.Controls.Add(this.btnDodajUKorpu);
            this.Controls.Add(this.nmrBr);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbKategorija);
            this.Controls.Add(this.rbNaziv);
            this.Controls.Add(this.txtUpis);
            this.Controls.Add(this.dgvProizvodi);
            this.Controls.Add(this.dgvKategorije);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKategorije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrBr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKategorije;
        private System.Windows.Forms.DataGridView dgvProizvodi;
        private System.Windows.Forms.TextBox txtUpis;
        private System.Windows.Forms.RadioButton rbNaziv;
        private System.Windows.Forms.RadioButton rbKategorija;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.NumericUpDown nmrBr;
        private System.Windows.Forms.Button btnDodajUKorpu;
        private System.Windows.Forms.Button btnKupi;
        private System.Windows.Forms.DataGridView dgvRacun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnIzbaci;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.TextBox txtUkupnaCena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDodajProizvod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iznos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}

