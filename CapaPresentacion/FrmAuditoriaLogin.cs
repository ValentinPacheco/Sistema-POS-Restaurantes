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
    public partial class FrmAuditoriaLogin : Form
    {
        public FrmAuditoriaLogin()
        {
            InitializeComponent();
        }
        CNAuditoria objNegocio = new CNAuditoria();

        private void FrmAuditoriaLogin_Load(object sender, EventArgs e)
        {
            dgvAuditoria.DataSource = objNegocio.ListarAuditoria();

        }

        private void dgvAuditoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
