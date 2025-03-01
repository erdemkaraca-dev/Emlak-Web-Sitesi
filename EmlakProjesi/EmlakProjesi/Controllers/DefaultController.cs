using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmlakProjesi.Models.Entity;

namespace EmlakProjesi.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        dbemlakEntities db = new dbemlakEntities();
        public ActionResult Index()
        {
            var degerler = db.TBLEVLER.ToList();
            return View(degerler);
        }
    }
}