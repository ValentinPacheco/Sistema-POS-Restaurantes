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
    public partial class FrmProveedores : Form
    {
        CN_Proveedores obj = new CN_Proveedores();

        public FrmProveedores()
        {
            InitializeComponent();
            this.Load += FrmProveedores_Load;
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            dgvProveedores.DataSource = obj.MostrarProveedores();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvProveedores.DataSource = obj.BuscarProveedor(txtBuscar.Text);

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvProveedores.CurrentRow.Cells["id_proveedor"].Value);
            string nombre = dgvProveedores.CurrentRow.Cells["nombre"].Value.ToString();
            string telefono = dgvProveedores.CurrentRow.Cells["telefono"].Value.ToString();

            FrmProveedorEditar frm = new FrmProveedorEditar(id, nombre, telefono);
            frm.ShowDialog();

            // 🔄 recargar
            dgvProveedores.DataSource = obj.MostrarProveedores();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvProveedores.CurrentRow.Cells["id_proveedor"].Value);

            var confirm = MessageBox.Show("¿Eliminar proveedor?", "Confirmar", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                obj.EliminarProveedor(id);

                MessageBox.Show("Proveedor eliminado");
                dgvProveedores.DataSource = obj.MostrarProveedores();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmProveedorNuevo frm = new FrmProveedorNuevo();
            frm.ShowDialog();

            dgvProveedores.DataSource = obj.MostrarProveedores();
        }
    }
}