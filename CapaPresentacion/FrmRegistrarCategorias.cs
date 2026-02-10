using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmRegistrarCategorias : Form
    {
        public bool Insert = false;
        public bool Edit = false;
        public FrmRegistrarCategorias()
        {
            InitializeComponent();
        }

        private void FrmRegistrarCategorias_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtnombre.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese el nombre de la categoria", "POS_Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (this.Insert == true)
                    {
                        CNCategorias.Guardar(this.txtnombre.Text);
                        MessageBox.Show("Categoria registrada correctamente", "POS_Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (this.Edit == true)
                    {
                        CNCategorias.Editar(Convert.ToInt32(this.txtidcategoria.Text), this.txtnombre.Text);
                        MessageBox.Show("Categoria editada correctamente", "POS_Restuarante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.Insert = false;
                    this.Edit = false;

                    FrmListadoCategorias form = new FrmListadoCategorias();
                    form.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            FrmListadoCategorias form = new FrmListadoCategorias();
            form.Show();
            this.Hide();
        }
    }
}
