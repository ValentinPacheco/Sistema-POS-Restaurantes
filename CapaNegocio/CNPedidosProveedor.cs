using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_PedidosProveedor
    {
        CD_PedidosProveedor obj = new CD_PedidosProveedor();

        public void CrearPedido(int idProveedor, int idProducto, int cantidad)
        {
            obj.InsertarPedido(idProveedor, idProducto, cantidad);
        }

        public DataTable MostrarPedidos()
        {
            return obj.ListarPedidos();
        }
    }
}
