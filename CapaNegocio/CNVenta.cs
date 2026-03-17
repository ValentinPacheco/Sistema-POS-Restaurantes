using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNVenta
    {
        CDVenta dVenta = new CDVenta();

        public int CrearPedido(int idUsuario, int idMesa)
        {
            return dVenta.InsertarPedido(idUsuario, idMesa);
        }

        public void AgregarDetalle(int idPedido, int idProducto, int cantidad, decimal precio)
        {
            dVenta.InsertarDetalle(idPedido, idProducto, cantidad, precio);
        }

        public void ConfirmarVenta(int idPedido)
        {
            dVenta.ConfirmarPedido(idPedido);
        }
    }
}
