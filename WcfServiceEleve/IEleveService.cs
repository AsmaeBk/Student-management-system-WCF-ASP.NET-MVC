using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceEleve
{

    [ServiceContract]
    public interface IEleveService
    {
        [OperationContract]
        List<Eleve> findAll();


        [OperationContract]
        List<Eleve> findByCNE(string CNE);
    }
}
