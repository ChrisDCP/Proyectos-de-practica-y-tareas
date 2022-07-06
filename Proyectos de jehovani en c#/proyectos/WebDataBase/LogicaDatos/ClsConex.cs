using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace LogicaDatos
{
    public class ClsConex
    {
        private DataTable Table=new DataTable();
        public string informe(DateTime f1, DateTime f2)
        {
            SqlConnection enlace = new SqlConnection("Data Source = DESKTOP - STU0KED\\SQLEXPRESS; Initial Catalog = Northwind; Integrated Security = True");
            SqlCommand cmd = new SqlCommand("Sales by Year", enlace);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Beginning_Date", f1);
            cmd.Parameters.AddWithValue("@Ending_Date", f2);
            
           
            
          

            try
            {
                enlace.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ta = new DataSet();
                da.Fill(ta);
                Table = ta.Tables[0];
                string resultado = "";
                for (int i = 0; i < Table.Rows.Count; i++)
                {
                    Array t2 = Table.Rows[i].ItemArray;
                    for (int a = 0; a < t2.Length; a++)
                    {
                        resultado += t2.GetValue(a).ToString() + ",";
                    }
                    resultado += "|";
                }
               return resultado;

            }
            catch (Exception e )
            {

               throw e;
            }

        }
        public void guardar(string name,int phone)
        {
            SqlConnection enlace = new SqlConnection("Data Source=DESKTOP-STU0KED\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("SP_GuardarShipper", enlace);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CompanyName", name);
            cmd.Parameters.AddWithValue("@Phone", phone);
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
    }
 
}
