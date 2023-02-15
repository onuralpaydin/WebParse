using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebParse.Data;
using WebParse.Models;

namespace WebParse
{
    public partial class OyuncuEkleForm : Form
    {
        public OyuncuEkleForm()
        {
            InitializeComponent();
            //oyuncu crud bu sayfada.
        }
        MovieDbContext db = new MovieDbContext();
        private void btnOyuncuEkle_Click(object sender, EventArgs e)
        {
            //gerekli alanlar boş değilse bir oyuncu oluşturulacak ve db ye kaydedilecek.
            if (!string.IsNullOrEmpty(txtOyuncuAdres.Text) && !string.IsNullOrEmpty(txtOyuncuAdSoyad.Text)&& !string.IsNullOrEmpty(txtOyuncuTelefon.Text))
            {
                db.Oyuncular.Add(new Oyuncu() 
                { AdSoyAd = txtOyuncuAdSoyad.Text, IletisimBilgisi=new IletisimBilgisi() {Adres=txtOyuncuAdres.Text,TelefonNo=txtOyuncuTelefon.Text } });
                db.SaveChanges();
                OyuncularForm oyuncularForm = new OyuncularForm();
                oyuncularForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bilgiler Eksik");
            }
        }
    }
}
