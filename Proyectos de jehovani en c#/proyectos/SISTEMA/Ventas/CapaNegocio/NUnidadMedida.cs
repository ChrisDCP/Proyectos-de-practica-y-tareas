using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaNegocio
{
    public class NUnidadMedida
    {
        public static int GUARDAR(string nombre)
        {
            DUnidadMedida u = new DUnidadMedida();

            return u.SP_AgregarUnidadMedida(nombre);
        }

        public static int EDITAR(int id_unidadMedida, string nombre)
        {
            DUnidadMedida u = new DUnidadMedida();

            return u.SP_EditarUnidadMedida(id_unidadMedida, nombre);
        }

        public static int ELIMINAR(int id_unidadMedida)
        {
            DUnidadMedida u = new DUnidadMedida();

            return u.SP_EliminarUnidadMedida(id_unidadMedida);
        }


        public static int CODIGO()
        {
            DUnidadMedida u = new DUnidadMedida();

            return u.SP_IDUnidadMedida();
        }

        public static string MOSTRARUNIDAD(int id_producto)
        {
            DUnidadMedida u = new DUnidadMedida();

            return u.SP_MostrarUnidadProducto(id_producto);
        }

        public static DataTable LISTAR(string nombre = "")
        {
            DUnidadMedida u = new DUnidadMedida();
            return u.SP_ListarUnidadMedida(nombre);
        }
    }
}
