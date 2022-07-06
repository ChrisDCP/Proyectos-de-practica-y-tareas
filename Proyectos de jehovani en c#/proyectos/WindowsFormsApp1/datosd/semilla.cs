using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace datosd
{
    class semilla
    {
        SqlConnection conexion = new SqlConnection("Data Source=FAREM-B4-26-PC;Initial Catalog=SISGA2;Integrated Security=True");

        public void sp_guardarsemilla(string Nombre,DateTime Caducidad)
        {
            SqlCommand Cmd = new SqlCommand("sp_guardarsemilla", conexion);
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@Nombre", Nombre);
            Cmd.Parameters.AddWithValue("@Caducidad",Caducidad);
            
           


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

        public string sp_actualizarsemillas(int IDsemilla, string Nombre,DateTime Caducidad)
        {
            SqlCommand Cmd = new SqlCommand("sp_actualizarsemillas", conexion);
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@IDsemilla", IDsemilla);
            Cmd.Parameters.AddWithValue("@Nombre", Nombre);
            Cmd.Parameters.AddWithValue("@Caducidad", Caducidad);
            

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

        public string sp_eliminarsemilla(int IDsemilla)
        {
            SqlCommand Cmd = new SqlCommand("sp_eliminarsemilla", conexion);
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@IDsemilla", IDsemilla);



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

        public DataTable sp_buscarsemilla(string Nombre)
        {
            SqlCommand Cmd = new SqlCommand("sp_buscarsemilla", conexion);
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@Nombre", Nombre);

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

        public DataTable sp_llenarsemilla()
        {
            SqlCommand Cmd = new SqlCommand("sp_llenarsemila", conexion);
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
