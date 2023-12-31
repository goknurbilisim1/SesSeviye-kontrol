﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ses_seviye_kontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tBarSes_Scroll(object sender, EventArgs e)
        {
            int deger = tBarSes.Value;
            lblSeviyeDeger.Text = deger.ToString();

            if(deger>=0 && deger < 25)
            {
                lblSesSeviyesi.Text = "Ses Seviyesi Düşük";
                this.BackColor = Color.Blue;
            }
            else if(deger>=25 && deger < 70)
            {
                lblSesSeviyesi.Text = "Ses Seviyesi Normal";
                this.BackColor = Color.Green;
            }
            else if(deger>=70 && deger < 90)
            {
                lblSesSeviyesi.Text = "Ses Seviye Yüksek";
                this.BackColor = Color.Orange;
            }
            else
            {
                lblSesSeviyesi.Text = "Ses Seviyesi Çok Yüksek";
                this.BackColor = Color.Red;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSesSeviyesi.Text = "Ses Seviyesi Düşük";
            this.BackColor = Color.Blue;
            lblSeviyeDeger.Text = "0";
        }
    }
}
