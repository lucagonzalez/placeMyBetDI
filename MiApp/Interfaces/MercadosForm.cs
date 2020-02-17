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
    public partial class MercadosForm : Form
    {
        private List<Mercado> mercados;
        private void MercadoInformation()  // metodo xa rellenar la tabla
        {
            dataGridViewMercado.Rows.Clear();
            foreach (Mercado p in mercados)
            {
                dataGridViewMercado.Rows.Add(p.MercadoId, p.Tipo,p.CuotaOver,p.CuotaUnder,p.ApostadoOver,p.ApostadoUnder,p.EventoId);
            }
        }

        private void PopulateWithAll()
        {
            mercados = new List<Mercado>(MercadoDAO.GetAllMercado());
            MercadoInformation();
        }

        public MercadosForm()
        {
            mercados = new List<Mercado>(MercadoDAO.GetAllMercado());

            InitializeComponent();
            PopulateWithAll();
        }

        private Mercado SearchSelecEvento()
        {
            int id = (int)dataGridViewMercado.SelectedRows[0].Cells[0].Value;
            Mercado p = null;
            foreach (Mercado othermercado in mercados)
            {
                if (othermercado.MercadoId == id)
                {
                    p = othermercado;
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

        private bool IsIDCOrrect(string TextID)
        {
            return TextID == "" ? false : true;
        }

        private void buttonMercadosID_Click(object sender, EventArgs e)
        {
            String TextID = textBoxID.Text;
            if (IsIDCOrrect(TextID))
            {
                int id = int.Parse(textBoxID.Text);
                mercados.Clear();
                Mercado p = MercadoDAO.GetByIDMercado(id);
                if (p != null)
                {
                    mercados.Add(p);
                }
                MercadoInformation();
            }
            else
            {
                MessageBox.Show(this, "Introduce algun valor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonMercadosView_Click(object sender, EventArgs e)
        {
            PopulateWithAll();
        }

        private void buttonMercadoDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewMercado.SelectedRows.Count > 0)
            {
                int id = (int)dataGridViewMercado.SelectedRows[0].Cells[0].Value;
                Mercado p = null;
                foreach (Mercado otherMercado in mercados)
                {
                    if (otherMercado.MercadoId == id)
                    {
                        p = otherMercado;
                        break;
                    }
                }
                dataGridViewMercado.Rows.Remove(dataGridViewMercado.SelectedRows[0]);
                mercados.Remove(p);
                MercadoDAO.DeleteMercados(p);
            }
            else
            {
                MessageBox.Show(this, "Tienes que seleccionar un mercado de la tabla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonModificarExterno_Click(object sender, EventArgs e)
        {
            Mercado p = SearchEvento();
            if (mercados != null)
            {
                UpdateMercadosForm newForm = new UpdateMercadosForm(p);// falta p
                newForm.ShowDialog(this);

            }
        }

        private Mercado SearchEvento()
        {
            int id = (int)dataGridViewMercado.SelectedRows[0].Cells[0].Value;
            Mercado p = null;
            foreach (Mercado otherMercado in mercados)
            {
                if (otherMercado.MercadoId == id)
                {
                    p = otherMercado;
                    break;
                }
            }
            return p;
        }
    }
}