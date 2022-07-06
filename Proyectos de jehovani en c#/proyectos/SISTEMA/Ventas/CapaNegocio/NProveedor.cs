using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
namespace CapaNegocio
{
    public class NProveedor
    {
        public static int GUARDAR(string Num_Ruc,string Primer_Nombre, string Segundo_Nombre, string Primer_Apellido, string Segundo_Apellido, string Telefono, string Direccion, string Correo_Electronico,string Nombre_Compania)
        {
            DProveedor p = new DProveedor();

            return p.SP_GuardarProveedor(Num_Ruc, Primer_Nombre, Segundo_Nombre, Primer_Apellido, Segundo_Apellido, Telefono, Direccion, Correo_Electronico, Nombre_Compania);
        }

        public static int EDITAR(int id_proveedor, string Num_Ruc, string Primer_Nombre, string Segundo_Nombre, string Primer_Apellido, string Segundo_Apellido, string Telefono, string Direccion, string Correo_Electronico, string Nombre_Compania)
        {
            DProveedor p = new DProveedor();

            return p.SP_editarProveedor(id_proveedor,Num_Ruc, Primer_Nombre, Segundo_Nombre, Primer_Apellido, Segundo_Apellido, Telefono, Direccion, Correo_Electronico, Nombre_Compania);
        }

        public static int ELIMINAR(int id_proveedor)
        {
            DProveedor p = new DProveedor();

            return p.SP_eliminarProveedor(id_proveedor);
        }

        public static int CODIGO()
        {
            DProveedor p = new DProveedor();

            return p.SP_IDProveedor();
        }
        public static DataTable LISTAR_COMBO()
        {
            DProveedor p = new DProveedor();
           return p.SP_ListarComboProveedor();
        }
        public static DataTable LISTAR(string compania)
        {
            DProveedor p = new DProveedor();

            return p.SP_ListarProveedor(compania);
        }
    }
}
