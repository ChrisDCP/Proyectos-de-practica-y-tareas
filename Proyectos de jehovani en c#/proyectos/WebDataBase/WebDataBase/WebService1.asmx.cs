using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using LogicaDatos;

namespace WebDataBase
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod]
        public string info(DateTime n1, DateTime n2)
        {
            string r = "";
            ClsConex est = new ClsConex();
            r = est.informe(n1,n2);
            
            return r;
        }
        [WebMethod]
        public void guardar(string n,int p)
        {
           // string r;
            ClsConex dato = new ClsConex();
            dato.guardar(n, p);
          //  r = "se guardo exitosamente";

        }
    }
}
