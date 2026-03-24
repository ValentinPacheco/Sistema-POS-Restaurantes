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
    public partial class FrmReabastecimiento : Form
    {
        // 🔹 1. OBJETO DE NEGOCIO (ARRIBA)
        CN_Faltantes obj = new CN_Faltantes();

        // 🔹 2. CONSTRUCTOR
        public FrmReabastecimiento()
        {
            InitializeComponent();

            // 🔹 3. EVENTO LOAD
            this.Load += FrmReabastecimiento_Load;
        }

        // 🔹 4. LOAD DEL FORM
        private void FrmReabastecimiento_Load(object sender, EventArgs e)
        {
            CargarFaltantes();
        }

        // 🔹 5. MÉTODO PARA LLENAR EL DGV
        private void CargarFaltantes()
        {
            dgvFaltantes.DataSource = obj.MostrarFaltantes();
        }

        // 🔹 6. BOTÓN "MARCAR COMO ATENDIDO"
        private void btnAtendido_Click(object sender, EventArgs e)
        {
            if (dgvFaltantes.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un registro");
                return;
            }

            int idFaltante = Convert.ToInt32(dgvFaltantes.CurrentRow.Cells["id_faltante"].Value);

            obj.AtenderFaltante(idFaltante);

            MessageBox.Show("Producto marcado como atendido");

            CargarFaltantes();
        }
    }
}
