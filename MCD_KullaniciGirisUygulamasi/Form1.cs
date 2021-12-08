﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCD_KullaniciGirisUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            Kullanici bulunanKullanici = SanalDataBase.KullaniciTablo.Find(i => i.kullaniciAdi == kullaniciAdi && i.sifre == sifre);

            //kullaniciAdi= "admin" && sifre ="123"
            if (bulunanKullanici!=null)
            {
                AnaForm _anaForm = new AnaForm(bulunanKullanici);
                _anaForm.Show();
            }
            else
            {
                //Windows form içerisinde nasıl kullanıcıya bir pop up gösteririz bunu
                //çok ufak bir şekilde inceleyelim.

                //Ayrı bir konu olarak daha sonra ele alacağız.

                MessageBox.Show("Hatalı kullanıcı bilgileri","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }

        private void txtKullaniciAdi_Enter(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.Yellow;
        }

        private void txtKullaniciAdi_Leave(object sender, EventArgs e)
        {
            TextBox T1 = (TextBox)sender;
            T1.BackColor = Color.White;
        }
    }
}
