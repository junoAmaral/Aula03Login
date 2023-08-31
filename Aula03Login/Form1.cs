using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula03Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (usuario == "ju_amaral" && senha == "123")
            {
                MessageBox.Show("Boas vindas!");
                panelSaldo.Visible = true;
                //panelSaldo.Show();
                //panelSaldo.Hide();
            }
            else
            {
                MessageBox.Show("Algo está incorreto. Digite novamente.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
