namespace EkoInventar
{
    partial class Tutorijal
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
            this.lblAdmini = new System.Windows.Forms.Label();
            this.lblKorisnici = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_Admini = new System.Windows.Forms.DataGridView();
            this.dgv_Korisnici = new System.Windows.Forms.DataGridView();
            this.rtbVidi = new System.Windows.Forms.RichTextBox();
            this.rtbEASTER = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Admini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Korisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdmini
            // 
            this.lblAdmini.AutoSize = true;
            this.lblAdmini.Location = new System.Drawing.Point(47, 103);
            this.lblAdmini.Name = "lblAdmini";
            this.lblAdmini.Size = new System.Drawing.Size(131, 13);
            this.lblAdmini.TabIndex = 0;
            this.lblAdmini.Text = "Popis svih Admin Računa:";
            // 
            // lblKorisnici
            // 
            this.lblKorisnici.AutoSize = true;
            this.lblKorisnici.Location = new System.Drawing.Point(47, 252);
            this.lblKorisnici.Name = "lblKorisnici";
            this.lblKorisnici.Size = new System.Drawing.Size(139, 13);
            this.lblKorisnici.TabIndex = 1;
            this.lblKorisnici.Text = "Popis svih Korisnik Računa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 2;
            // 
            // dgv_Admini
            // 
            this.dgv_Admini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Admini.Location = new System.Drawing.Point(50, 119);
            this.dgv_Admini.Name = "dgv_Admini";
            this.dgv_Admini.Size = new System.Drawing.Size(265, 111);
            this.dgv_Admini.TabIndex = 3;
            // 
            // dgv_Korisnici
            // 
            this.dgv_Korisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Korisnici.Location = new System.Drawing.Point(50, 268);
            this.dgv_Korisnici.Name = "dgv_Korisnici";
            this.dgv_Korisnici.Size = new System.Drawing.Size(265, 111);
            this.dgv_Korisnici.TabIndex = 4;
            // 
            // rtbVidi
            // 
            this.rtbVidi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbVidi.Location = new System.Drawing.Point(50, 12);
            this.rtbVidi.Name = "rtbVidi";
            this.rtbVidi.Size = new System.Drawing.Size(265, 72);
            this.rtbVidi.TabIndex = 5;
            this.rtbVidi.Text = "Ako stisnete OP automatski vas logira kao admina, ovo je samo da je lakse raditi " +
    "na aplikacijia";
            // 
            // rtbEASTER
            // 
            this.rtbEASTER.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbEASTER.Location = new System.Drawing.Point(50, 385);
            this.rtbEASTER.Name = "rtbEASTER";
            this.rtbEASTER.Size = new System.Drawing.Size(265, 50);
            this.rtbEASTER.TabIndex = 6;
            this.rtbEASTER.Text = "EASTER EGG: stisnite na logo na login formi :)";
            // 
            // Tutorijal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 435);
            this.Controls.Add(this.rtbEASTER);
            this.Controls.Add(this.rtbVidi);
            this.Controls.Add(this.dgv_Korisnici);
            this.Controls.Add(this.dgv_Admini);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblKorisnici);
            this.Controls.Add(this.lblAdmini);
            this.Name = "Tutorijal";
            this.Text = "Tutorijal";
            this.Load += new System.EventHandler(this.Tutorijal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Admini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Korisnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdmini;
        private System.Windows.Forms.Label lblKorisnici;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_Admini;
        private System.Windows.Forms.DataGridView dgv_Korisnici;
        private System.Windows.Forms.RichTextBox rtbVidi;
        private System.Windows.Forms.RichTextBox rtbEASTER;
    }
}