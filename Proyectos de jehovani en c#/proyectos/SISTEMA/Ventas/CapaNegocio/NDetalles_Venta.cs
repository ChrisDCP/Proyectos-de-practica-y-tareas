using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaNegocio
{
    public class NDetalles_Venta
    {
        public static int GUARDAR(float cantidad, float precio, int id_venta, int id_producto, float subtotal)
        {
            DDetalle_Venta d = new DDetalle_Venta();

            return d.SP_AgregarDetalleVenta(cantidad, precio, id_venta, id_producto, subtotal);
        }

        public static DataTable LISTAR(int id_venta)
        {
            DDetalle_Venta d = new DDetalle_Venta();

            return d.SP_ListarDetalleVenta(id_venta);
        }
    }
}
