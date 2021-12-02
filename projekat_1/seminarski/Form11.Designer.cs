namespace seminarski
{
    partial class Form11
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
            this.numMesta = new System.Windows.Forms.NumericUpDown();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.btnAzuriraj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbFilmovi = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numMesta)).BeginInit();
            this.SuspendLayout();
            // 
            // numMesta
            // 
            this.numMesta.BackColor = System.Drawing.Color.SkyBlue;
            this.numMesta.Location = new System.Drawing.Point(94, 218);
            this.numMesta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMesta.Name = "numMesta";
            this.numMesta.Size = new System.Drawing.Size(129, 20);
            this.numMesta.TabIndex = 0;
            this.numMesta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMesta.ValueChanged += new System.EventHandler(this.dodaj);
            // 
            // txtCena
            // 
            this.txtCena.BackColor = System.Drawing.Color.SkyBlue;
            this.txtCena.Location = new System.Drawing.Point(249, 218);
            this.txtCena.Name = "txtCena";
            this.txtCena.ReadOnly = true;
            this.txtCena.Size = new System.Drawing.Size(130, 20);
            this.txtCena.TabIndex = 1;
            // 
            // btnAzuriraj
            // 
            this.btnAzuriraj.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAzuriraj.Font = new System.Drawing.Font("Old English Text MT", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAzuriraj.Location = new System.Drawing.Point(12, 256);
            this.btnAzuriraj.Name = "btnAzuriraj";
            this.btnAzuriraj.Size = new System.Drawing.Size(263, 40);
            this.btnAzuriraj.TabIndex = 5;
            this.btnAzuriraj.Text = "Azurirajte";
            this.btnAzuriraj.UseVisualStyleBackColor = false;
            this.btnAzuriraj.Click += new System.EventHandler(this.btnAzuriraj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Broj mesta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(271, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cena karata:";
            // 
            // lbFilmovi
            // 
            this.lbFilmovi.BackColor = System.Drawing.Color.SkyBlue;
            this.lbFilmovi.FormattingEnabled = true;
            this.lbFilmovi.Location = new System.Drawing.Point(12, 12);
            this.lbFilmovi.Name = "lbFilmovi";
            this.lbFilmovi.Size = new System.Drawing.Size(435, 160);
            this.lbFilmovi.TabIndex = 8;
            this.lbFilmovi.SelectedIndexChanged += new System.EventHandler(this.lbFilmovi_SelectedIndexChanged);
            this.lbFilmovi.SelectedValueChanged += new System.EventHandler(this.dodaj);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.Font = new System.Drawing.Font("Old English Text MT", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(281, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Nazad";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(459, 308);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbFilmovi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAzuriraj);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.numMesta);
            this.Name = "Form11";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMesta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numMesta;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Button btnAzuriraj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbFilmovi;
        private System.Windows.Forms.Button button1;
    }
}