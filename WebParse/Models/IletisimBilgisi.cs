using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebParse.Models
{
    public class IletisimBilgisi
    {
        //iletişim bilglrti 
        //telefon
        //adres 
        //OyuncuId => pk,fk
        //bit oyuncunun bir iletişim bilgisi olmalı

        [Required, MaxLength(15)]
        public string TelefonNo { get; set; }
        public string Adres { get; set; }
        [Key, ForeignKey("Oyuncu")] // => burayı kaldırırsam ne olur 
        public int OyuncuID { get; set; }
        public Oyuncu Oyuncu { get; set; }

    }
}
