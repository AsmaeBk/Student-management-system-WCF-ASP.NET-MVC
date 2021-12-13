using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceEleve
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EleveService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EleveService.svc or EleveService.svc.cs at the Solution Explorer and start debugging.
    public class EleveService : IEleveService
    {
        private EleveContext EC = new EleveContext();
        public List<Eleve> findAll()
        {
            return EC.eleves.ToList();
        }

        public List<Eleve> findByCNE(string cne)
        {
           return EC.eleves.Where(p => p.CNE == cne).ToList();
        }
    }
}
