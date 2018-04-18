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

        [HttpGet]
        public JsonResult List()
        {
            return Json(Repository.Livro.List(), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Save(Repository.Livro item)
        {
            var model = new Models.Home();            

            return Json(model.Save(item));
        }

        [HttpPost]
        public JsonResult Delete(int id)
        {
            Models.Home.Delete(id);

            return Json("OK");
        }
    }
}