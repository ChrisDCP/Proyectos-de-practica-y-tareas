using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDato
{
    public class Capadato
    {
        public void guardarcategoria(string categoryname, string description)
        {
            SqlConnection enlace = new SqlConnection("Data Source=DESKTOP-STU0KED\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("sp_guardar", enlace);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Categoryname", categoryname);
            cmd.Parameters.AddWithValue("@Description", description);
            try
            {
                enlace.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                Console.WriteLine("ocurrio un error" + e.ToString());
            }
            finally
            {
                enlace.Dispose();
                cmd.Dispose();
            }
        }
        public DataTable llenarcategorias(int categoryID)
        {
            SqlConnection enlace = new SqlConnection("Data Source=DESKTOP-STU0KED\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("sp_llenarDatosCat", enlace);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@categoryid", categoryID);
            try
            {
                SqlDataAdapter sada = new SqlDataAdapter(cmd);
                DataTable dat = new DataTable();
                sada.Fill(dat);
                return dat;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
            finally
            {
                enlace.Dispose();
                cmd.Dispose();
            }

        }
        public String actualizarcategoria(int idcategoria, string categoryname, string description)
        {
            SqlConnection enlace = new SqlConnection("Data Source=DESKTOP-STU0KED\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("sp_update", enlace);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@categoryid", idcategoria);
            cmd.Parameters.AddWithValue("@categoryname", categoryname);
            cmd.Parameters.AddWithValue("@description", description);
            try
            {
                enlace.Open();
                cmd.ExecuteNonQuery();
                String r = "0";
                return r;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);

            }
            finally
            {
                enlace.Dispose();
                cmd.Dispose();
            }


        }
    }
}
