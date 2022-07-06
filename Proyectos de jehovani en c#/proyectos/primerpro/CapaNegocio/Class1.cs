using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDato;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegocio
{
    public class Capanegocio
    {
        public static string guardarcategoria(string categoryname, string description)
        {
            string r;
            try
            {
                Capadato dato = new Capadato();
                dato.guardarcategoria(categoryname, description);
                r = "se guardo exisotosamente";
                return r;
            }
            catch (Exception e)
            {

                r = e.ToString();
                return r;
            }
        }
        public static DataTable llenarcategoria(int categoryID)
        {
            DataTable data2 = new DataTable();
            Capadato cat = new Capadato();
            data2 = cat.llenarcategorias(categoryID);
            return data2;
        }
        public static String actualizarcategoria(int idcategoria, string categoryname, string description)
        {
            string r;
            string s = "0";
            try
            {
                Capadato datos = new Capadato();
                r = datos.actualizarcategoria(idcategoria, categoryname, description);
                s = "esta actualizado" + Convert.ToString(r) + " insercion a sido exitosa";
                return s;
            }
            catch
            {


                return s;
            }
        }
    }
}
