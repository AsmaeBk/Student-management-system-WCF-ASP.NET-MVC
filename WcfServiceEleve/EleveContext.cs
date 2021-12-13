using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WcfServiceEleve
{
    public class EleveContext : DbContext
    {
        public DbSet<Eleve> eleves { get; set;}
        public DbSet<UserDetails> users { get; set;}
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<EleveContext>(null);
            base.OnModelCreating(modelBuilder);
        }
        public EleveContext():base("EleveCStg")
        {
        }
    }
}