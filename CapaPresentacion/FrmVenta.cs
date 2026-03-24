using CapaNegocio;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmVentas : Form
    {
        int idPedidoActual;
        int idUsuario = 1; // TODO: traer del login
        int idMesa = 1;    // TODO: seleccionar mesa

        CNVenta nVenta = new CNVenta();

        public FrmVentas()
        {
            InitializeComponent();
            this.Load += FrmVentas_Load;
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            ConfigurarGrid();
            CrearPedido();
            CargarProductos();
        }

        // =============================
        // 🔹 CREAR PEDIDO
        // =============================
        private void CrearPedido()
        {
            idPedidoActual = nVenta.CrearPedido(idUsuario, idMesa);
        }

        // =============================
        // 🔹 CARGAR PRODUCTOS (SIN SQL)
        // =============================
        private void CargarProductos()
        {
            cbProductos.DataSource = nVenta.ListarProductos();
            cbProductos.DisplayMember = "nombre";
            cbProductos.ValueMember = "id_producto";
        }

        // =============================
        // 🔹 CONFIGURAR GRID
        // =============================
        private void ConfigurarGrid()
        {
            dgvDetalle.Columns.Clear();

            dgvDetalle.Columns.Add("id_producto", "ID");
            dgvDetalle.Columns.Add("nombre", "Producto");
            dgvDetalle.Columns.Add("cantidad", "Cantidad");
            dgvDetalle.Columns.Add("precio", "Precio");
            dgvDetalle.Columns.Add("subtotal", "Subtotal");

            dgvDetalle.Columns["id_producto"].Visible = false;
        }

        // =============================
        // 🔹 AGREGAR PRODUCTO
        // =============================
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cbProductos.SelectedIndex == -1) return;

            int idProducto = Convert.ToInt32(cbProductos.SelectedValue);
            string nombre = cbProductos.Text;
            int cantidad = (int)numCantidad.Value;

            // 🔥 ahora viene de negocio, no de SQL directo
            decimal precio = nVenta.ObtenerPrecio(idProducto);

            // 🔥 Evitar duplicados
            foreach (DataGridViewRow row in dgvDetalle.Rows)
            {
                if (row.IsNewRow) continue;

                if (Convert.ToInt32(row.Cells["id_producto"].Value) == idProducto)
                {
                    int cantActual = Convert.ToInt32(row.Cells["cantidad"].Value);
                    cantActual += cantidad;

                    row.Cells["cantidad"].Value = cantActual;
                    row.Cells["subtotal"].Value = cantActual * precio;

                    CalcularTotal();
                    return;
                }
            }

            decimal subtotal = cantidad * precio;

            dgvDetalle.Rows.Add(idProducto, nombre, cantidad, precio, subtotal);

            CalcularTotal();
        }

        // =============================
        // 🔹 CALCULAR TOTAL
        // =============================
        private void CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvDetalle.Rows)
            {
                if (row.IsNewRow) continue;

                total += Convert.ToDecimal(row.Cells["subtotal"].Value);
            }

            lblTotal.Text = "Total: $" + total.ToString("0.00");
        }

        // =============================
        // 🔹 CONFIRMAR VENTA
        // =============================
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.Rows.Count <= 1)
            {
                MessageBox.Show("Agrega al menos un producto");
                return;
            }

            try
            {
                foreach (DataGridViewRow row in dgvDetalle.Rows)
                {
                    if (row.IsNewRow) continue;

                    nVenta.AgregarDetalle(
                        idPedidoActual,
                        Convert.ToInt32(row.Cells["id_producto"].Value),
                        Convert.ToInt32(row.Cells["cantidad"].Value),
                        Convert.ToDecimal(row.Cells["precio"].Value)
                    );
                }

                nVenta.ConfirmarVenta(idPedidoActual);

                MessageBox.Show("Venta registrada correctamente");

                // 🔄 Reset
                dgvDetalle.Rows.Clear();
                lblTotal.Text = "Total: $0.00";

                CrearPedido(); // nuevo pedido
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar venta: " + ex.Message);
            }
        }

        // =============================
        // 🔹 ELIMINAR PRODUCTO
        // =============================
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.CurrentRow != null)
            {
                dgvDetalle.Rows.Remove(dgvDetalle.CurrentRow);
                CalcularTotal();
            }
        }

        private void btnFaltante_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un producto");
                return;
            }

            int idProducto = Convert.ToInt32(dgvDetalle.CurrentRow.Cells["id_producto"].Value);

            CN_Faltantes obj = new CN_Faltantes();
            obj.AgregarFaltante(idProducto);

            MessageBox.Show("Producto marcado como faltante");
        }
    }
}