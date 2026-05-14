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
    public partial class FrmProductos : Form
    {
        CNProductos objNegocio = new CNProductos();
        CNCategorias objCategorias = new CNCategorias();
        CN_Proveedores objProveedores = new CN_Proveedores();

        public FrmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            MostrarProductos();
            MostrarCategorias();
            MostrarProveedores();

        }
        private void MostrarProductos()
        {
            dgvProductos.DataSource = objNegocio.ListarProductos();
        }
        private void MostrarCategorias()
        {
            dgvCategorias.DataSource = objCategorias.ListarCategorias();
        }
        private void MostrarProveedores()
        {
            dgvProveedores.DataSource = objProveedores.ListarProveedores();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvProductos.DataSource = objNegocio.BuscarProductos(txtBuscar.Text);

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmProductoNuevo frm = new FrmProductoNuevo();
            frm.ShowDialog();
            MostrarProductos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                FrmProductoNuevo frm = new FrmProductoNuevo();

                frm.IdProducto = Convert.ToInt32(dgvProductos.CurrentRow.Cells["id_producto"].Value);
                frm.Nombre = dgvProductos.CurrentRow.Cells["nombre"].Value.ToString();
                frm.Precio = Convert.ToDecimal(dgvProductos.CurrentRow.Cells["precio"].Value);
                frm.IdCategoria = Convert.ToInt32(dgvProductos.CurrentRow.Cells["id_categoria"].Value);
                frm.Activo = Convert.ToBoolean(dgvProductos.CurrentRow.Cells["activo"].Value);

                frm.ShowDialog();
                MostrarProductos();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                int id = Convert.ToInt32(dgvProductos.CurrentRow.Cells["id_producto"].Value);

                objNegocio.EliminarProducto(id);
                MostrarProductos();
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dlistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmRegistrarCategorias frm = new FrmRegistrarCategorias();

            frm.ShowDialog();

            MostrarCategorias();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow != null)
            {
                FrmRegistrarCategorias frm = new FrmRegistrarCategorias();

                frm.IdCategoria = Convert.ToInt32(
                    dgvCategorias.CurrentRow.Cells["id_categoria"].Value
                );

                frm.Nombre = dgvCategorias.CurrentRow.Cells["nombre"].Value.ToString();

                frm.ShowDialog();

                MostrarCategorias();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow != null)
            {
                int id = Convert.ToInt32(
                    dgvCategorias.CurrentRow.Cells["id_categoria"].Value
                );

                objCategorias.Eliminar(id);

                MostrarCategorias();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmProveedorNuevo frm = new FrmProveedorNuevo();

            frm.ShowDialog();

            MostrarProveedores();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.CurrentRow != null)
            {
                FrmProveedorNuevo frm = new FrmProveedorNuevo();

                frm.IdProveedor = Convert.ToInt32(
                    dgvProveedores.CurrentRow.Cells["id_proveedor"].Value
                );

                frm.Nombre = dgvProveedores.CurrentRow.Cells["nombre"].Value.ToString();

                frm.Telefono = dgvProveedores.CurrentRow.Cells["telefono"].Value.ToString();

                frm.Direccion = dgvProveedores.CurrentRow.Cells["direccion"].Value.ToString();

                frm.ShowDialog();

                MostrarProveedores();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.CurrentRow != null)
            {
                int id = Convert.ToInt32(
                    dgvProveedores.CurrentRow.Cells["id_proveedor"].Value
                );

                objProveedores.EliminarProveedor(id);

                MostrarProveedores();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
