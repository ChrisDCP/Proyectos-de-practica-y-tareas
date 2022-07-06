using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class DAbono
    {
        SqlConnection conexion = new SqlConnection("Data Source =.\\SQLEXPRESS;Initial Catalog=SistemaVenta;Integrated Security=true");


        public int SP_AgregarAbono(float abono, DateTime FechaAbono, int ID_Credito)
        {
            SqlCommand Cmd = new SqlCommand("SP_AgregarAbono", conexion);
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@CantidadAbono", abono);
            Cmd.Parameters.AddWithValue("@FechaAbono", FechaAbono);
            Cmd.Parameters.AddWithValue("@ID_Credito", ID_Credito);


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

        public DataTable SP_ListarAbonoVenta(int id_credito)
        {
            SqlCommand cmd = new SqlCommand("SP_ListarAbonoVenta", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_Credito", id_credito);

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
