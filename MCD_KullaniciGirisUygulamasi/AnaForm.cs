using System;
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
    public partial class AnaForm : Form
    {
        public AnaForm(Kullanici bulunanKullanici)
        {
            InitializeComponent();

            txtİsim.Text = bulunanKullanici.isim;
            txtSoyisim.Text = bulunanKullanici.soyisim;
            txtKullaniciAdi.Text = bulunanKullanici.kullaniciAdi;
            txtSifre.Text = bulunanKullanici.sifre;
            txtAciklama.Text = bulunanKullanici.aciklama;
            btnGuncelle.Tag = bulunanKullanici.id;
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //Button btnGuncelleYakala = (Button) sender;
            int id = (int)btnGuncelle.Tag;
            int index = SanalDataBase.KullaniciTablo.FindIndex(i => i.id == id);
            SanalDataBase.KullaniciTablo[index].isim = txtİsim.Text;
            SanalDataBase.KullaniciTablo[index].soyisim = txtSoyisim.Text;
            SanalDataBase.KullaniciTablo[index].kullaniciAdi = txtKullaniciAdi.Text;
            SanalDataBase.KullaniciTablo[index].sifre = txtSifre.Text;
            SanalDataBase.KullaniciTablo[index].aciklama = txtAciklama.Text;
        }
    }
}
