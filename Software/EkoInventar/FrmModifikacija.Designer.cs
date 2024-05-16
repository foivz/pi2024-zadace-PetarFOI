namespace EkoInventar
{
    partial class FrmModifikacija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModifikacija));
            this.lblModIme = new System.Windows.Forms.Label();
            this.lvlModMax = new System.Windows.Forms.Label();
            this.lblModTrenutno = new System.Windows.Forms.Label();
            this.lblModKriticni = new System.Windows.Forms.Label();
            this.lblModCijena = new System.Windows.Forms.Label();
            this.txtModIme = new System.Windows.Forms.TextBox();
            this.btnModBrisi = new System.Windows.Forms.Button();
            this.cbPopis = new System.Windows.Forms.ComboBox();
            this.btnModDodaj = new System.Windows.Forms.Button();
            this.lblModDodaj = new System.Windows.Forms.Label();
            this.numModMax = new System.Windows.Forms.NumericUpDown();
            this.numModCurrent = new System.Windows.Forms.NumericUpDown();
            this.numModCritical = new System.Windows.Forms.NumericUpDown();
            this.numModCijena = new System.Windows.Forms.NumericUpDown();
            this.btnModSpremi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numModMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numModCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numModCritical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numModCijena)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModIme
            // 
            this.lblModIme.AutoSize = true;
            this.lblModIme.Location = new System.Drawing.Point(83, 71);
            this.lblModIme.Name = "lblModIme";
            this.lblModIme.Size = new System.Drawing.Size(27, 13);
            this.lblModIme.TabIndex = 0;
            this.lblModIme.Text = "Ime:";
            // 
            // lvlModMax
            // 
            this.lvlModMax.AutoSize = true;
            this.lvlModMax.Location = new System.Drawing.Point(13, 110);
            this.lvlModMax.Name = "lvlModMax";
            this.lvlModMax.Size = new System.Drawing.Size(97, 13);
            this.lvlModMax.TabIndex = 1;
            this.lvlModMax.Text = "Maksimalno stanje:";
            // 
            // lblModTrenutno
            // 
            this.lblModTrenutno.AutoSize = true;
            this.lblModTrenutno.Location = new System.Drawing.Point(25, 151);
            this.lblModTrenutno.Name = "lblModTrenutno";
            this.lblModTrenutno.Size = new System.Drawing.Size(84, 13);
            this.lblModTrenutno.TabIndex = 2;
            this.lblModTrenutno.Text = "Trenutno stanje:";
            // 
            // lblModKriticni
            // 
            this.lblModKriticni.AutoSize = true;
            this.lblModKriticni.Location = new System.Drawing.Point(25, 193);
            this.lblModKriticni.Name = "lblModKriticni";
            this.lblModKriticni.Size = new System.Drawing.Size(85, 13);
            this.lblModKriticni.TabIndex = 3;
            this.lblModKriticni.Text = "Kritični postotak:";
            // 
            // lblModCijena
            // 
            this.lblModCijena.AutoSize = true;
            this.lblModCijena.Location = new System.Drawing.Point(71, 240);
            this.lblModCijena.Name = "lblModCijena";
            this.lblModCijena.Size = new System.Drawing.Size(39, 13);
            this.lblModCijena.TabIndex = 4;
            this.lblModCijena.Text = "Cijena:";
            // 
            // txtModIme
            // 
            this.txtModIme.Location = new System.Drawing.Point(116, 71);
            this.txtModIme.Name = "txtModIme";
            this.txtModIme.Size = new System.Drawing.Size(221, 20);
            this.txtModIme.TabIndex = 5;
            // 
            // btnModBrisi
            // 
            this.btnModBrisi.Location = new System.Drawing.Point(495, 240);
            this.btnModBrisi.Name = "btnModBrisi";
            this.btnModBrisi.Size = new System.Drawing.Size(75, 23);
            this.btnModBrisi.TabIndex = 10;
            this.btnModBrisi.Text = "Obriši";
            this.btnModBrisi.UseVisualStyleBackColor = true;
            this.btnModBrisi.Click += new System.EventHandler(this.btnModBrisi_Click);
            // 
            // cbPopis
            // 
            this.cbPopis.FormattingEnabled = true;
            this.cbPopis.Location = new System.Drawing.Point(28, 12);
            this.cbPopis.Name = "cbPopis";
            this.cbPopis.Size = new System.Drawing.Size(209, 21);
            this.cbPopis.TabIndex = 11;
            this.cbPopis.SelectedIndexChanged += new System.EventHandler(this.cbPopis_SelectedIndexChanged);
            // 
            // btnModDodaj
            // 
            this.btnModDodaj.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModDodaj.Location = new System.Drawing.Point(243, 12);
            this.btnModDodaj.Name = "btnModDodaj";
            this.btnModDodaj.Size = new System.Drawing.Size(23, 21);
            this.btnModDodaj.TabIndex = 12;
            this.btnModDodaj.Text = "+";
            this.btnModDodaj.UseVisualStyleBackColor = true;
            this.btnModDodaj.Click += new System.EventHandler(this.btnModDodaj_Click);
            // 
            // lblModDodaj
            // 
            this.lblModDodaj.AutoSize = true;
            this.lblModDodaj.Location = new System.Drawing.Point(272, 16);
            this.lblModDodaj.Name = "lblModDodaj";
            this.lblModDodaj.Size = new System.Drawing.Size(99, 13);
            this.lblModDodaj.TabIndex = 13;
            this.lblModDodaj.Text = "Dodaj novi materijal";
            // 
            // numModMax
            // 
            this.numModMax.Location = new System.Drawing.Point(117, 110);
            this.numModMax.Name = "numModMax";
            this.numModMax.Size = new System.Drawing.Size(220, 20);
            this.numModMax.TabIndex = 14;
            // 
            // numModCurrent
            // 
            this.numModCurrent.Location = new System.Drawing.Point(117, 151);
            this.numModCurrent.Name = "numModCurrent";
            this.numModCurrent.Size = new System.Drawing.Size(220, 20);
            this.numModCurrent.TabIndex = 15;
            // 
            // numModCritical
            // 
            this.numModCritical.Location = new System.Drawing.Point(117, 193);
            this.numModCritical.Name = "numModCritical";
            this.numModCritical.Size = new System.Drawing.Size(220, 20);
            this.numModCritical.TabIndex = 16;
            // 
            // numModCijena
            // 
            this.numModCijena.Location = new System.Drawing.Point(117, 240);
            this.numModCijena.Name = "numModCijena";
            this.numModCijena.Size = new System.Drawing.Size(220, 20);
            this.numModCijena.TabIndex = 17;
            // 
            // btnModSpremi
            // 
            this.btnModSpremi.Location = new System.Drawing.Point(403, 240);
            this.btnModSpremi.Name = "btnModSpremi";
            this.btnModSpremi.Size = new System.Drawing.Size(75, 23);
            this.btnModSpremi.TabIndex = 18;
            this.btnModSpremi.Text = "Spremi";
            this.btnModSpremi.UseVisualStyleBackColor = true;
            this.btnModSpremi.Click += new System.EventHandler(this.btnModSpremi_Click);
            // 
            // FrmModifikacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 291);
            this.Controls.Add(this.btnModSpremi);
            this.Controls.Add(this.numModCijena);
            this.Controls.Add(this.numModCritical);
            this.Controls.Add(this.numModCurrent);
            this.Controls.Add(this.numModMax);
            this.Controls.Add(this.lblModDodaj);
            this.Controls.Add(this.btnModDodaj);
            this.Controls.Add(this.cbPopis);
            this.Controls.Add(this.btnModBrisi);
            this.Controls.Add(this.txtModIme);
            this.Controls.Add(this.lblModCijena);
            this.Controls.Add(this.lblModKriticni);
            this.Controls.Add(this.lblModTrenutno);
            this.Controls.Add(this.lvlModMax);
            this.Controls.Add(this.lblModIme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmModifikacija";
            this.Text = "FrmModifikacija";
            this.Load += new System.EventHandler(this.FrmModifikacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numModMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numModCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numModCritical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numModCijena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModIme;
        private System.Windows.Forms.Label lvlModMax;
        private System.Windows.Forms.Label lblModTrenutno;
        private System.Windows.Forms.Label lblModKriticni;
        private System.Windows.Forms.Label lblModCijena;
        private System.Windows.Forms.TextBox txtModIme;
        private System.Windows.Forms.Button btnModBrisi;
        private System.Windows.Forms.ComboBox cbPopis;
        private System.Windows.Forms.Button btnModDodaj;
        private System.Windows.Forms.Label lblModDodaj;
        private System.Windows.Forms.NumericUpDown numModMax;
        private System.Windows.Forms.NumericUpDown numModCurrent;
        private System.Windows.Forms.NumericUpDown numModCritical;
        private System.Windows.Forms.NumericUpDown numModCijena;
        private System.Windows.Forms.Button btnModSpremi;
    }
}