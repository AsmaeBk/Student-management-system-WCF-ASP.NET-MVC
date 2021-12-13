using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceEleve
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CrudElevesServices" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CrudElevesServices.svc or CrudElevesServices.svc.cs at the Solution Explorer and start debugging.
    public class CrudElevesServices : ICrudElevesServices
    {
       
        public void DeleteEleve(int id)
        {
            EleveContext EC = new EleveContext();
            var c = (from elv in EC.eleves
                     where elv.Id == id
                     select elv).First();
            EC.eleves.Remove(c);
            EC.SaveChanges();
        }

        public IEnumerable<Eleve> GetEleves()
        {
            List<Eleve> listEleves = new List<Eleve>();
            EleveContext EC = new EleveContext();
            listEleves = EC.eleves.ToList();
            return listEleves;
        }

        public void InsertEleve(Eleve eobj)
        {
            EleveContext EC = new EleveContext();
            EC.eleves.Add(eobj);
            EC.SaveChanges();
        }

        public void UpdateEleve(Eleve eobj)
        {
            EleveContext EC = new EleveContext();
            var c =(from elv in EC.eleves
                   where elv.Id==eobj.Id
                   select elv).First();
            c.Nom = eobj.Nom;
            c.Prenom= eobj.Prenom;
            c.Photo = eobj.Photo;
            c.Tel = eobj.Tel;
            c.CNE = eobj.CNE;
            EC.SaveChanges();

        }
    }
}
