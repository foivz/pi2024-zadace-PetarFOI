namespace EkoInventar
{
    partial class FrmPretrazitelj
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPretrazitelj));
            this.dgvMaterijali = new System.Windows.Forms.DataGridView();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterijali)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMaterijali
            // 
            this.dgvMaterijali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterijali.Location = new System.Drawing.Point(35, 57);
            this.dgvMaterijali.Name = "dgvMaterijali";
            this.dgvMaterijali.Size = new System.Drawing.Size(528, 154);
            this.dgvMaterijali.TabIndex = 0;
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Location = new System.Drawing.Point(35, 31);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(528, 20);
            this.txtSearchBox.TabIndex = 1;
            this.txtSearchBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearchBox.TextChanged += new System.EventHandler(this.txtSearchBox_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmPretrazitelj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 244);
            this.Controls.Add(this.txtSearchBox);
            this.Controls.Add(this.dgvMaterijali);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPretrazitelj";
            this.Text = "frmPregled";
            this.Load += new System.EventHandler(this.FrmPregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterijali)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMaterijali;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}