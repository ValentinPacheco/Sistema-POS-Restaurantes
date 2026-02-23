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
    public partial class FrmLogin : Form
    {
        CNUsuarios objNegocio = new CNUsuarios();
        CNAuditoria objAuditoria = new CNAuditoria();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int idUsuario = objNegocio.Login(txtUsuario.Text, txtPassword.Text);

            if (idUsuario > 0)
            {
                objAuditoria.RegistrarLogin(idUsuario);

                FrmPrincipal frm = new FrmPrincipal();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }
    }
}
