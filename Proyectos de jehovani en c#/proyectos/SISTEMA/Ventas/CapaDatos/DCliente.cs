using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class DCliente
    {

        SqlConnection conexion = new SqlConnection("Data Source =.\\SQLEXPRESS;Initial Catalog=SistemaVenta;Integrated Security=true");

        public int SP_GuardarCliente(string Cedula,string Primer_Nombre, string Segundo_Nombre, string Primer_Apellido, string Segundo_Apellido, string Telefono, string Direccion)
        {
            SqlCommand Cmd = new SqlCommand("SP_GuardarCliente", conexion);
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@Cedula", Cedula);
            Cmd.Parameters.AddWithValue("@Primer_Nombre", Primer_Nombre);
            Cmd.Parameters.AddWithValue("@Segundo_Nombre", Segundo_Nombre);
            Cmd.Parameters.AddWithValue("@Primer_Apellido", Primer_Apellido);
            Cmd.Parameters.AddWithValue("@Segundo_Apellido", Segundo_Apellido);
            Cmd.Parameters.AddWithValue("@Telefono ", Telefono);
            Cmd.Parameters.AddWithValue("@Direccion", Direccion);
        
            try
            {
                conexion.Open();
                Cmd.ExecuteNonQuery();
                return 1;
            }
            catch(Exception ex)
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

        public int SP_EditarCliente(int id_cliente, string Cedula, string Primer_Nombre, string Segundo_Nombre, string Primer_Apellido, string Segundo_Apellido, string Telefono, string Direccion)
        {
            SqlCommand Cmd = new SqlCommand("SP_EditarCliente", conexion);
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@ID_Cliente",id_cliente);
            Cmd.Parameters.AddWithValue("@Cedula", Cedula);
            Cmd.Parameters.AddWithValue("@Primer_Nombre", Primer_Nombre);
            Cmd.Parameters.AddWithValue("@Segundo_Nombre", Segundo_Nombre);
            Cmd.Parameters.AddWithValue("@Primer_Apellido", Primer_Apellido);
            Cmd.Parameters.AddWithValue("@Segundo_Apellido", Segundo_Apellido);
            Cmd.Parameters.AddWithValue("@Telefono ", Telefono);
            Cmd.Parameters.AddWithValue("@Direccion", Direccion);

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

        public int SP_eliminarClientes(int id_Cliente)
        {
            SqlCommand Cmd = new SqlCommand("SP_eliminarClientes", conexion);
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@ID_Cliente", id_Cliente);


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

        public int SP_IDClientes()
        {
            int id = 0;
            SqlCommand cmd = new SqlCommand("SP_IDCliente", conexion);
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

        public DataTable SP_ListarComboClientes()
        {
            SqlCommand cmd = new SqlCommand("SP_ListarComboClientes", conexion);
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

        public DataTable SP_ListarClientes(string texto, int tipo)
        {
            SqlCommand cmd = new SqlCommand("SP_ListarClientes", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@texto", texto.Trim());
            cmd.Parameters.AddWithValue("@tipo", tipo);

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
