using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmListadoCategorias : Form
    {
        public FrmListadoCategorias()
        {
            InitializeComponent();
        }

        //esta pinche etiqueta no la pude quitar xd luego veo como la quito
        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void FrmListadoCategoriascs_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
        }

        public void Mostrar()
        {
            this.dlistado.DataSource = CNCategorias.ListarCategorias();
        }

        public void BuscarNombre()
        {
            this.dlistado.DataSource = CNCategorias.BuscarNombre(this.txtbuscar.Text);
        }

        private void FrmListadoCategorias_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            Mostrar();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            BuscarNombre();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            FrmRegistrarCategorias form = new FrmRegistrarCategorias();

            form.Insert = true;

            form.Show();
            this.Hide();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            FrmRegistrarCategorias form = new FrmRegistrarCategorias();

            form.Edit = true;

            form.txtidcategoria.Text = this.dlistado.CurrentRow.Cells["id_categoria"].Value.ToString();
            form.txtnombre.Text = this.dlistado.CurrentRow.Cells["nombre"].Value.ToString();

            form.Show();
            this.Hide();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("¿Desea eliminar el registro?", "POS_Restaurante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dlistado.SelectedRows.Count > 0)
                {
                    if (opcion == DialogResult.OK)
                    {
                        string idcategoria = dlistado.CurrentRow.Cells["id_categoria"].Value.ToString();
                        CNCategorias.Eliminar(Convert.ToInt32(idcategoria));

                        MessageBox.Show("Registro eliminado", "POS_Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Mostrar();
                    }
                }
                Mostrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnauditoria_Click(object sender, EventArgs e)
        {

            FrmPasswordAuditoria frm = new FrmPasswordAuditoria();
                frm.ShowDialog();
            
        }
    }
}
