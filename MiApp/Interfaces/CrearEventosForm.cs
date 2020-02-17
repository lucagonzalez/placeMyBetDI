using MiApp.DataAccessLayer;
using MiApp.Eventos;
using MiApp.Mercados;
using MySql.Data.MySqlClient;
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
    public partial class CrearEventosForm : Form
    {
        private List<Evento> eventos;

        private List<Mercado> mercados;

        private void EventoInformation()  // metodo xa rellenar la tabla
        {
            dataGridViewEventos.Rows.Clear();
            foreach (Evento p in eventos)
            {
                dataGridViewEventos.Rows.Add(p.EventoId, p.Fecha, p.EquipoLocal, p.EquipoVisitante);
            }
        }

        private void MercadoInformation()  // metodo xa rellenar la tabla
        {
            dataGridViewMercado.Rows.Clear();
            foreach (Mercado p in mercados)
            {
                dataGridViewMercado.Rows.Add(p.MercadoId, p.Tipo, p.CuotaOver, p.CuotaUnder, p.ApostadoOver, p.ApostadoUnder, p.EventoId);
            }
        }

        private void PopulateWithAll()
        {
            eventos = new List<Evento>(EventoDAO.GetAllEvento());
            EventoInformation();
            mercados = new List<Mercado>(MercadoDAO.GetAllMercado());
            MercadoInformation();
        }

        public CrearEventosForm()    //mostramos la info
        {
            eventos = new List<Evento>(EventoDAO.GetAllEvento());
            mercados = new List<Mercado>(MercadoDAO.GetAllMercado());

            InitializeComponent();
            PopulateWithAll();
        }

        private void CrearEventosForm_Load(object sender, EventArgs e)
        {

        }

        private void textBoxCuotaOver1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxCuotaOver2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxCuotaOver3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxCuotaUnder1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxCuotaUnder2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxCuotaUnder3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxApostadoOver1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxApostadoOver2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxApostadoOver3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxApostadoUnder1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxApostadoUnder2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxApostadoUnder3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string IDOriginal = textBoxIdentificador.Text;
            string EquipoLocalOriginal = textBoxEquipoLocal.Text;
            string EquipoVisitanteOriginal = textBoxEquipoVisitante.Text;
            string CuotaOver1Original = textBoxCuotaOver1.Text;
            string CuotaOver2Original = textBoxCuotaOver2.Text;
            string CuotaOver3Original = textBoxCuotaOver3.Text;
            string CuotaUnder1Original = textBoxCuotaUnder1.Text;
            string CuotaUnder2Original = textBoxCuotaUnder2.Text;
            string CuotaUnder3Original = textBoxCuotaUnder3.Text;
            string ApostadoOver1Original = textBoxApostadoOver1.Text;
            string ApostadoOver2Original = textBoxApostadoOver2.Text;
            string ApostadoOver3Original = textBoxApostadoOver3.Text;
            string ApostadoUnder1Original = textBoxApostadoUnder1.Text;
            string ApostadoUnder2Original = textBoxApostadoUnder2.Text;
            string ApostadoUnder3Original = textBoxApostadoUnder3.Text;

            bool result = this.ValidateChildren();
            if (IsIDCOrrect(EquipoLocalOriginal, EquipoVisitanteOriginal, CuotaOver1Original, CuotaOver2Original,
                CuotaOver3Original, CuotaUnder1Original, CuotaUnder2Original, CuotaUnder3Original, ApostadoOver1Original,
                ApostadoOver2Original, ApostadoOver3Original, ApostadoUnder1Original, ApostadoUnder2Original, ApostadoUnder3Original))
            {
                if (result)
                {
                    //int ID = int.Parse(textBoxIdentificador.Text);
                    DateTime fecha = monthCalendarJoinDate.SelectionStart;
                    string EquipoLocal = textBoxEquipoLocal.Text;
                    string EquipoVisitante = textBoxEquipoVisitante.Text;
                    //evento p = new evento(ID, fecha, EquipoLocal, EquipoVisitante);
                    //EventoDAO.InsertEventos(p);
                    int ValorID = EventoDAO.InsertEventosSinID(fecha, EquipoLocal, EquipoVisitante);

                    double tipo = double.Parse(textBoxTipo1.Text);
                    double cuotaOver = double.Parse(textBoxCuotaOver1.Text);
                    double cuotaUnder = double.Parse(textBoxCuotaUnder1.Text);
                    double apostadoOver = double.Parse(textBoxApostadoOver1.Text);
                    double ApostadoUnder = double.Parse(textBoxApostadoUnder1.Text);
                    int ID_eventos = ValorID;
                    MercadoDAO.InsertMercadosSinID(tipo, cuotaOver, cuotaUnder, apostadoOver, ApostadoUnder, ID_eventos);

                    double tipo2 = double.Parse(textBoxTipo2.Text);
                    double cuotaOver2 = double.Parse(textBoxCuotaOver2.Text);
                    double cuotaUnder2 = double.Parse(textBoxCuotaUnder2.Text);
                    double apostadoOver2 = double.Parse(textBoxApostadoOver2.Text);
                    double ApostadoUnder2 = double.Parse(textBoxApostadoUnder2.Text);                    
                    MercadoDAO.InsertMercadosSinID(tipo2, cuotaOver2, cuotaUnder2, apostadoOver2, ApostadoUnder2, ID_eventos);

                    double tipo3 = double.Parse(textBoxTipo3.Text);
                    double cuotaOver3 = double.Parse(textBoxCuotaOver3.Text);
                    double cuotaUnder3 = double.Parse(textBoxCuotaUnder3.Text);
                    double apostadoOver3 = double.Parse(textBoxApostadoOver3.Text);
                    double ApostadoUnder3 = double.Parse(textBoxApostadoUnder3.Text);
                    MercadoDAO.InsertMercadosSinID(tipo3, cuotaOver3, cuotaUnder3, apostadoOver3, ApostadoUnder3, ID_eventos);


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

        private bool IsIDCOrrect( string EquipoLocalOriginal, string EquipoVisitanteOriginal, string CuotaOver1Original, string CuotaOver2Original,
            string CuotaOver3Original, string CuotaUnder1Original, string CuotaUnder2Original, string CuotaUnder3Original, string ApostadoOver1Original,
            string ApostadoOver2Original, string ApostadoOver3Original, string ApostadoUnder1Original, string ApostadoUnder2Original, string ApostadoUnder3Original)
        {
            if (EquipoLocalOriginal == "" || EquipoVisitanteOriginal == "" || CuotaOver1Original == "" || CuotaOver2Original == "" 
                || CuotaOver3Original == "" || CuotaUnder1Original == "" || CuotaUnder2Original == "" || CuotaUnder3Original == "" || ApostadoOver1Original == ""
                || ApostadoOver2Original == "" || ApostadoOver3Original == "" || ApostadoUnder1Original == "" || ApostadoUnder2Original == "" || ApostadoUnder3Original == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            PopulateWithAll();
        }
    }
}
