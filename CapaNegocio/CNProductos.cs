using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CNProductos
    {
        CDProductos objDatos = new CDProductos();

        public DataTable ListarProductos()
        {
            return objDatos.Listar();
        }

        public DataTable BuscarProductos(string nombre)
        {
            return objDatos.Buscar(nombre);
        }

        public void InsertarProducto(string nombre, decimal precio, int id_categoria, bool activo)
        {
            objDatos.Insertar(nombre, precio, id_categoria, activo);
        }

        public void EditarProducto(int id_producto, string nombre, decimal precio, int id_categoria, bool activo)
        {
            objDatos.Editar(id_producto, nombre, precio, id_categoria, activo);
        }

        public void EliminarProducto(int id_producto)
        {
            objDatos.Eliminar(id_producto);
        }
    }
}
