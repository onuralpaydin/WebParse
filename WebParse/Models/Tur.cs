using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebParse.Models
{
    [Table ("Turler")]
    public class Tur
    {
        //Tablo adı türler olsun
        //Id
        //Ad
        //1 türe ait birden çok film olabilir

        public int Id { get; set; }
        public string Ad { get; set; }

        public List<Film> Filmler { get; set; }
    }
}
