using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaNegocio
{
    public class NCategoria
    {
        public static int GUARDAR(string nombre)
        {
            DCategoria c = new DCategoria();

            return c.SP_AgregarCategoria(nombre);
        }

        public static int EDITAR(int id_categoria, string nombre)
        {
            DCategoria c = new DCategoria();

            return c.SP_EditarCategoria(id_categoria, nombre);
        }

        public static int ELIMINAR(int id_categoria)
        {
            DCategoria c = new DCategoria();

            return c.SP_EliminarCategoria(id_categoria);
        }


        public static int CODIGO()
        {
            DCategoria c = new DCategoria();

            return c.SP_IDCategoria();
        }

        public static DataTable LISTAR(string nombre = "")
        {
            DCategoria c = new DCategoria();
            return c.SP_ListarCategoria(nombre);
        }

        
    }
}
