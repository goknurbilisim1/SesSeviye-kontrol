﻿namespace ses_seviye_kontrol
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
            this.tBarSes = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSesSeviyesi = new System.Windows.Forms.Label();
            this.lblSeviyeDeger = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tBarSes)).BeginInit();
            this.SuspendLayout();
            // 
            // tBarSes
            // 
            this.tBarSes.Location = new System.Drawing.Point(146, 24);
            this.tBarSes.Maximum = 100;
            this.tBarSes.Name = "tBarSes";
            this.tBarSes.Size = new System.Drawing.Size(405, 45);
            this.tBarSes.TabIndex = 0;
            this.tBarSes.Scroll += new System.EventHandler(this.tBarSes_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ses Seviyesi";
            // 
            // lblSesSeviyesi
            // 
            this.lblSesSeviyesi.AutoSize = true;
            this.lblSesSeviyesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSesSeviyesi.Location = new System.Drawing.Point(108, 83);
            this.lblSesSeviyesi.Name = "lblSesSeviyesi";
            this.lblSesSeviyesi.Size = new System.Drawing.Size(140, 24);
            this.lblSesSeviyesi.TabIndex = 2;
            this.lblSesSeviyesi.Text = "Ses Seviyesi: ";
            // 
            // lblSeviyeDeger
            // 
            this.lblSeviyeDeger.AutoSize = true;
            this.lblSeviyeDeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeviyeDeger.Location = new System.Drawing.Point(595, 33);
            this.lblSeviyeDeger.Name = "lblSeviyeDeger";
            this.lblSeviyeDeger.Size = new System.Drawing.Size(78, 24);
            this.lblSeviyeDeger.TabIndex = 3;
            this.lblSeviyeDeger.Text = "Seviye:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 156);
            this.Controls.Add(this.lblSeviyeDeger);
            this.Controls.Add(this.lblSesSeviyesi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBarSes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBarSes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tBarSes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSesSeviyesi;
        private System.Windows.Forms.Label lblSeviyeDeger;
    }
}

