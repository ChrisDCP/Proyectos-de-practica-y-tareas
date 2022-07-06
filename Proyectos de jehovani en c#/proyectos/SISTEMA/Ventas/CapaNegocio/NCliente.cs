using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaNegocio
{
    public class NCliente
    {
        public static int GUARDAR(string Cedula,string Primer_Nombre, string Segundo_Nombre, string Primer_Apellido, string Segundo_Apellido, string Telefono, string Direccion)
        {
            DCliente c = new DCliente();

            return c.SP_GuardarCliente(Cedula, Primer_Nombre, Segundo_Nombre, Primer_Apellido, Segundo_Apellido, Telefono, Direccion);

        }

        public static int EDITAR(int id_clientes,string Cedula,string Primer_Nombre, string Segundo_Nombre, string Primer_Apellido, string Segundo_Apellido, string Telefono, string Direccion)
        {
            DCliente c = new DCliente();

            return c.SP_EditarCliente(id_clientes,Cedula, Primer_Nombre, Segundo_Nombre, Primer_Apellido, Segundo_Apellido, Telefono, Direccion);
        }

        public static int ELIMINAR(int id_clientes)
        {
            DCliente c = new DCliente();

            return c.SP_eliminarClientes(id_clientes);
        }

        public static int CODIGO()
        {
            DCliente c = new DCliente();

            return c.SP_IDClientes();
        }

        public static DataTable LISTARCOMBO()
        {
            DCliente c = new DCliente();

            return c.SP_ListarComboClientes();
        }

        public static DataTable LISTAR(string texto = "", int tipo = 1)
        {
            DCliente c = new DCliente();

            return c.SP_ListarClientes(texto, tipo);
        }
    }
}
