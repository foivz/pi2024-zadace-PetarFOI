﻿namespace EkoInventar
{
    partial class FrmPreglednik
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 75);
            this.label1.TabIndex = 0;
            this.label1.Text = "Šta želite?";
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMod.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMod.Location = new System.Drawing.Point(160, 136);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(320, 50);
            this.btnMod.TabIndex = 1;
            this.btnMod.Text = "Modificiranje podataka";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSearch.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(160, 192);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(320, 50);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Pretraživati";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnOdjava
            // 
            this.btnOdjava.Location = new System.Drawing.Point(282, 248);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(75, 23);
            this.btnOdjava.TabIndex = 3;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = true;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // FrmPreglednik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 292);
            this.Controls.Add(this.btnOdjava);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.label1);
            this.Name = "FrmPreglednik";
            this.Text = "FrmPreglednik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnOdjava;
    }
}