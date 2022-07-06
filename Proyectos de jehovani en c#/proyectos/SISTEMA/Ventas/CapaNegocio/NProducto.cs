using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaNegocio
{
    public class NProducto
    {
        public static int GUARDAR(string nombre, int ID_categoria, int id_unidadMedida)
        {
            DProducto p = new DProducto();

            return p.SP_AgregarProducto(nombre, ID_categoria, id_unidadMedida);
        }

        public static int EDITAR(int id_producto, string nombre, int ID_categoria, int id_unidadMedida)
        {
            DProducto p = new DProducto();

            return p.SP_editarProducto(id_producto, nombre, ID_categoria, id_unidadMedida);

        }

        public static int ELIMINAR(int id_producto)
        {
            DProducto p = new DProducto();
            return p.SP_eliminarProducto(id_producto);
        }

        public static int CODIGO()
        {
            DProducto p = new DProducto();
            return p.SP_IDProducto();
        }

        public static DataTable LISTARCOMBO()
        {
            DProducto p = new DProducto();

            return p.SP_ListarComboProducto();
        }

        public static DataTable LISTAR(string nombre = "")
        {
            DProducto p = new DProducto();
            return p.SP_ListarProducto(nombre);
        }
    }
}
