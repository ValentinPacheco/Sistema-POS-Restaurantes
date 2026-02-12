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
    public partial class FrmPasswordAuditoria : Form
    {
        public bool AccesoPermitido { get; private set; } = false;

        public FrmPasswordAuditoria()
        {
            InitializeComponent();
        }

        private void FrmPasswordAuditoria_Load(object sender, EventArgs e)
        {

        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "1234")
            {
                AccesoPermitido = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta");
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            AccesoPermitido = false;
            this.Close();
        }
    }
}
