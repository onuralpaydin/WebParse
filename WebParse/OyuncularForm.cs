using Microsoft.EntityFrameworkCore;
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
    public partial class OyuncularForm : Form
    {
        MovieDbContext db = new MovieDbContext();
        public OyuncularForm()
        {
            InitializeComponent();
            OyunculariListele();
        }

        private void OyunculariListele()
        {
            foreach (Oyuncu oyuncu in db.Oyuncular.Include(oyuncu=>oyuncu.IletisimBilgisi))
            {

                if (oyuncu.IletisimBilgisi != null)
                {
                    dgvOyuncular.Rows.Add(oyuncu.Id, oyuncu.AdSoyAd, oyuncu.IletisimBilgisi.Adres, oyuncu.IletisimBilgisi.TelefonNo);
                }
                else
                {
                    dgvOyuncular.Rows.Add(oyuncu.Id, oyuncu.AdSoyAd, "Adresi Yok", "Telefonu Yok");
                }
            }
        }

        private void dgvOyuncular_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OyuncuEkleForm oyuncuEkleForm = new OyuncuEkleForm();
            oyuncuEkleForm.ShowDialog();

        }
    }
}
