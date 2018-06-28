using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc_tEST_LETURE.Models;

namespace mvc_tEST_LETURE.Controllers
{
    public class HomeController : Controller
    {

        ComplaintsDBEntities en = new ComplaintsDBEntities();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult InsertData(Students std)
        {
            Cart crt = new Cart();
            crt.ProductId = 1;
            crt.ProductName = "Shampoo";
            en.Carts.Add(crt);
            en.SaveChanges();
            Request.Cookies.Add(new HttpCookie("cart", crt.ProductName));
            return Json(true);
        }
    }
}