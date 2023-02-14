using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebParse.Models
{
    
    public class Film
    {
        public Film()
        {
            Oyuncular = new List<Oyuncu>();
        }
        //filmler
        //ad gerekli Max200 karekter
        //yıl 1700-2025 den büyük olamaz
        //1- çok oyuncu liste nesne ilk oluştugunda oluştrulmalıdır.
        //id ad yıl imdbPuanı poster imdbID 1-çok tür çoka -çok oyuncu
        [Key]
        public int ID { get; set; }
        [Range(1700,2025) ]
        public int Yıl { get; set; }
        public decimal imdbPuanı { get; set; }
        [Required]
        [MaxLength(200)]
        public string Ad { get; set; }
        public string Poster { get; set; }
        public string imdbId { get; set; }

        //maping
        public virtual Tur Tur { get; set; }
        public virtual List<Oyuncu> Oyuncular { get; set; }


    }
}
