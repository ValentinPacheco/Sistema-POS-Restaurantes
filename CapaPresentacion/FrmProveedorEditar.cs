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
    public partial class FrmProveedorEditar : Form
    {
        CN_Proveedores obj = new CN_Proveedores();

        int idProveedor;

        public FrmProveedorEditar(int id, string nombre, string telefono)
        {
            InitializeComponent();

            idProveedor = id;

            txtNombre.Text = nombre;
            txtTelefono.Text = telefono;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            obj.EditarProveedor(
                idProveedor,
                txtNombre.Text,
                txtTelefono.Text
            );

            MessageBox.Show("Proveedor actualizado");

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
