using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace datosd
{
   public class clsmaquiniaria
    {
        SqlConnection conexion = new SqlConnection("Data Source=FAREM-B4-26-PC;Initial Catalog=SISGA2;Integrated Security=True");

        public void sp_guardarmaquinaria(string Modelo, string Nombre, string Marca)
        {
            SqlCommand Cmd = new SqlCommand("sp_guardarmaquinaria", conexion);
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@Modelo", Modelo);
            Cmd.Parameters.AddWithValue("@Nombre", Nombre);
            Cmd.Parameters.AddWithValue("@Marca", Marca);

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


        public string sp_actualizarmaquinaria(int IDmaquinaria, string Modelo, string Nombre, string Marca)
        {
            SqlCommand Cmd = new SqlCommand("sp_actualizarmaquinaria", conexion);
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@IDmaquinaria", IDmaquinaria);
            Cmd.Parameters.AddWithValue("@Modelo", Modelo);
            Cmd.Parameters.AddWithValue("@Nombre", Nombre);
            Cmd.Parameters.AddWithValue("@Marca", Marca);


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

        public string sp_eliminarmaquinaria(int IDmaquinaria)
        {
            SqlCommand Cmd = new SqlCommand("sp_eliminarmaquinarias", conexion);
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@IDmaquinaria", IDmaquinaria);



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

        public DataTable sp_buscarmaquinaria(string Nombre)
        {
            SqlCommand Cmd = new SqlCommand("sp_buscarmaquinaria", conexion);
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

        public DataTable sp_llenarmaquinaria()
        {
            SqlCommand Cmd = new SqlCommand("sp_llenarmaquinaria", conexion);
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
