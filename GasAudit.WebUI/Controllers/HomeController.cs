using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GasAudit.WebUI.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {

            string path = HttpContext.Server.MapPath("~/App_Data/logs/app.log"); // отримуємо фізичний шлях файлу з логами
            try
            {
                using (StreamReader sr = new StreamReader(path)) 
                {
                    string line = sr.ReadToEnd();
                    ViewBag.Log = line.Split(new char[] {'\n'});
                }
            }
            catch (Exception e)
            {

            }
            return View();
        }

    }
}
