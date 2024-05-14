namespace EkoInventar
{
    partial class FrmPregled
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
            this.dgvMaterijali = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterijali)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMaterijali
            // 
            this.dgvMaterijali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterijali.Location = new System.Drawing.Point(103, 57);
            this.dgvMaterijali.Name = "dgvMaterijali";
            this.dgvMaterijali.Size = new System.Drawing.Size(596, 228);
            this.dgvMaterijali.TabIndex = 0;
            // 
            // FrmPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMaterijali);
            this.Name = "FrmPregled";
            this.Text = "frmPregled";
            this.Load += new System.EventHandler(this.FrmPregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterijali)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaterijali;
    }
}