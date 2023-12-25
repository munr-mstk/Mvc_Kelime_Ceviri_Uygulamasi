using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace Mvc_Kelime_Ceviri_Uygulamasi.Models.Siniflar
{
    public class Kelimeler
    {
        [Key]
        public int id { get; set; }
        public string English { get; set; }
        public String Turkce { get; set; }
        public bool Durum { get; set; }
    }
}