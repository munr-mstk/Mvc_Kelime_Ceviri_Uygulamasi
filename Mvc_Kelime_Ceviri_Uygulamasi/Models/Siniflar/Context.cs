using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Security.Permissions;

namespace Mvc_Kelime_Ceviri_Uygulamasi.Models.Siniflar
{
    public class Context : DbContext
    {
        public DbSet<Kelimeler> Kelimelers { get; set; }

        public DbSet<Yapilacaklar> Yapilacaklars { get; set; }

    }
}