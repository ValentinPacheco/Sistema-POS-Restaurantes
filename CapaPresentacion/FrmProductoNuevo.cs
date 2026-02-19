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
    public partial class FrmProductoNuevo : Form
    {
        CNProductos objNegocio = new CNProductos();
        CNCategorias objCategorias = new CNCategorias();

        public int IdProducto = 0;
        public string Nombre;
        public decimal Precio;
        public int IdCategoria;
        public bool Activo;
        public FrmProductoNuevo()
        {
            InitializeComponent();
        }

        private void FrmProductoNuevo_Load(object sender, EventArgs e)
        {
            CargarCategorias();

            if (IdProducto != 0)
            {
                txtNombre.Text = Nombre;
                txtPrecio.Text = Precio.ToString();
                cbCategoria.SelectedValue = IdCategoria;
                chkActivo.Checked = Activo;
            }
        }

        private void CargarCategorias()
        {
            cbCategoria.DataSource =  CNCategorias.ListarCategorias();
            cbCategoria.DisplayMember = "nombre";
            cbCategoria.ValueMember = "id_categoria";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            decimal precio = Convert.ToDecimal(txtPrecio.Text);
            int idCategoria = Convert.ToInt32(cbCategoria.SelectedValue);
            bool activo = chkActivo.Checked;

            if (IdProducto == 0)
            {
                objNegocio.InsertarProducto(nombre, precio, idCategoria, activo);
            }
            else
            {
                objNegocio.EditarProducto(IdProducto, nombre, precio, idCategoria, activo);
            }

            this.Close();
        }
    }
}
