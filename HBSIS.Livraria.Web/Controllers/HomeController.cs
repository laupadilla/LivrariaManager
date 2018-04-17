using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HBSIS.Livraria.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult List()
        {
            return Json(Repository.Livro.List(), JsonRequestBehavior.AllowGet);
        }
    }
}