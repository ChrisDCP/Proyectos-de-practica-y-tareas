using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace datosd
{
    class producto
    {
        SqlConnection conexion = new SqlConnection("Data Source=FAREM-B4-26-PC;Initial Catalog=SISGA2;Integrated Security=True");

        public void sp_guardarproducto(double Precio,float Peso,string Nombre)
        {
            SqlCommand Cmd = new SqlCommand("sp_guardarproducto", conexion);
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@Precio", Precio);
            Cmd.Parameters.AddWithValue("@Peso ", Peso);
            Cmd.Parameters.AddWithValue("@Nombre", Nombre);
          
          
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
        
        public string sp_actualizarproducto(double Precio, float Peso, string Nombre)
        {
            SqlCommand Cmd = new SqlCommand("sp_actualizarproducto", conexion);
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@Precio", Precio);
            Cmd.Parameters.AddWithValue("@Peso", Peso);
            Cmd.Parameters.AddWithValue("@Nombre", Nombre);


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

        public string sp_eliminarproducto(int IDproducto)
        {
            SqlCommand Cmd = new SqlCommand("sp_eliminarproducto", conexion);
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.Parameters.AddWithValue("@IDproducto", IDproducto);



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

        public DataTable sp_buscarproducto(string Nombre)
        {
            SqlCommand Cmd = new SqlCommand("sp_buscarproducto", conexion);
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

        public DataTable sp_llenarproduto()
        {
            SqlCommand Cmd = new SqlCommand("sp_llenarproducto", conexion);
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

