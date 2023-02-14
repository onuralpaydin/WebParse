using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using WebParse.Data;
using WebParse.Models;

namespace WebParse
{
    public partial class MainForm : Form
    {
        MovieDbContext db = new MovieDbContext();
        public MainForm()
        {
            //proje ilk açýldýðýnda data grid viev dolu larak gelsin
            InitializeComponent();
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            FilmleriYukle();
            dvg_Filmler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            pbx_Poster.ImageLocation = (string)dvg_Filmler.SelectedRows[0].Cells[2].Value;
            



        }

        private void FilmleriYukle()
        {
            
            dvg_Filmler.Rows.Clear();
            foreach (var item in db.Filmler.Include(film => film.Oyuncular).Include(film => film.Tur))
            {
                var oyuncular = string.Join(',', item.Oyuncular.Select(oyuncu => oyuncu.AdSoyAd));
                string tur = item.Tur.Ad;
                
                dvg_Filmler.Rows.Add(item.ID, item.Ad, item.Poster, item.Yýl, item.imdbPuaný, item.imdbId, tur,oyuncular);
            }
        }

        private void dvg_Filmler_SelectionChanged(object sender, EventArgs e)
        {
            pbx_Poster.ImageLocation = (string)dvg_Filmler.SelectedRows[0].Cells[2].Value;
        }
    }
}