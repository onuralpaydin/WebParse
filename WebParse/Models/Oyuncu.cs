using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebParse.Models
{
    public class Oyuncu
    {
        //Id AdSoyad gerekli (Max60 karakter)
        //1-1 oyuncu iletişim bilgisi
        //oyuncu-film mant to many
        //fil liste nesne ilk olştuğunda olluşturulmalıdır

        public Oyuncu()
        {
            Films = new List<Film>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(60)]
        public string AdSoyAd { get; set; }

        //navigation
        public IletisimBilgisi IletisimBilgisi { get; set; }
        public  List<Film> Films { get; set; }

    }
}
