using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaNegocio
{
    public class NAbono
    {

        public static int GUARDAR(float abono, DateTime FechaAbono, int ID_Credito)
        {
            DAbono a = new DAbono();

            return a.SP_AgregarAbono(abono, FechaAbono, ID_Credito);
        }

        public static DataTable ListarAbono(int id_credito)
        {
            DAbono a = new DAbono();

            return a.SP_ListarAbonoVenta(id_credito);
        }
    }
}
