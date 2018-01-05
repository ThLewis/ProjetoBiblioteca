using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Biblioteca
{
    public partial class FormAcesso : Form
    {
        public FormAcesso()
        {
            InitializeComponent();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            acessarBiblioteca();
        }

        private void acessarBiblioteca()
        {
            if (txtUsernameAcesso.Text == "admin@admin" && txtSenhaAcesso.Text == "admin")
            {
                this.Hide();
                Form frmBiblioteca = new FormBiblioteca();
                frmBiblioteca.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Acesso Inválido", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
