using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using System.Data.SqlClient;

namespace DataModel
{
    public class Persona
    {
        public Guid ID { get; set; }
        public string Carnet { get; set; }
        public string Nombre { get; set; }
    }
    public class mappingPersona : EntityTypeConfiguration<Persona>
    {
        public mappingPersona()
        {
            ToTable("tblpersona");
            HasKey(Persona => Persona.ID);
            Property(p => p.Carnet)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(10);
            Property(p => p.Nombre)
               .IsRequired()
               .HasColumnType("varchar")
               .HasMaxLength(20);
            
        }
    }
}

