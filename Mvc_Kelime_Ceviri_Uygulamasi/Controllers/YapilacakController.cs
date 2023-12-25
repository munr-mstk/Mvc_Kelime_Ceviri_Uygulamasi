using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Kelime_Ceviri_Uygulamasi.Models.Siniflar;

namespace Mvc_Kelime_Ceviri_Uygulamasi.Controllers
{
    public class YapilacakController : Controller
    {

        Context c = new Context();
        public ActionResult Index()
        {
            var dgr1 = c.Yapilacaklars.Count().ToString();
            ViewBag.d1 = dgr1;

            var yapilacak = c.Yapilacaklars.ToList();
            return View(yapilacak);
        }
        [HttpGet]
        public ActionResult YapilacakEkle()
        {

            return View();
        }
        [HttpPost]
        public ActionResult YapilacakEkle(Yapilacaklar y)
        {
            y.Durum = true;
            c.Yapilacaklars.Add(y);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}