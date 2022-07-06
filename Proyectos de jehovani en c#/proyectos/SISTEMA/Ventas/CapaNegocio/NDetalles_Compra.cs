using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaNegocio
{
    public class NDetalles_Compra
    {
        public static int GUARDAR(float precio, float cantidad, float subtotal, int id_compra, int id_producto)
        {
            DDetalle_Compra d = new DDetalle_Compra();

            return d.SP_AgregarDetalleCompra(precio, cantidad,subtotal, id_compra, id_producto);
        }

        public static DataTable LISTAR(int id_compra)
        {
            DDetalle_Compra d = new DDetalle_Compra();

            return d.SP_ListarDetalleCompra(id_compra);
        }
    }
}
