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
    public partial class FormAutor : Form
    {
        //Váriavel de Código da Editora

        int codAut = -1;

        //Métodos Construtores

        public FormAutor()
        {
            InitializeComponent();
        }

        public FormAutor(int cod)
        {
            InitializeComponent();

            this.Text = "Alterar Dados do Autor";
            btnCadastrarAutor.Visible = false;
            btnAlterarDadosAutor.Visible = true;

            codAut = cod;
            getDadosAutor();
        }

        //Métodos dos Cliques dos Botões

        private void btnCadastrarAutor_Click(object sender, EventArgs e)
        {
            if (txtNomeAutor.Text != "")
            {
                string sqlQuery;

                MySqlConnection cnn = Conexao.getConnection();

                sqlQuery = "INSERT INTO Autor(nm_autor,pais_ori) VALUES(@nome,@pais_ori)";

                try
                {
                    cnn.Open();

                    MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                    cmd.Parameters.Add(new MySqlParameter("@nome", txtNomeAutor.Text));
                    cmd.Parameters.Add(new MySqlParameter("@pais_ori", txtPaisOrigem.Text));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Autor cadastrado com sucesso", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Autor já existente", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Insira o Nome do Autor", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAlterarDadosAutor_Click(object sender, EventArgs e)
        {
            if (txtNomeAutor.Text != "")
            {
                string sqlQuery;

                MySqlConnection cnn = Conexao.getConnection();

                sqlQuery = "UPDATE Autor SET nm_autor = @nome, pais_ori = @end where cod_autor = @cod";

                try
                {
                    cnn.Open();

                    MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                    cmd.Parameters.Add(new MySqlParameter("@nome", txtNomeAutor.Text));
                    cmd.Parameters.Add(new MySqlParameter("@end", txtPaisOrigem.Text));
                    cmd.Parameters.Add(new MySqlParameter("@cod", codAut));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Autor alterado com sucesso", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        //Métodos específicos

        private void getDadosAutor()
        {
            MySqlConnection cnn = Conexao.getConnection();

            MySqlDataReader dtr = null;

            string sqlQuery = "SELECT * from Autor where cod_autor = @cod";

            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                cmd.Parameters.AddWithValue("@cod", codAut);

                dtr = cmd.ExecuteReader();

                if (dtr.Read())
                {
                    txtNomeAutor.Text = dtr["nm_autor"].ToString();
                    txtPaisOrigem.Text = dtr["pais_ori"].ToString();
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
