using Microsoft.AspNetCore.Mvc;
using System;


namespace Site01.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //return new ContentResult() {Content= "Olá mundo", ContentType="application/json", StatusCode = 200 }; 

            return View();
        }
    }
}
