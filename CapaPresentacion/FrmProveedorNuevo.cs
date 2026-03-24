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
    public partial class FrmProveedorNuevo : Form
    {
        CN_Proveedores obj = new CN_Proveedores();

        public FrmProveedorNuevo()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("El nombre es obligatorio");
                return;
            }

            obj.AgregarProveedor(
                txtNombre.Text,
                txtTelefono.Text            );

            MessageBox.Show("Proveedor agregado correctamente");

            this.Close(); 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
