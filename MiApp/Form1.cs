
using MiApp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private bool isDataCorrect (String textBoxLogin, String textBoxPassword)
        {
            return textBoxLogin != "admin" || textBoxPassword != "admin" ? false : true;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            if (isDataCorrect(login, password))
            {
                //MessageBox.Show("Campos correctos", "Validacion correcta");
                PaginaPrincipal newForm = new PaginaPrincipal();
                newForm.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("login o password incorrectos", "Validacion incorrecta");
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
