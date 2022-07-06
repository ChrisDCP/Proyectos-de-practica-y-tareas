using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaNegocio
{
    public class NCompra
    {
        public static int GUARDAR(int id_proveedor, DateTime fecha, float total)
        {
            DCompra c = new DCompra();

            return c.SP_AgregarCompra(id_proveedor, fecha, total);
        }

        public static int CODIGO()
        {
            DCompra c = new DCompra();

            return c.SP_IDCompra();
        }

        public static DataTable LISTAR(int id_compra)
        {
            DCompra c = new DCompra();
            return c.SP_ListarCompra(id_compra);
        }
    }
}
