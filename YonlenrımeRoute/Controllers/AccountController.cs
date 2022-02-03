using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using YonlenrımeRoute.Models;

namespace YonlenrımeRoute.Controllers
{
    public class AccountController : Controller
    {
        kullaniciEntities db = new kullaniciEntities();
        // GET: Account
        [Route("register")]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [Route("register")]
        public ActionResult Register(usertablo user)
        {
            db.usertabloes.Add(user);
            db.SaveChanges();
            return RedirectToAction("Profile",new { username=user.firstname});
        }
        [Route("u/{username}")]//kullanıcıdan  gelen
        public ActionResult Profile(string username)
        {
            var user = db.usertabloes.FirstOrDefault(x => x.firstname == username);
            if (user == null)
                return new HttpNotFoundResult();
            return View(user);
        }
    }
}