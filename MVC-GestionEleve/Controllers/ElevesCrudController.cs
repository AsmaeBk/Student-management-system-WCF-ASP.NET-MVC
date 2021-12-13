using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using S1;

namespace MVC_GestionEleve.Controllers
{
    public class ElevesCrudController : Controller
    {
        public Eleve Eleve{ get; set; }

        public ActionResult getEleves()
        {
            CrudElevesServicesClient o = new CrudElevesServicesClient();
            List<Eleve> li = o.GetEleves().ToList();
            ViewBag.List = li;

            return View();
        }
        //La methode suivante est pour afficher la vue (Displaying the view):
        public ActionResult insertEleve( )
        {
            return View();
        }
        //Les details de la form qu'on a poset doivent correspondre au details de l'objet objEleve , et on stock les données de post dans l'objet ObjEleve 
       [HttpPost]
        public ActionResult insertEleve(Eleve ObjEleve)
        {
            CrudElevesServicesClient o = new CrudElevesServicesClient();
            o.InsertEleve(ObjEleve);
            return View();
        }

        public ActionResult updateEleve()
        {
            return View();
        }
        [HttpPost]
        public ActionResult updateEleve(Eleve ObjEleve)
        {
           
       CrudElevesServicesClient o = new CrudElevesServicesClient();
            o.UpdateEleve(ObjEleve);
            return View();
        }
        public ActionResult deleteEleve()
        {
            return View();
        }
        [HttpPost]
        public ActionResult deleteEleve(int id)
        {
            CrudElevesServicesClient o = new CrudElevesServicesClient();
            o.DeleteEleve(id);
            return View();
        }
    }
}
