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
    public partial class FrmPrincipal : Form
    {

        private int _idAuditoria;
        CNAuditoria objAuditoria = new CNAuditoria();
        public FrmPrincipal(int idAuditoria)
        {
            InitializeComponent();
            _idAuditoria = idAuditoria;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmListadoCategorias frm = new FrmListadoCategorias();
            frm.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmProductos frm = new FrmProductos();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmAuditoriaLogin frm = new FrmAuditoriaLogin();
            frm.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            objAuditoria.RegistrarLogout(_idAuditoria);

            FrmLogin login = new FrmLogin();
            login.Show();

            this.Close();
        }
    }
}
