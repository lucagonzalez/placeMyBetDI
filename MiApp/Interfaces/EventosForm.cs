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
    public partial class EventosForm : Form
    {
        

        private List<Evento> eventos;
        private void EventoInformation()  // metodo xa rellenar la tabla
        {
            dataGridViewEventos.Rows.Clear();
            foreach (Evento p in eventos)
            {
                dataGridViewEventos.Rows.Add(p.EventoId, p.Fecha, p.EquipoLocal, p.EquipoVisitante);
            }
        }

        private void PopulateWithAll()
        {
            eventos = new List<Evento>(EventoDAO.GetAllEvento());
            EventoInformation();
        }

        public EventosForm()    //mostramos la info
        {
            eventos = new List<Evento>(EventoDAO.GetAllEvento());

            InitializeComponent();
            PopulateWithAll();
        }

        private Evento SearchSelecEvento()
        {
            int id = (int)dataGridViewEventos.SelectedRows[0].Cells[0].Value;
            Evento p = null;
            foreach(Evento otherevento in eventos)
            {
                if(otherevento.EventoId == id)
                {
                    p = otherevento;
                    break;
                }
            }
            return p;
        }

        

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonEventosID_Click(object sender, EventArgs e)
        {
            String TextID = textBoxID.Text;
            if (IsIDCOrrect(TextID))
            {
                int id = int.Parse(textBoxID.Text);
                eventos.Clear();
                Evento p = EventoDAO.GetByIDEvento(id);
                if (p != null)
                {
                    eventos.Add(p);
                }
                EventoInformation();
            }
            else
            {
                MessageBox.Show(this, "Introduce algun valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonEventosView_Click(object sender, EventArgs e)
        {
            PopulateWithAll();
        }

        private void buttonExternoDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewEventos.SelectedRows.Count > 0)
            {
                int id = (int)dataGridViewEventos.SelectedRows[0].Cells[0].Value;
                Evento p = null;
                foreach (Evento otherEvento in eventos)
                {
                    if (otherEvento.EventoId == id)
                    {
                        p = otherEvento;
                        break;
                    }
                }
                dataGridViewEventos.Rows.Remove(dataGridViewEventos.SelectedRows[0]);
                eventos.Remove(p);
                EventoDAO.DeleteEventos(p);
            }
            else
            {
                MessageBox.Show(this, "Tienes que seleccionar un evento de la tabla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonModificarExterno_Click(object sender, EventArgs e)
        {
            Evento p = SearchEvento();
            if (eventos != null){
                UpdateEventosForm newForm = new UpdateEventosForm(p);// falta p
                newForm.ShowDialog(this);
                
            }
        }

        private Evento SearchEvento()
        {
            int id = (int)dataGridViewEventos.SelectedRows[0].Cells[0].Value;
            Evento p = null;
            foreach (Evento otherEvento in eventos)
            {
                if (otherEvento.EventoId == id)
                {
                    p = otherEvento;
                    break;
                }
            }
            return p;
        }

        private bool IsIDCOrrect(string TextID)
        {
            return TextID == "" ? false : true;
        }
    }
}
