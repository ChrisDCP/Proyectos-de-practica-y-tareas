using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataModel
{
   public partial class dbmodel : DbContext
    {
       public dbmodel() : base(@"Data Source=FAREM_B4_25-PC\SQLEXPRESS;Initial Catalog=codeforms; Integrated Security=True") { }

        public DbSet<Persona> Personas { get; set; }

    }
   public partial class dbmodel
   {
       protected override void OnModelCreating(DbModelBuilder modelBuilder)
       {
           modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
           modelBuilder.Configurations.Add(new mappingPersona());
           base.OnModelCreating(modelBuilder);
       }
   }
}
