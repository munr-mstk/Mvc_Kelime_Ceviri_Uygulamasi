using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc_Kelime_Ceviri_Uygulamasi.Models.Siniflar
{
    public class Yapilacaklar
    {
        [Key]
        public int Yapilacakid { get; set; }
        
        
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string Baslik { get; set; }
        
        
        [Column(TypeName = "bit")]
        public bool Durum { get; set; }
        
        
    }
}