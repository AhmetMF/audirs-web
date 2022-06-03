using System;
using System.Collections.Generic;
using System.Linq;

using System.Web;
using System.Web.Mvc;
using AudiRsWeb.Models;

namespace AudiRsWeb.Controllers
{
    public class HomeController : Controller
    {
        Context c = new Context();

        public ActionResult Index()
        {
            var deger = c.anaSayfas.ToList();
            return View(deger);
        }



        Context a = new Context();
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            var deger = a.infopages.ToList();
            return View(deger);
        }

        Context h = new Context();
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            var deger = h.iletisims.ToList();
            return View(deger);
        }
       
        Context r = new Context();
        public ActionResult Services()
        {
            ViewBag.Message = "Your contact page.";
            var deger = r.servis.ToList();
            return View(deger);
        }

        Context f = new Context();
        public ActionResult Quattro()
        {
            ViewBag.Message = "Your contact page.";
            var deger = f.quattros.ToList();
            return View(deger);
        }

        Context b = new Context();  
        public ActionResult rs6()
        {
            ViewBag.Message = "Your contact page.";
            var deger = b.infopages.ToList();
            return View(deger);
        }

        Context e = new Context();
        public ActionResult rs7()
        {
            ViewBag.Message = "Your contact page.";
            var deger = e.infopages.ToList();
            return View(deger);
        }


    }
}