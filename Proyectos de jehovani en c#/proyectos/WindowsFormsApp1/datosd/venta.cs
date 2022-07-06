using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace datosd
{
    class venta
    {
        SqlConnection conexion = new SqlConnection("Data Source=FAREM-B4-26-PC;Initial Catalog=SISGA2;Integrated Security=True");

        public void sp_guardarventa( DateTime Fecha)
        {
            SqlCommand Cmd = new SqlCommand("sp_guardarventa", conexion);
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@Fecha", Fecha);




            try
            {
                conexion.Open();
                Cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally
            {
                conexion.Dispose();
                Cmd.Dispose();
            }
        }

        public string sp_actualizarventa(int IDventa, DateTime Fecha)
        {
            SqlCommand Cmd = new SqlCommand("sp_actualizarventa", conexion);
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@IDventa", IDventa);
            Cmd.Parameters.AddWithValue("@Fecha", Fecha);


            try
            {
                conexion.Open();
                Cmd.ExecuteNonQuery();
                return "1";
            }
            catch (Exception ex)
            {
                return "0";
                throw new Exception(ex.Message);
            }
            finally
            {
                conexion.Dispose();
                Cmd.Dispose();
            }
        }

        public string sp_eliminarventa(int IDventa)
        {
            SqlCommand Cmd = new SqlCommand("sp_eliminarventa", conexion);
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@IDventa", IDventa);



            try
            {
                conexion.Open();
                Cmd.ExecuteNonQuery();
                string r = "0";
                return r;
            }
            catch (Exception ex)
            {
                string r = "0";
                return r;
                throw new Exception(ex.Message);
            }
            finally
            {
                conexion.Dispose();
                Cmd.Dispose();
            }
        }

      

        public DataTable sp_llenarventa()
        {
            SqlCommand Cmd = new SqlCommand("sp_llenarventa", conexion);
            Cmd.CommandType = CommandType.StoredProcedure;


            try
            {
                conexion.Open();

                SqlDataAdapter ap = new SqlDataAdapter(Cmd);
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
                Cmd.Dispose();

            }
        }
    }
}
