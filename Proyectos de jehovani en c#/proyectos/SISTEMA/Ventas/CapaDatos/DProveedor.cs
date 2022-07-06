using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class DProveedor
    {
        SqlConnection conexion = new SqlConnection("Data Source =.\\SQLEXPRESS;Initial Catalog=SistemaVenta;Integrated Security=true");

        public int SP_GuardarProveedor(string Num_Ruc, string Nombre_Compañia, string Primer_Nombre, string Segundo_Nombre, string Primer_Apellido, string Segundo_Apellido, string Telefono, string Correo_Electronico, string Direccion)
        {
            SqlCommand Cmd = new SqlCommand("SP_GuardarProveedor", conexion);
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@Num_Ruc", Num_Ruc);
            Cmd.Parameters.AddWithValue("@Primer_Nombre", Primer_Nombre);
            Cmd.Parameters.AddWithValue("@Segundo_Nombre", Segundo_Nombre);
            Cmd.Parameters.AddWithValue("@Primer_Apellido", Primer_Apellido);
            Cmd.Parameters.AddWithValue("@Segundo_Apellido", Segundo_Apellido);
            Cmd.Parameters.AddWithValue("@Telefono", Telefono);
            Cmd.Parameters.AddWithValue("@Direccion", Direccion);
            Cmd.Parameters.AddWithValue("@Correo_Electronico", Correo_Electronico);
            Cmd.Parameters.AddWithValue("@Nombre_Compañia", Nombre_Compañia);

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

        public int SP_editarProveedor(int ID_Proveedor, string Num_Ruc, string Nombre_Compañia, string Primer_Nombre, string Segundo_Nombre, string Primer_Apellido, string Segundo_Apellido, string Telefono, string Correo_Electronico, string Direccion)
        {
            SqlCommand Cmd = new SqlCommand("SP_editarProveedor", conexion);
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@ID_Proveedor",ID_Proveedor);
            Cmd.Parameters.AddWithValue("@Num_Ruc", Num_Ruc);
            Cmd.Parameters.AddWithValue("@Primer_Nombre", Primer_Nombre);
            Cmd.Parameters.AddWithValue("@Segundo_Nombre", Segundo_Nombre);
            Cmd.Parameters.AddWithValue("@Primer_Apellido", Primer_Apellido);
            Cmd.Parameters.AddWithValue("@Segundo_Apellido", Segundo_Apellido);
            Cmd.Parameters.AddWithValue("@Telefono", Telefono);
            Cmd.Parameters.AddWithValue("@Direccion", Direccion);
            Cmd.Parameters.AddWithValue("@Correo_Electronico", Correo_Electronico);
            Cmd.Parameters.AddWithValue("@Nombre_Compañia", Nombre_Compañia);

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

        public int SP_eliminarProveedor(int id_proveedor)
        {
            SqlCommand Cmd = new SqlCommand("SP_eliminarProveedor", conexion);
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@ID_Proveedor", id_proveedor);


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

        public int SP_IDProveedor()
        {
            int id = 0;
            SqlCommand cmd = new SqlCommand("SP_IDProveedor", conexion);
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

        public DataTable SP_ListarComboProveedor()
        {
            SqlCommand cmd = new SqlCommand("SP_ListarComboProveedor", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

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

        public DataTable SP_ListarProveedor(string compania)
        {
            SqlCommand cmd = new SqlCommand("SP_ListarProveedor", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre_Compania", compania.Trim());

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
