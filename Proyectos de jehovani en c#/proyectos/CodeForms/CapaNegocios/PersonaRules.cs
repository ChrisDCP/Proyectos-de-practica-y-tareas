using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace CapaNegocios
{
     public class PersonaRules
    {
        public Guid guardar (Persona Persona)
        {
            using (var db = new dbmodel()) 
            {
                try
                {
                    Persona.ID = Guid.NewGuid();
                    db.Personas.Add(Persona);
                    db.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
            return Persona.ID;
        }
        public Persona Buscar(string Carnet)
        {
            using (var db = new dbmodel())
            {
                return db.Personas.Where(c => c.Carnet == Carnet).FirstOrDefault();
            }
        }
        public void Editar(Persona _persona)
        {
            using (var db = new dbmodel())
            {
                var p = db.Personas.Where(c => c.ID == _persona.ID).FirstOrDefault();

                if (p != null)
                {
                    var pexist = this.Buscar(p.Carnet);
                    if (pexist != null)
                    {
                        throw new Exception("ya existe una persona con esa identificacion");
                    }
                    /*para editarlos 
                    * * */
                    p.ID = _persona.ID;
                    p.Carnet = _persona.Carnet;
                    p.Nombre = _persona.Nombre;

                    db.Entry(p).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
        }
    }
}
