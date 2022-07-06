using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class DDetalle_Compra
    {
        SqlConnection conexion = new SqlConnection("Data Source =.\\SQLEXPRESS;Initial Catalog=SistemaVenta;Integrated Security=true");
        public int SP_AgregarDetalleCompra(float precio, float cantidad,float subtotal, int id_compra, int id_producto)
        {
            SqlCommand Cmd = new SqlCommand("SP_AgregarDetalleCompra", conexion);
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@precio", precio);
            Cmd.Parameters.AddWithValue("@Cantidad", cantidad);
            Cmd.Parameters.AddWithValue("@subtotal", subtotal);
            Cmd.Parameters.AddWithValue("@ID_Compra", id_compra);
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


        public DataTable SP_ListarDetalleCompra(int id_compra)
        {
            SqlCommand cmd = new SqlCommand("SP_ListarDetalleCompra", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_compra", id_compra);

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
