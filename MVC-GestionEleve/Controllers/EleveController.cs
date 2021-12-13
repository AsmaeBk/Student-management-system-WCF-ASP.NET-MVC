//using EleveService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SE1;
namespace MVC_GestionEleve.Controllers
{

    public class EleveController : Controller
    {

        private EleveServiceClient elc = new EleveServiceClient();

        public IActionResult Index()
        {
            
            ViewBag.listEleves = elc.findAll();
            return View();
        }
        public ActionResult Search(IFormCollection fc)
        {
            string cne = fc["cne"];
            ViewBag.listEleves = elc.findByCNE(Convert.ToString(cne));

            return View("Index");
        }
    }
}
