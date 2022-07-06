using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class DUnidadMedida
    {
        SqlConnection conexion = new SqlConnection("Data Source =.\\SQLEXPRESS;Initial Catalog=SistemaVenta;Integrated Security=true");
        public int SP_AgregarUnidadMedida(string nombre)
        {

            SqlCommand Cmd = new SqlCommand("SP_AgregarUnidadMedida", conexion);
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@nombre", nombre);

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

        public int SP_EditarUnidadMedida(int id_unidadMedida, string nombre)
        {
            SqlCommand Cmd = new SqlCommand("SP_EditarUnidadMedida", conexion);
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@id_unidadMedida", id_unidadMedida);
            Cmd.Parameters.AddWithValue("@nombre", nombre);

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

        public int SP_EliminarUnidadMedida(int id_unidadMedida)
        {
            SqlCommand Cmd = new SqlCommand("SP_EliminarCategoria", conexion);
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@id_unidadMedida", id_unidadMedida);

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

        public int SP_IDUnidadMedida()
        {
            int id = 0;
            SqlCommand cmd = new SqlCommand("SP_IDUnidadMedida", conexion);
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

        public string SP_MostrarUnidadProducto(int id_producto)
        {
            SqlCommand cmd = new SqlCommand("SP_MostrarUnidadProducto", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_producto", id_producto);

            try
            {
                conexion.Open();
                SqlDataReader r = cmd.ExecuteReader();

                if (r.Read())
                    return r.GetString(0);
                else
                    return string.Empty;
            }
            catch(Exception ex)
            {
                return string.Empty;
                throw new Exception(ex.Message);
            }
            finally
            {
                conexion.Dispose();
                cmd.Dispose();
            }
        }

        public DataTable SP_ListarUnidadMedida(string nombre)
        {
            SqlCommand cmd = new SqlCommand("SP_ListarUnidadMedida", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", nombre.Trim());

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
