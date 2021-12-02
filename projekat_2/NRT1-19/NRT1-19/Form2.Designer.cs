namespace NRT1_19
{
    partial class Form2
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
            System.Windows.Forms.Label nazivLabel;
            System.Windows.Forms.Label cenaLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.cbKategorija = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tvpbazaDataSet = new NRT1_19.tvpbazaDataSet();
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.cenaTextBox = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.dtPocetni = new System.Windows.Forms.DateTimePicker();
            this.dtKrajnji = new System.Windows.Forms.DateTimePicker();
            this.dgvPoDatumu = new System.Windows.Forms.DataGridView();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.dtMesec = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPrikaz = new System.Windows.Forms.Button();
            this.lbPrikaz = new System.Windows.Forms.ListBox();
            nazivLabel = new System.Windows.Forms.Label();
            cenaLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tvpbazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoDatumu)).BeginInit();
            this.SuspendLayout();
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nazivLabel.Location = new System.Drawing.Point(37, 142);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(46, 18);
            nazivLabel.TabIndex = 15;
            nazivLabel.Text = "naziv:";
            // 
            // cenaLabel
            // 
            cenaLabel.AutoSize = true;
            cenaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cenaLabel.Location = new System.Drawing.Point(37, 168);
            cenaLabel.Name = "cenaLabel";
            cenaLabel.Size = new System.Drawing.Size(44, 18);
            cenaLabel.TabIndex = 17;
            cenaLabel.Text = "cena:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(357, 60);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(105, 18);
            label2.TabIndex = 23;
            label2.Text = "pocetni datum:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(357, 93);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(95, 18);
            label3.TabIndex = 24;
            label3.Text = "krajnji datum:";
            // 
            // cbKategorija
            // 
            this.cbKategorija.FormattingEnabled = true;
            this.cbKategorija.Location = new System.Drawing.Point(167, 101);
            this.cbKategorija.Name = "cbKategorija";
            this.cbKategorija.Size = new System.Drawing.Size(121, 21);
            this.cbKategorija.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Izaberite kategoriju";
            // 
            // tvpbazaDataSet
            // 
            this.tvpbazaDataSet.DataSetName = "tvpbazaDataSet";
            this.tvpbazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.Location = new System.Drawing.Point(89, 140);
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(183, 20);
            this.nazivTextBox.TabIndex = 16;
            // 
            // cenaTextBox
            // 
            this.cenaTextBox.Location = new System.Drawing.Point(89, 166);
            this.cenaTextBox.Name = "cenaTextBox";
            this.cenaTextBox.Size = new System.Drawing.Size(183, 20);
            this.cenaTextBox.TabIndex = 18;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(42, 219);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(230, 34);
            this.btnDodaj.TabIndex = 19;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // dtPocetni
            // 
            this.dtPocetni.Location = new System.Drawing.Point(480, 58);
            this.dtPocetni.Name = "dtPocetni";
            this.dtPocetni.Size = new System.Drawing.Size(200, 20);
            this.dtPocetni.TabIndex = 20;
            // 
            // dtKrajnji
            // 
            this.dtKrajnji.Location = new System.Drawing.Point(480, 98);
            this.dtKrajnji.Name = "dtKrajnji";
            this.dtKrajnji.Size = new System.Drawing.Size(200, 20);
            this.dtKrajnji.TabIndex = 21;
            this.dtKrajnji.Value = new System.DateTime(2021, 5, 26, 21, 0, 57, 0);
            // 
            // dgvPoDatumu
            // 
            this.dgvPoDatumu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPoDatumu.Location = new System.Drawing.Point(327, 185);
            this.dgvPoDatumu.Name = "dgvPoDatumu";
            this.dgvPoDatumu.Size = new System.Drawing.Size(373, 164);
            this.dgvPoDatumu.TabIndex = 22;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikazi.Location = new System.Drawing.Point(408, 136);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(230, 34);
            this.btnPrikazi.TabIndex = 25;
            this.btnPrikazi.Text = "Pogledaj racune";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // dtMesec
            // 
            this.dtMesec.CustomFormat = "MMMM";
            this.dtMesec.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtMesec.Location = new System.Drawing.Point(36, 402);
            this.dtMesec.Name = "dtMesec";
            this.dtMesec.ShowUpDown = true;
            this.dtMesec.Size = new System.Drawing.Size(200, 20);
            this.dtMesec.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Izaberite mesec";
            // 
            // btnPrikaz
            // 
            this.btnPrikaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrikaz.Location = new System.Drawing.Point(27, 440);
            this.btnPrikaz.Name = "btnPrikaz";
            this.btnPrikaz.Size = new System.Drawing.Size(230, 34);
            this.btnPrikaz.TabIndex = 28;
            this.btnPrikaz.Text = "Prikazi";
            this.btnPrikaz.UseVisualStyleBackColor = true;
            this.btnPrikaz.Click += new System.EventHandler(this.btnPrikaz_Click);
            // 
            // lbPrikaz
            // 
            this.lbPrikaz.FormattingEnabled = true;
            this.lbPrikaz.Location = new System.Drawing.Point(27, 493);
            this.lbPrikaz.Name = "lbPrikaz";
            this.lbPrikaz.Size = new System.Drawing.Size(230, 147);
            this.lbPrikaz.TabIndex = 29;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 653);
            this.Controls.Add(this.lbPrikaz);
            this.Controls.Add(this.btnPrikaz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtMesec);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.dgvPoDatumu);
            this.Controls.Add(this.dtKrajnji);
            this.Controls.Add(this.dtPocetni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.nazivTextBox);
            this.Controls.Add(cenaLabel);
            this.Controls.Add(this.cenaTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbKategorija);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form2_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.tvpbazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPoDatumu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKategorija;
        private System.Windows.Forms.Label label1;
        private tvpbazaDataSet tvpbazaDataSet;
        private System.Windows.Forms.TextBox nazivTextBox;
        private System.Windows.Forms.TextBox cenaTextBox;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.DateTimePicker dtPocetni;
        private System.Windows.Forms.DateTimePicker dtKrajnji;
        private System.Windows.Forms.DataGridView dgvPoDatumu;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.DateTimePicker dtMesec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPrikaz;
        private System.Windows.Forms.ListBox lbPrikaz;
    }
}