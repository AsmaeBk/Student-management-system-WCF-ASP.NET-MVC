using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Login1;
using S1;
namespace MVC_GestionEleve.Controllers
{
    public class LoginController : Controller
    {
        WcfServiceLoginClient login = new WcfServiceLoginClient();
    
        public ActionResult TestLog()
        {
            CrudElevesServicesClient o = new CrudElevesServicesClient();
            List<Eleve> li = o.GetEleves().ToList();
            ViewBag.List = li;
            return View();
         }

        [HttpPost]
        public ActionResult TestLog(string username,string password)
        {
            CrudElevesServicesClient o = new CrudElevesServicesClient();
            List<Eleve> li = o.GetEleves().ToList();
            ViewBag.List = li;

            if (login.LoginUserDetails(username, password) ==true)
            {
                /*Console.WriteLine("treu");*/
                return View("~/Views/ElevesCrud/getEleves.cshtml");
            }
            else
            {
                return View("LoginError");
            }
        }
        //[HttpPost]
        //public ActionResult TestLogin(IFormCollection fc)
        //{
        //    string u = fc["username"];
        //    string p = fc["password"];
        //    ViewBag.listEleves = login.LoginUserDetails(u, p);
        //    return View("Index");
        //}
     
    }
}
