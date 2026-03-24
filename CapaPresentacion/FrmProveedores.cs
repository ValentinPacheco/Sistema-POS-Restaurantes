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
    public partial class FrmProveedores : Form
    {
        CN_Proveedores obj = new CN_Proveedores();

        public FrmProveedores()
        {
            InitializeComponent();
            this.Load += FrmProveedores_Load;
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            dgvProveedores.DataSource = obj.MostrarProveedores();
        }
    }
}