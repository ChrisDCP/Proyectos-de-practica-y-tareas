using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class DProducto
    {
        SqlConnection conexion = new SqlConnection("Data Source =.\\SQLEXPRESS;Initial Catalog=SistemaVenta;Integrated Security=true");
        public int SP_AgregarProducto(string nombre, int ID_categoria, int id_unidadMedida)
        {

            SqlCommand Cmd = new SqlCommand("SP_AgregarProducto", conexion);
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@Nombre", nombre);
            Cmd.Parameters.AddWithValue("@ID_categoria", ID_categoria);
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

        public int SP_editarProducto(int id_producto, string nombre, int id_categoria, int id_unidadMedida)
        {
            SqlCommand cmd = new SqlCommand("SP_editarProducto", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_producto", id_producto);
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@ID_categoria", id_categoria);
            cmd.Parameters.AddWithValue("@id_unidadMedida", id_unidadMedida);


            try
            {
                conexion.Open();
                cmd.ExecuteNonQuery();

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
                cmd.Dispose();
            }
        }

        public int SP_eliminarProducto(int idproducto)
        {
            SqlCommand cmd = new SqlCommand("SP_eliminarProducto", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ID_producto", idproducto);

            try
            {
                conexion.Open();
                cmd.ExecuteNonQuery();

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
                cmd.Dispose();
            }
        }

        public DataTable SP_ListarComboProducto()
        {
            SqlCommand cmd = new SqlCommand("SP_ListarComboProducto", conexion);
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

        public DataTable SP_ListarProducto(string nombre)
        {
            SqlCommand cmd = new SqlCommand("SP_ListarProducto", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Nombre", nombre);

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

        public int SP_IDProducto()
        {
            int id = 0;
            SqlCommand cmd = new SqlCommand("SP_IDProducto", conexion);
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
    }
}
