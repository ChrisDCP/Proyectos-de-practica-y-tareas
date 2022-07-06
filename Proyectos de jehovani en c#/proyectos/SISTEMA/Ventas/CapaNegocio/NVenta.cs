using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaNegocio
{
    public class NVenta
    {
        public static int GUARDAR(bool credito, int ID_cliente, DateTime fecha, float total)
        {
            DVenta v = new DVenta();

            return v.SP_AgregarVenta(credito, ID_cliente, fecha, total);
        }

        public static int CODIGO()
        {
            DVenta v = new DVenta();

            return v.SP_IDVentas();
        }

        public static DataTable LISTAR(int id_venta)
        {
            DVenta v = new DVenta();
            return v.SP_ListarVenta(id_venta);
        }
    }
}
