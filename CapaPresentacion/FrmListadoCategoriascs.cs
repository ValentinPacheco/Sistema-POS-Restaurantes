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
    public partial class FrmListadoCategoriascs : Form
    {
        public FrmListadoCategoriascs()
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
            this.dlistado.DataSource = CNCategorias.Listar();
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
    }
}
