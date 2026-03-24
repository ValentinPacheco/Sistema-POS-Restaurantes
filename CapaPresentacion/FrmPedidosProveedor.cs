using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmPedidoProveedor : Form
    {
        CN_Proveedores prov = new CN_Proveedores();
        CNProductos prod = new CNProductos(); // asegúrate de tener esto
        CN_PedidosProveedor pedido = new CN_PedidosProveedor();

        private void CargarPedidos()
        {
            dgvPedidos.DataSource = pedido.MostrarPedidos();
        }

        public FrmPedidoProveedor()
        {
            InitializeComponent();
            this.Load += FrmPedidoProveedor_Load;
        }

        private void FrmPedidoProveedor_Load(object sender, EventArgs e)
        {
            // 🔹 Cargar proveedores
            cbProveedor.DataSource = prov.MostrarProveedores();
            cbProveedor.DisplayMember = "nombre";
            cbProveedor.ValueMember = "id_proveedor";

            // 🔹 Cargar productos
            cbProducto.DataSource = prod.ListarProductos(); // usa tu método existente
            cbProducto.DisplayMember = "nombre";
            cbProducto.ValueMember = "id_producto";

            // 🔥 cargar historial
            CargarPedidos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idProveedor = Convert.ToInt32(cbProveedor.SelectedValue);
            int idProducto = Convert.ToInt32(cbProducto.SelectedValue);
            int cantidad = (int)numCantidad.Value;

            if (cantidad <= 0)
            {
                MessageBox.Show("Cantidad inválida");
                return;
            }

            pedido.CrearPedido(idProveedor, idProducto, cantidad);

            MessageBox.Show("Pedido realizado correctamente");

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
