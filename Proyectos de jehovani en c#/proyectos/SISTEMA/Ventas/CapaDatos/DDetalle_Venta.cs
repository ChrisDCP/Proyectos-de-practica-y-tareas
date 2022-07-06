using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class DDetalle_Venta
    {
        SqlConnection conexion = new SqlConnection("Data Source =.\\SQLEXPRESS;Initial Catalog=SistemaVenta;Integrated Security=true");
        public int SP_AgregarDetalleVenta(float cantidad, float precio, int id_venta, int id_producto, float subtotal)
        {
            SqlCommand Cmd = new SqlCommand("SP_AgregarDetalleVenta", conexion);
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@PrecioUnitario", precio);
            Cmd.Parameters.AddWithValue("@Cantidad", cantidad);
            Cmd.Parameters.AddWithValue("@subtotal", subtotal);
            Cmd.Parameters.AddWithValue("@ID_venta", id_venta);
            Cmd.Parameters.AddWithValue("@ID_Producto", id_producto);


            try
            {
                conexion.Open();
                Cmd.ExecuteNonQuery();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
                throw new Exception(ex.Message);
            }
            finally
            {
                conexion.Dispose();
                Cmd.Dispose();
            }
        }

        public DataTable SP_ListarDetalleVenta(int id_venta)
        {
            SqlCommand cmd = new SqlCommand("SP_ListarDetalleVenta", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_Venta", id_venta);

            try
            {
                conexion.Open();

                SqlDataAdapter ap = new SqlDataAdapter(cmd);
                DataTable tabla = new DataTable();
                ap.Fill(tabla);

                return tabla;
            }
            catch (Exception ex)
            {
                return null;
                throw new Exception(ex.Message);
            }
            finally
            {
                conexion.Dispose();
                cmd.Dispose();

            }
        }
    }
}
