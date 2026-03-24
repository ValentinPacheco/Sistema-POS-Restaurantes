using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Proveedores
    {
        CD_Proveedores obj = new CD_Proveedores();

        public DataTable MostrarProveedores()
        {
            return obj.ListarProveedores();
        }
        public void AgregarProveedor(string nombre, string telefono)
        {
            obj.InsertarProveedor(nombre, telefono);
        }

        public void EditarProveedor(int id, string nombre, string telefono)
        {
            obj.EditarProveedor(id, nombre, telefono);
        }

        public void EliminarProveedor(int id)
        {
            obj.EliminarProveedor(id);
        }

        public DataTable BuscarProveedor(string texto)
        {
            return obj.BuscarProveedor(texto);
        }
    }
}