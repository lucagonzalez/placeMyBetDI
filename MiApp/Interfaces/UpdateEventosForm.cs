using MiApp.DataAccessLayer;
using MiApp.Eventos;
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
    public partial class UpdateEventosForm : Form
    {
        
        private Evento originalEvento = null;
        private Evento currentEvento = null;

        private Evento _returnedEvento = null;
        public Evento ReturnedEvento
        {
            get
            {
                return _returnedEvento;
            }
        }

        public UpdateEventosForm(Evento eventos)
        {
            originalEvento = eventos;
            currentEvento = new Evento(eventos);
            _returnedEvento = null;
            InitializeComponent();
            FillIU();
        }

        private void FillIU()
        {
            textBoxIdentificador.Text = currentEvento.EventoId.ToString();
            monthCalendarJoinDate.SelectionStart = currentEvento.Fecha;
            textBoxEquipoLocal.Text = currentEvento.EquipoLocal;
            textBoxEquipoVisitante.Text = currentEvento.EquipoVisitante;
            
        }
        
        private void textBoxEquipoLocal_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBoxEquipoVisitante_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string idOriginal = textBoxIdentificador.Text;
            string EquipoLocalOriginal = textBoxEquipoLocal.Text;
            string EquipoVisitanteOriginal = textBoxEquipoVisitante.Text;

            bool result = this.ValidateChildren();
            if (IsIDCOrrect(idOriginal, EquipoLocalOriginal, EquipoVisitanteOriginal))
            {
                if (result)
                {
                    int id = int.Parse(textBoxIdentificador.Text);
                    string EquipoLocal = textBoxEquipoLocal.Text;
                    string EquipoVisitante = textBoxEquipoVisitante.Text;
                    DateTime fecha = monthCalendarJoinDate.SelectionStart;
                    Evento p = new Evento(id, fecha, EquipoLocal, EquipoVisitante);
                    EventoDAO.updateEventos(p);

                }
                else
                {
                    MessageBox.Show(this, "algun campo erroneo", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show(this, "algun campo esta vacio", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBoxIdentificador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }

        private bool IsIDCOrrect(string idOriginal, string EquipoLocalOriginal, string EquipoVisitanteOriginal)
        {
            if(idOriginal=="" || EquipoLocalOriginal == "" || EquipoVisitanteOriginal == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
