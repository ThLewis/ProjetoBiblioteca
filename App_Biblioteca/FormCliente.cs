using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace App_Biblioteca
{
    public partial class FormCliente : Form
    {
        //Variável de Código do Cliente

        int codCli = -1;

        //Métodos Construtores

        public FormCliente()
        {
            InitializeComponent();
        }

        public FormCliente(int cod)
        {
            InitializeComponent();

            this.Text = "Alterar Dados do Cliente";
            btnCadastrarCliente.Visible = false;
            btnAlterarDadosCliente.Visible = true;

            codCli = cod;
            getDadosCliente();
        }

        //Métodos de Cliques nos Botões

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (checkCampos())
            {
                string sql;

                MySqlConnection cnx = Conexao.getConnection();

                sql = "INSERT INTO Cliente (nm_clien,email,senha,end_cliente,sexo,telefone,cpf) VALUES(@nome,@email,@senha,@endereco,@sexo,@telefone,@cpf)";

                try
                {

                    cnx.Open();

                    MySqlCommand cmd = new MySqlCommand(sql, cnx);
                    char sx = 'F';

                    if (rbnMasculino.Checked)
                    {
                        sx = 'M';
                    }
                    else
                    {
                        sx = 'F';
                    }

                    cmd.Parameters.Add(new MySqlParameter("@nome", txtNomeCliente.Text));
                    cmd.Parameters.Add(new MySqlParameter("@email", txtEmailCliente.Text));
                    cmd.Parameters.Add(new MySqlParameter("@senha", txtSenhaCliente.Text));
                    cmd.Parameters.Add(new MySqlParameter("@endereco", txtEnderecoCliente.Text));
                    cmd.Parameters.Add(new MySqlParameter("@sexo", sx));
                    cmd.Parameters.Add(new MySqlParameter("@telefone", mskTelefoneCliente.Text));
                    cmd.Parameters.Add(new MySqlParameter("@cpf", mskCPFCliente.Text));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cliente cadastrado com sucesso", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problema ao incluir Cliente " + ex, "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    if (cnx != null)
                    {
                        cnx.Close();
                    }
                }
            }
        }

        private void btnLimparCamposCliente_Click(object sender, EventArgs e)
        {
            txtNomeCliente.Clear();
            txtEmailCliente.Clear();
            txtSenhaCliente.Clear();
            txtEnderecoCliente.Clear();
            mskCPFCliente.Clear();
            mskTelefoneCliente.Clear();
            txtNomeCliente.Focus();
        }

        private void btnAlterarDadosCliente_Click(object sender, EventArgs e)
        {
            string sqlQuery;

            MySqlConnection cnn = Conexao.getConnection();

            sqlQuery = "UPDATE Cliente SET nm_clien = @nome, email = @email, senha = @senha, end_cliente = @end, cpf = @cpf, telefone = @telefone, sexo = @sexo WHERE cod_clien = @cod";

            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                char sx = 'F';

                if (rbnMasculino.Checked)
                {
                    sx = 'M';
                }
                else
                {
                    sx = 'F';
                }

                cmd.Parameters.Add(new MySqlParameter("@nome", txtNomeCliente.Text));
                cmd.Parameters.Add(new MySqlParameter("@email", txtEmailCliente.Text));
                cmd.Parameters.Add(new MySqlParameter("@senha", txtSenhaCliente.Text));
                cmd.Parameters.Add(new MySqlParameter("@end", txtEnderecoCliente.Text));
                cmd.Parameters.Add(new MySqlParameter("@cpf", mskCPFCliente.Text));
                cmd.Parameters.Add(new MySqlParameter("@telefone", mskTelefoneCliente.Text));
                cmd.Parameters.Add(new MySqlParameter("@sexo", sx));
                cmd.Parameters.Add(new MySqlParameter("@cod", codCli));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Cliente alterado com sucesso", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (cnn != null)
                {
                    cnn.Close();
                }
            }
        }

        //Métodos específicos

        private bool checkCampos()
        {
            bool verificado = true;
            if (txtNomeCliente.Text == "")
            {
                verificado = false;
                MessageBox.Show("Insira o Nome!", "Erro no Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeCliente.Focus();
            }

            else if (txtEmailCliente.Text == "")
            {
                verificado = false;
                MessageBox.Show("Insira o E-Mail!", "Erro no Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmailCliente.Focus();
            }

            else if (txtSenhaCliente.Enabled == true && txtSenhaCliente.Text == "")
            {
                verificado = false;
                MessageBox.Show("Insira a Senha!", "Erro no Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenhaCliente.Focus();
            }

            else if (txtEnderecoCliente.Text == "")
            {
                verificado = false;
                MessageBox.Show("Insira o Endereço!", "Erro no Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEnderecoCliente.Focus();
            }

            else if (!mskTelefoneCliente.MaskFull)
            {
                verificado = false;
                MessageBox.Show("Insira o Telefone Corretamente!", "Erro no Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskTelefoneCliente.Focus();
            }

            else if (!mskCPFCliente.MaskFull)
            {
                verificado = false;
                MessageBox.Show("Insira o CPF Corretamente!", "Erro no Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskCPFCliente.Focus();
            }
            return verificado;
        }

        private void getDadosCliente()
        {
            MySqlConnection cnn = Conexao.getConnection();

            MySqlDataReader dtr = null;

            string sqlQuery = "SELECT * from Cliente where cod_clien = @cod";

            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                cmd.Parameters.AddWithValue("@cod", codCli);

                dtr = cmd.ExecuteReader();

                if (dtr.Read())
                {
                    txtNomeCliente.Text = dtr["nm_clien"].ToString();
                    txtEmailCliente.Text = dtr["email"].ToString();
                    txtSenhaCliente.Text = dtr["senha"].ToString();
                    txtEnderecoCliente.Text = dtr["end_cliente"].ToString();
                    mskCPFCliente.Text = dtr["cpf"].ToString();
                    mskTelefoneCliente.Text = dtr["telefone"].ToString();

                    if (dtr["sexo"].ToString() == "M")
                    {
                        rbnMasculino.Checked = true;
                    }
                    else
                    {
                        rbnFeminino.Checked = true;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (dtr != null)
                {
                    dtr.Close();
                }
                if (cnn != null)
                {
                    cnn.Close();
                }
            }
        }
    }
}