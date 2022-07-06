using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaNegocio
{
    public class NInventario
    {
        public static int EDITAR(int id_producto,float precio_compra, float porc_venta)
        {
            DInventario i = new DInventario();

            return i.SP_EditarInventario(id_producto,precio_compra, porc_venta);
        }

        public static DataTable MOSTRAR_EXISTENCIA_PRECIO(int id_producto)
        {
            DInventario i = new DInventario();

            return i.SP_MostrarExistenciaPrecio(id_producto);
        }

        public static DataTable ListarInventario(string producto)
        {
            DInventario i = new DInventario();

            return i.SP_ListarProductoInventario(producto);
        }

        public static DataTable Informe()
        {
            DInventario i = new DInventario();
            return i.SP_InformeInventario();
        }
    }
}
