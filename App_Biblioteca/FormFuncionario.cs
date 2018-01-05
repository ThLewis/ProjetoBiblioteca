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
    public partial class FormFuncionario : Form
    {
        //Variável de Código do Cliente

        int codFun = -1;

        //Métodos Construtores

        public FormFuncionario()
        {
            InitializeComponent();
        }

        public FormFuncionario(int cod)
        {
            InitializeComponent();

            this.Text = "Alterar Dados do Funcionario";
            btnCadastrarFuncionario.Visible = false;
            btnAlterarDadosFuncionario.Visible = true;

            codFun = cod;
            getDadosFuncionario();
        }

        //Métodos de Cliques nos Botões

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            if (checkCampos())
            {
                string sql;

                MySqlConnection cnx = Conexao.getConnection();

                sql = "INSERT INTO Funcionario (nm_func,email_func,senha_func,end_func,tel_func,cpf_func) VALUES(@nome,@email,@senha,@endereco,@telefone,@cpf)";

                try
                {

                    cnx.Open();

                    MySqlCommand cmd = new MySqlCommand(sql, cnx);

                    cmd.Parameters.Add(new MySqlParameter("@nome", txtNomeFuncionario.Text));
                    cmd.Parameters.Add(new MySqlParameter("@email", txtEmailFuncionario.Text));
                    cmd.Parameters.Add(new MySqlParameter("@senha", txtSenhaFuncionario.Text));
                    cmd.Parameters.Add(new MySqlParameter("@endereco", txtEnderecoFuncionario.Text));
                    cmd.Parameters.Add(new MySqlParameter("@telefone", mskTelefoneFuncionario.Text));
                    cmd.Parameters.Add(new MySqlParameter("@cpf", mskCPFFuncionario.Text));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Funcionario cadastrado com sucesso", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problema ao incluir Funcionario " + ex, "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnAlterarDadosFuncionario_Click(object sender, EventArgs e)
        {
            string sqlQuery;

            MySqlConnection cnn = Conexao.getConnection();

            sqlQuery = "UPDATE Funcionario SET nm_func = @nome, email_func = @email, senha_func = @senha, end_func = @end, cpf_func = @cpf, tel_func = @telefone WHERE cod_func = @cod";

            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                cmd.Parameters.Add(new MySqlParameter("@nome", txtNomeFuncionario.Text));
                cmd.Parameters.Add(new MySqlParameter("@email", txtEmailFuncionario.Text));
                cmd.Parameters.Add(new MySqlParameter("@senha", txtSenhaFuncionario.Text));
                cmd.Parameters.Add(new MySqlParameter("@end", txtEnderecoFuncionario.Text));
                cmd.Parameters.Add(new MySqlParameter("@cpf", mskCPFFuncionario.Text));
                cmd.Parameters.Add(new MySqlParameter("@telefone", mskTelefoneFuncionario.Text));
                cmd.Parameters.Add(new MySqlParameter("@cod", codFun));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Funcionario alterado com sucesso", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void btnLimparCamposFuncionario_Click(object sender, EventArgs e)
        {
            txtNomeFuncionario.Clear();
            txtEmailFuncionario.Clear();
            txtSenhaFuncionario.Clear();
            txtEnderecoFuncionario.Clear();
            mskCPFFuncionario.Clear();
            mskTelefoneFuncionario.Clear();
        }

        //Métodos específicos

        private bool checkCampos()
        {
            bool verificado = true;
            if (txtNomeFuncionario.Text == "")
            {
                verificado = false;
                MessageBox.Show("Insira o Nome!", "Erro no Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeFuncionario.Focus();
            }

            else if (txtEmailFuncionario.Text == "")
            {
                verificado = false;
                MessageBox.Show("Insira o E-Mail!", "Erro no Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmailFuncionario.Focus();
            }

            else if (txtSenhaFuncionario.Text == "")
            {
                verificado = false;
                MessageBox.Show("Insira a Senha!", "Erro no Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenhaFuncionario.Focus();
            }

            else if (txtEnderecoFuncionario.Text == "")
            {
                verificado = false;
                MessageBox.Show("Insira o Endereço!", "Erro no Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEnderecoFuncionario.Focus();
            }

            else if (!mskTelefoneFuncionario.MaskFull)
            {
                verificado = false;
                MessageBox.Show("Insira o Telefone Corretamente!", "Erro no Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskTelefoneFuncionario.Focus();
            }

            else if (!mskCPFFuncionario.MaskFull)
            {
                verificado = false;
                MessageBox.Show("Insira o CPF Corretamente!", "Erro no Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskCPFFuncionario.Focus();
            }
            return verificado;
        }

        private void getDadosFuncionario()
        {
            MySqlConnection cnn = Conexao.getConnection();

            MySqlDataReader dtr = null;

            string sqlQuery = "SELECT * from Funcionario where cod_func = @cod";

            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                cmd.Parameters.AddWithValue("@cod", codFun);

                dtr = cmd.ExecuteReader();

                if (dtr.Read())
                {
                    txtNomeFuncionario.Text = dtr["nm_func"].ToString();
                    txtEmailFuncionario.Text = dtr["email_func"].ToString();
                    txtSenhaFuncionario.Text = dtr["senha_func"].ToString();
                    txtEnderecoFuncionario.Text = dtr["end_func"].ToString();
                    mskCPFFuncionario.Text = dtr["cpf_func"].ToString();
                    mskTelefoneFuncionario.Text = dtr["tel_func"].ToString();

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
