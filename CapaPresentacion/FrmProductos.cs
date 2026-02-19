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

        public FrmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            MostrarProductos();

        }
        private void MostrarProductos()
        {
            dgvProductos.DataSource = objNegocio.ListarProductos();
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
    }
}
