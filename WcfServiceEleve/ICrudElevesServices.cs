using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceEleve
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICrudElevesServices" in both code and config file together.
    [ServiceContract]
    public interface ICrudElevesServices
    {

        [OperationContract]
        //Pour obtenir les eleves de la base de données :
        IEnumerable<Eleve> GetEleves();
        //Pour l'insertion :
        [OperationContract]
        void InsertEleve(Eleve eobj );
        //Pour la mise à jour :
        [OperationContract]
        void UpdateEleve(Eleve eobj);
        //Pour la suppression :
        [OperationContract]
        void DeleteEleve(int id);


    }

[DataContract]
    public class Eleve
    {
        [DataMember]
        [Key]
        [Required]
        public int Id { get; set; }
        [DataMember]
        [Required]
        public string CNE { get; set; }
        [DataMember]
        [Required]
        public string Nom { get; set; }
        [DataMember]
        [Required]
        public string Prenom { get; set; }
        [DataMember]
        public string Photo { get; set; }
        [DataMember]
        public string Tel { get; set; }
        [DataMember]
        [Required]
        public string Email { get; set; }
    }

}
