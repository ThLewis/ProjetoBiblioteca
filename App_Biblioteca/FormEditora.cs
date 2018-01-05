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
    public partial class FormEditora : Form
    {
        //Váriavel de Código da Editora

        int codEdi = -1;

        //Métodos Construtores

        public FormEditora()
        {
            InitializeComponent();
        }

        public FormEditora(int cod)
        {
            InitializeComponent();

            this.Text = "Alterar Dados da Editora";
            btnCadastrarEditora.Visible = false;
            btnAlterarDadosEditora.Visible = true;

            codEdi = cod;
            getDadosEditora();
        }

        //Métodos dos Cliques dos Botões

        private void btnCadastrarEditora_Click(object sender, EventArgs e)
        {
            if (txtNomeEditora.Text != "")
            {
                string sqlQuery;

                MySqlConnection cnn = Conexao.getConnection();

                sqlQuery = "INSERT INTO Editora(nm_editora, end_editora) VALUES(@nome,@end)";

                try
                {
                    cnn.Open();

                    MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                    cmd.Parameters.Add(new MySqlParameter("@nome", txtNomeEditora.Text));
                    cmd.Parameters.Add(new MySqlParameter("@end", txtEnderecoEditora.Text));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Editora cadastrada com sucesso", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Editora já existente", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    if (cnn != null)
                    {
                        cnn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Insira o Nome da Editora", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAlterarDadosEditora_Click(object sender, EventArgs e)
        {
            if (txtNomeEditora.Text != "")
            {
                string sqlQuery;

                MySqlConnection cnn = Conexao.getConnection();

                sqlQuery = "UPDATE Editora SET nm_editora = @nome, end_editora = @end where cod_editora = @cod";

                try
                {
                    cnn.Open();

                    MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                    cmd.Parameters.Add(new MySqlParameter("@nome", txtNomeEditora.Text));
                    cmd.Parameters.Add(new MySqlParameter("@end", txtEnderecoEditora.Text));
                    cmd.Parameters.Add(new MySqlParameter("@cod", codEdi));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Editora alterada com sucesso", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Alterar", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    if (cnn != null)
                    {
                        cnn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Insira o Nome da Editora", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Método específico

        private void getDadosEditora()
        {
            MySqlConnection cnn = Conexao.getConnection();

            MySqlDataReader dtr = null;

            string sqlQuery = "SELECT * from Editora where cod_editora = @cod";

            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                cmd.Parameters.AddWithValue("@cod", codEdi);

                dtr = cmd.ExecuteReader();

                if (dtr.Read())
                {
                    txtNomeEditora.Text = dtr["nm_editora"].ToString();
                    txtEnderecoEditora.Text = dtr["end_editora"].ToString();
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
