using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace datosd
{
    class proveedor
    {
        SqlConnection conexion = new SqlConnection("Data Source=FAREM-B4-26-PC;Initial Catalog=SISGA2;Integrated Security=True");

        public void sp_guardarproveedor( string Nombre, int Telefono, string Direccion,string  Descripcion,string  Correo)
        {
            SqlCommand Cmd = new SqlCommand("sp_guardarproveedor", conexion);
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@Nombre", Nombre);
            Cmd.Parameters.AddWithValue("@Telefono", Telefono);
            Cmd.Parameters.AddWithValue("@Direccion ",Direccion);
            Cmd.Parameters.AddWithValue("@Descripcion ", Descripcion);
            Cmd.Parameters.AddWithValue("@Correo", Correo);

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
       
        public string sp_actualizarproveedor(string Nombre, int Telefono, string Direccion, string Descripcion, string Correo)
        {
            SqlCommand Cmd = new SqlCommand("sp_actualizarproveedor", conexion);
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@Nombre", Nombre);
            Cmd.Parameters.AddWithValue("@Telefono", Telefono);
            Cmd.Parameters.AddWithValue("@Direccion", Direccion);
            Cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
            Cmd.Parameters.AddWithValue("@Correo", Correo);


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

        public string sp_eliminarproveedor(int IDproveedor)
        {
            SqlCommand Cmd = new SqlCommand("sp_eliminarproveedor", conexion);
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@IDproveedor", IDproveedor);



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

        public DataTable sp_buscarproveedor(string Nombre)
        {
            SqlCommand Cmd = new SqlCommand("sp_buscarproveedor", conexion);
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

        public DataTable sp_llenarproveedor()
        {
            SqlCommand Cmd = new SqlCommand("sp_llenarproveeedor", conexion);
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

