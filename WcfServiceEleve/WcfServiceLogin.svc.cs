using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceEleve
{
    
    public class WcfServiceLogin : IWcfServiceLogin
     {
        EleveContext EC = new EleveContext();

        public Boolean LoginUserDetails(string username,string password)
         {
            List <UserDetails> l= EC.users.Where(p => p.UserName == username & p.Password==password).ToList();
            if (l.Count() != 0) return true;
            else return false;
         }

     

        // public IEnumerable<UserDetails> LoginUserDetails()
        // {
        //   List<UserDetails> listUsers = new List<UserDetails>();
        // EleveContext EC = new EleveContext();
        //listUsers = EC.users.ToList();
        //return listUsers;
        //}

    }
}
