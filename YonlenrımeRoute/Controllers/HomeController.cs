using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YonlenrımeRoute.Controllers
{[RoutePrefix("Main")]//ön ek olarak yazar
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [Route("~/about")]//main ifadesi  gelm ez ~işareti onu  harıcı tutar
        public ActionResult About()
        {
            return View();
        }
        [Route("contact-us")]
        public ActionResult Contact()
        {
            return View();
        }
        [Route("~/Demo/{number=1}/{id?}")]//ıd boş olabılır gırılmedende sayfay gırsın
        public ActionResult Demo(int number,int? id)
        {
            return Content(string.Format("Number={0}<br/> Id={1}",number,id.HasValue?id.ToString():"null"));
        }
    }
}