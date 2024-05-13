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
            this.btnStisni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStisni
            // 
            this.btnStisni.Location = new System.Drawing.Point(344, 162);
            this.btnStisni.Name = "btnStisni";
            this.btnStisni.Size = new System.Drawing.Size(75, 23);
            this.btnStisni.TabIndex = 0;
            this.btnStisni.Text = "Stisni meee";
            this.btnStisni.UseVisualStyleBackColor = true;
            // 
            // FrmPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStisni);
            this.Name = "FrmPregled";
            this.Text = "frmPregled";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStisni;
    }
}