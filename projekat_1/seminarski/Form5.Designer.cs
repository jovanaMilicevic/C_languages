namespace seminarski
{
    partial class Form5
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
            this.dtPocetni = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtKrajnji = new System.Windows.Forms.DateTimePicker();
            this.cmbSala = new System.Windows.Forms.ComboBox();
            this.cmbNaziv = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ptnPrikazi = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbRepertoar = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRezervisi = new System.Windows.Forms.Button();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtPocetni
            // 
            this.dtPocetni.CalendarMonthBackground = System.Drawing.Color.SkyBlue;
            this.dtPocetni.Location = new System.Drawing.Point(19, 50);
            this.dtPocetni.MinDate = new System.DateTime(2021, 4, 23, 0, 0, 0, 0);
            this.dtPocetni.Name = "dtPocetni";
            this.dtPocetni.Size = new System.Drawing.Size(200, 20);
            this.dtPocetni.TabIndex = 3;
            this.dtPocetni.Value = new System.DateTime(2021, 4, 23, 17, 39, 28, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rezervacija projekcija";
            // 
            // dtKrajnji
            // 
            this.dtKrajnji.CalendarMonthBackground = System.Drawing.Color.SkyBlue;
            this.dtKrajnji.Location = new System.Drawing.Point(253, 50);
            this.dtKrajnji.MinDate = new System.DateTime(2021, 4, 23, 0, 0, 0, 0);
            this.dtKrajnji.Name = "dtKrajnji";
            this.dtKrajnji.Size = new System.Drawing.Size(200, 20);
            this.dtKrajnji.TabIndex = 2;
            // 
            // cmbSala
            // 
            this.cmbSala.BackColor = System.Drawing.Color.SkyBlue;
            this.cmbSala.FormattingEnabled = true;
            this.cmbSala.Location = new System.Drawing.Point(482, 50);
            this.cmbSala.Name = "cmbSala";
            this.cmbSala.Size = new System.Drawing.Size(121, 21);
            this.cmbSala.TabIndex = 3;
            // 
            // cmbNaziv
            // 
            this.cmbNaziv.BackColor = System.Drawing.Color.SkyBlue;
            this.cmbNaziv.FormattingEnabled = true;
            this.cmbNaziv.Location = new System.Drawing.Point(637, 50);
            this.cmbNaziv.Name = "cmbNaziv";
            this.cmbNaziv.Size = new System.Drawing.Size(121, 21);
            this.cmbNaziv.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbNaziv);
            this.panel1.Controls.Add(this.dtPocetni);
            this.panel1.Controls.Add(this.cmbSala);
            this.panel1.Controls.Add(this.dtKrajnji);
            this.panel1.Location = new System.Drawing.Point(12, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 96);
            this.panel1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(645, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Naziv:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(490, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sala:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(262, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Krajnji datum:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pocetni datum:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "FILTERI:";
            // 
            // ptnPrikazi
            // 
            this.ptnPrikazi.BackColor = System.Drawing.Color.Aqua;
            this.ptnPrikazi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ptnPrikazi.Font = new System.Drawing.Font("Old English Text MT", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptnPrikazi.Location = new System.Drawing.Point(12, 198);
            this.ptnPrikazi.Name = "ptnPrikazi";
            this.ptnPrikazi.Size = new System.Drawing.Size(776, 43);
            this.ptnPrikazi.TabIndex = 7;
            this.ptnPrikazi.Text = "Prikazi dostupne projekcije";
            this.ptnPrikazi.UseVisualStyleBackColor = false;
            this.ptnPrikazi.Click += new System.EventHandler(this.ptnPrikazi_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(299, 26);
            this.label7.TabIndex = 8;
            this.label7.Text = "REPERTOAR BIOSKOPA:";
            // 
            // lbRepertoar
            // 
            this.lbRepertoar.BackColor = System.Drawing.Color.SkyBlue;
            this.lbRepertoar.FormattingEnabled = true;
            this.lbRepertoar.Location = new System.Drawing.Point(12, 293);
            this.lbRepertoar.Name = "lbRepertoar";
            this.lbRepertoar.Size = new System.Drawing.Size(776, 173);
            this.lbRepertoar.TabIndex = 9;
            this.lbRepertoar.SelectedIndexChanged += new System.EventHandler(this.lbRepertoar_SelectedIndexChanged);
            this.lbRepertoar.SelectedValueChanged += new System.EventHandler(this.dodaj);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 488);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Broj mesta:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(193, 488);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Ukupna cena:";
            // 
            // btnRezervisi
            // 
            this.btnRezervisi.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnRezervisi.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRezervisi.Location = new System.Drawing.Point(455, 489);
            this.btnRezervisi.Name = "btnRezervisi";
            this.btnRezervisi.Size = new System.Drawing.Size(333, 61);
            this.btnRezervisi.TabIndex = 12;
            this.btnRezervisi.Text = "Rezervisi";
            this.btnRezervisi.UseVisualStyleBackColor = false;
            this.btnRezervisi.Click += new System.EventHandler(this.btnRezervisi_Click);
            // 
            // txtCena
            // 
            this.txtCena.BackColor = System.Drawing.Color.SkyBlue;
            this.txtCena.Location = new System.Drawing.Point(197, 516);
            this.txtCena.Name = "txtCena";
            this.txtCena.ReadOnly = true;
            this.txtCena.Size = new System.Drawing.Size(154, 20);
            this.txtCena.TabIndex = 13;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.SkyBlue;
            this.numericUpDown1.Location = new System.Drawing.Point(16, 517);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 15;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.dodaj);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.Font = new System.Drawing.Font("Old English Text MT", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(622, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 40);
            this.button1.TabIndex = 16;
            this.button1.Text = "Nazad";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(806, 565);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.btnRezervisi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbRepertoar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ptnPrikazi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtPocetni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtKrajnji;
        private System.Windows.Forms.ComboBox cmbSala;
        private System.Windows.Forms.ComboBox cmbNaziv;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ptnPrikazi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbRepertoar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRezervisi;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button1;
    }
}