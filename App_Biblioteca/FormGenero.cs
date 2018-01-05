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
    public partial class FormGenero : Form
    {
        //Váriavel de Código da Editora

        int codGen = -1;

        //Métodos Construtores

        public FormGenero()
        {
            InitializeComponent();
        }

        public FormGenero(int cod)
        {
            InitializeComponent();

            this.Text = "Alterar Dados do Genero";
            btnCadastrarGenero.Visible = false;
            btnAlterarDadosGenero.Visible = true;

            codGen = cod;
            getDadosGenero();
        }

        //Métodos dos Cliques dos Botões

        private void btnCadastrarGenero_Click(object sender, EventArgs e)
        {
            if (txtNomeGenero.Text != "")
            {
                string sqlQuery;

                MySqlConnection cnn = Conexao.getConnection();

                sqlQuery = "INSERT INTO Genero(nm_gen) VALUES (@nome)";

                try
                {
                    cnn.Open();

                    MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                    cmd.Parameters.Add(new MySqlParameter("@nome", txtNomeGenero.Text));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Gênero cadastrado com sucesso", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gênero já existente", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Insira o Nome do Gênero", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAlterarDadosGenero_Click(object sender, EventArgs e)
        {
            if (txtNomeGenero.Text != "")
            {
                string sqlQuery;

                MySqlConnection cnn = Conexao.getConnection();

                sqlQuery = "UPDATE Genero SET nm_gen = @nome where cod_gen = @cod";

                try
                {
                    cnn.Open();

                    MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                    cmd.Parameters.Add(new MySqlParameter("@nome", txtNomeGenero.Text));
                    cmd.Parameters.Add(new MySqlParameter("@cod", codGen));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Gênero alterado com sucesso", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                MessageBox.Show("Insira o Nome do Gênero", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Métodos específicos

        private void getDadosGenero()
        {
            MySqlConnection cnn = Conexao.getConnection();

            MySqlDataReader dtr = null;

            string sqlQuery = "SELECT * from Genero where cod_gen = @cod";

            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                cmd.Parameters.AddWithValue("@cod", codGen);

                dtr = cmd.ExecuteReader();

                if (dtr.Read())
                {
                    txtNomeGenero.Text = dtr["nm_gen"].ToString();
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
