using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiApp.Interfaces
{
    public partial class PaginaPrincipal : Form
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private void buttonEventos_Click(object sender, EventArgs e)
        {
            EventosForm newForm = new EventosForm();
            newForm.ShowDialog(this);
        }

        private void buttonMercados_Click(object sender, EventArgs e)
        {
            MercadosForm newForm = new MercadosForm();
            newForm.ShowDialog(this);
        }

        private void buttonNuevosEventos_Click(object sender, EventArgs e)
        {
            CrearEventosForm newForm = new CrearEventosForm();
            newForm.ShowDialog(this);
            
        }

        private void buttonInformes_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "Pendiente de Construccion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
