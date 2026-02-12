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
    public partial class FrmAuditoria: Form
    {
        CNAuditoria negocio = new CNAuditoria();

        private void CargarAuditoria()
        {
            dgvAuditoria.DataSource = negocio.MostrarAuditoria();
        }
        public FrmAuditoria()
        {
            InitializeComponent();
        }

        private void FrmAuditoria_Load(object sender, EventArgs e)
        {
            CargarAuditoria();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            CargarAuditoria();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
