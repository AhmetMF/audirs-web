using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var deger = c.anaSayfas.ToList();
            return View(deger);
        }

        public ActionResult AnaSayfaGetir(int id = 1)
        {
            var ag = c.anaSayfas.Find(id);
            return View("AnaSayfaGetir", ag);
        }
        public ActionResult AnaSayfaGuncelle(AnaSayfa x)
        {
            var ag = c.anaSayfas.Find(x.id);
            ag.oz1 = x.oz1;
            ag.oz2 = x.oz2;
            ag.ozimg = x.ozimg;
            ag.raceimg = x.raceimg;
            ag.racetext = x.racetext;
            ag.infotext = x.infotext;
            ag.info1 = x.info1;
            ag.info2 = x.info2;
            ag.info3 = x.info3;
            ag.info4 = x.info4;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

       
        public ActionResult Infopagegetir(int id = 1)
        {
            var deger = c.infopages.Where(x => x.id == id).ToList();
            return View("infopagegetir", deger);

        }

        public ActionResult Infopageguncelle(int id=1)
        {
            var agg = c.infopages.Find(id);
            return View("infopageguncelle", agg);
        }

        [HttpPost]
        public ActionResult Infopageguncelle(infopage x)
        {
            var agg = c.infopages.Find(x.id);
            agg.text1 = x.text1;
            agg.text2 = x.text2;
            agg.text3 = x.text3;
            agg.text4 = x.text4;
            agg.text5 = x.text5;
            agg.text6 = x.text6;
            agg.text7 = x.text7;
            agg.text8 = x.text8;
            agg.text9 = x.text9;
            agg.img1 = x.img1;
            agg.img2 = x.img2;
            agg.img3 = x.img3;
            agg.img4 = x.img4;
            agg.img5 = x.img5;
            agg.img6 = x.img6;
            agg.img7 = x.img7;
            agg.img8 = x.img8;
            agg.img9 = x.img9;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

    }

}