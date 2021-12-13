using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceEleve
{
    
[ServiceContract]
     public interface IWcfServiceLogin
     {
        [OperationContract]
        Boolean LoginUserDetails(string username,string password);
     }
    
[DataContract]
     public class UserDetails
     {
           [DataMember]
           [Key]
           [Required]
           public string UserName { get; set; }
           [DataMember]
           [Required]
           public string Password { get; set; }
     }
}
