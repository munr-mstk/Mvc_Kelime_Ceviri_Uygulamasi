using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Kelime_Ceviri_Uygulamasi.Models.Siniflar;

namespace Mvc_Kelime_Ceviri_Uygulamasi.Controllers
{
    public class KelimelerController : Controller
    {

        Context c = new Context();
        public ActionResult Index(string p)
        {

            var degerler = from x in c.Kelimelers select x;
            if (!string.IsNullOrEmpty(p))
            {
                degerler = degerler.Where(y =>
        y.English.Contains(p) ||
        y.Turkce.Contains(p));

            }
            return View(degerler.ToList());
        }
        [HttpGet]
        public ActionResult KelimeEkle()
        {

            return View();
        }
        [HttpPost]
        public ActionResult KelimeEkle(Kelimeler d)
        {
            d.Durum = true;
            c.Kelimelers.Add(d);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KelimeSil(int id)
        {
            var klm = c.Kelimelers.Find(id);
            c.Kelimelers.Remove(klm);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult KelimeGetir(int id)
        {

            var kel = c.Kelimelers.Find(id);

            return View("KelimeGetir", kel);
        }
        public ActionResult KelimeGuncelle(Kelimeler p)
        {
            var kel = c.Kelimelers.Find(p.id);
            kel.English = p.English;
            c.SaveChanges();
            return RedirectToAction("Index");


        }
        [HttpGet]
        public ActionResult KelimeCevir()
        {

            return View();
        }
        [HttpPost]
        public ActionResult KelimeCevir(Kelimeler model)
        {

            var turkceKelime = c.Kelimelers.FirstOrDefault(x => x.English == model.English);

            if (turkceKelime != null)
            {

                ViewBag.TurkceKelime = turkceKelime.Turkce;
            }
            else
            {

                ViewBag.TurkceKelime = "Çeviri bulunamadı.";
            }

            return View("KelimeCevir");
        }
        [HttpGet]
        public ActionResult KelimeCevirTr()
        {

            return View();
        }
        [HttpPost]
        public ActionResult KelimeCevirTr(Kelimeler model)
        {

            var ingilizcekelime = c.Kelimelers.FirstOrDefault(x => x.Turkce == model.Turkce);

            if (ingilizcekelime != null)
            {

                ViewBag.ingilizcekelime = ingilizcekelime.English;
            }
            else
            {

                ViewBag.ingilizcekelime = "Çeviri bulunamadı.";
            }

            return View("KelimeCevirTr");


        }
    }

}