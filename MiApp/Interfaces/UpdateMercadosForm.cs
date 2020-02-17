using MiApp.DataAccessLayer;
using MiApp.Mercados;
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
    public partial class UpdateMercadosForm : Form
    {
        private Mercado originalMercado = null;
        private Mercado currentMercado = null;

        private Mercado _returnedMercado = null;
        public Mercado ReturnedMercado
        {
            get
            {
                return _returnedMercado;
            }
        }

        public UpdateMercadosForm(Mercado mercados)
        {
            originalMercado = mercados;
            currentMercado = new Mercado(mercados);
            _returnedMercado = null;
            InitializeComponent();
            FillIU();
        }

        private void FillIU()
        {
            textBoxIdentificador.Text = currentMercado.MercadoId.ToString();
            textBoxTipo.Text = currentMercado.Tipo.ToString();
            textBoxCuotaOver.Text = currentMercado.CuotaOver.ToString();
            textBoxCuotaUnder.Text = currentMercado.CuotaUnder.ToString();
            textBoxApostadoOver.Text = currentMercado.ApostadoOver.ToString();
            textBoxApostadoUnder.Text = currentMercado.ApostadoUnder.ToString();
            textBoxIDEventos.Text = currentMercado.EventoId.ToString();


        }

        private void textBoxTipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxCuotaOver_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxCuotaUnder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxApostadoOver_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxApostadoUnder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string tipoOriginal = textBoxTipo.Text;
            string cuotaOverOriginal = textBoxCuotaOver.Text;
            string cuotaUnderOriginal = textBoxCuotaUnder.Text;
            string apostadoOverOriginal = textBoxApostadoOver.Text;
            string apostadoUnderOriginal = textBoxApostadoUnder.Text;


            bool result = this.ValidateChildren();
            if (IsIDCOrrect(tipoOriginal, cuotaOverOriginal, cuotaUnderOriginal, apostadoOverOriginal, apostadoUnderOriginal))
            {
                if (result)
                {

                    int id = int.Parse(textBoxIdentificador.Text);
                    double tipo = double.Parse(textBoxTipo.Text);
                    double cuotaOver = double.Parse(textBoxCuotaOver.Text);
                    double cuotaUnder = double.Parse(textBoxCuotaUnder.Text);
                    double apostadoOver = double.Parse(textBoxApostadoOver.Text);
                    double apostadoUnder = double.Parse(textBoxApostadoUnder.Text);
                    int ID_eventos = int.Parse(textBoxIDEventos.Text);
                    Mercado p = new Mercado(id, tipo, cuotaOver, cuotaUnder, apostadoOver, apostadoUnder, ID_eventos);
                    MercadoDAO.updateMercados(p);
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsIDCOrrect(string tipoOriginal, string cuotaOverOriginal, string cuotaUnderOriginal, string apostadoOverOriginal, string apostadoUnderOriginal)
        {
            if (tipoOriginal == "" || cuotaOverOriginal == "" || cuotaUnderOriginal == "" || apostadoOverOriginal == "" || apostadoUnderOriginal == "")
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
