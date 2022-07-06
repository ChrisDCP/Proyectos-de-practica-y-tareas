using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class DVenta
    {
        SqlConnection conexion = new SqlConnection("Data Source =.\\SQLEXPRESS;Initial Catalog=SistemaVenta;Integrated Security=true");

        public int SP_AgregarVenta(bool credito, int ID_cliente, DateTime fecha, float total)
        {
            SqlCommand Cmd = new SqlCommand("SP_AgregarVenta", conexion);
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@Credito", credito);
            Cmd.Parameters.AddWithValue("@ID_Cliente", ID_cliente);
            Cmd.Parameters.AddWithValue("@FechaVenta", fecha);
            Cmd.Parameters.AddWithValue("@Total", total);
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
        
        public int SP_IDVentas()
        {
            int id = 0;
            SqlCommand cmd = new SqlCommand("SP_IDVentas", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                conexion.Open();
                SqlDataReader r = cmd.ExecuteReader();

                while (r.Read())
                    id = r.GetInt32(0);

                return id + 1;
            }
            catch (Exception ex)
            {
                return 0;
                throw new Exception(ex.Message);
            }
            finally
            {
                conexion.Dispose();
                cmd.Dispose();
            }
        }

        public DataTable SP_ListarVenta(int id_venta)
        {

            SqlCommand cmd = new SqlCommand("SP_ListarVenta", conexion);
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
