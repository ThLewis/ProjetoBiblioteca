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
    public partial class FormEmprestimo : Form
    {
        //Váriaveis para as Datas de Retirada e Entrega

        DateTime dtHoje;
        DateTime dtEntrega;

        //Método Construtor

        public FormEmprestimo()
        {
            InitializeComponent();

            dtHoje = DateTime.Now;
            dtEntrega = dtHoje.AddDays(7);

            mskDtRetirada.Text = dtHoje.ToString();
            mskDtEntrega.Text = dtEntrega.ToString();
        }

        //Métodos dos Botões de Pesquisa Cliente e Livro

        private void btnPesquisaCliente_Click(object sender, EventArgs e)
        {
            if (rdbCodCliente.Checked)
            {
                procuraClienteCod();
            }
            else if (rdbCPFCliente.Checked)
            {
                if (mskPesquisaCliente.MaskFull)
                {
                    procuraClienteCPF();
                }
                else
                {
                    MessageBox.Show("Complete o campo do CPF", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (rdbNomeCliente.Checked)
            {
                procuraClienteNome();
            }
        }

        private void btnPesquisaLivro_Click(object sender, EventArgs e)
        {
            if (rdbCodLivro.Checked)
            {
                procuraLivroCod();
            }
            else if (rdbISBNLivro.Checked)
            {
                if (mskPesquisaLivro.MaskFull)
                {
                    procuraLivroISBN();
                }
                else
                {
                    MessageBox.Show("Complete o campo do ISBN", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                procuraLivroNome();
            }
        }

        //Método de Checagem do RadioButton Selecionado para a Pesquisa Cliente e Livro

        private void rdbCPFCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCPFCliente.Checked)
            {
                mskPesquisaCliente.Mask = "999,999,999-99";
                mskPesquisaCliente.Focus();
            }
            else
            {
                mskPesquisaCliente.Mask = "";
            }
        }

        private void rdbISBNLivro_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbISBNLivro.Checked)
            {
                mskPesquisaLivro.Mask = "999-9-99-999999-9";
                mskPesquisaLivro.Focus();
            }
            else
            {
                mskPesquisaLivro.Mask = "";
            }
        }

        //Métodos de Pesquisa do Cliente por Opção Escolhida

        private void procuraClienteCod()
        {
            MySqlConnection cnn = Conexao.getConnection();

            MySqlDataReader dtr = null;

            string sqlQuery = "SELECT cod_clien,nm_clien, cpf from Cliente where cod_clien = @cod";

            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                cmd.Parameters.AddWithValue("@cod", Convert.ToInt32(mskPesquisaCliente.Text));

                dtr = cmd.ExecuteReader();

                if (dtr.Read())
                {
                    if (!checaPendenciasCliente(Convert.ToInt32(dtr["cod_clien"].ToString())))
                    {
                        txtRespCodCliente.Text = dtr["cod_clien"].ToString();
                        txtRespNomeCliente.Text = dtr["nm_clien"].ToString();
                        txtRespCPFCliente.Text = dtr["cpf"].ToString();
                        liberaEmprestimo();
                    }
                }
                else
                {
                    MessageBox.Show("Cliente não Encontrado", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRespCodCliente.Clear();
                    txtRespNomeCliente.Clear();
                    txtRespCPFCliente.Clear();
                    liberaEmprestimo();
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

        private void procuraClienteNome()
        {
            MySqlConnection cnn = Conexao.getConnection();

            MySqlDataReader dtr = null;

            string sqlQuery = "SELECT cod_clien,nm_clien, cpf from Cliente where nm_clien LIKE @nome";

            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);


                cmd.Parameters.AddWithValue("@nome", "%" + mskPesquisaCliente.Text + "%");

                dtr = cmd.ExecuteReader();

                if (dtr.Read())
                {
                    if (!checaPendenciasCliente(Convert.ToInt32(dtr["cod_clien"].ToString())))
                    {
                        txtRespCodCliente.Text = dtr["cod_clien"].ToString();
                        txtRespNomeCliente.Text = dtr["nm_clien"].ToString();
                        txtRespCPFCliente.Text = dtr["cpf"].ToString();
                        liberaEmprestimo();
                    }
                }
                else
                {
                    MessageBox.Show("Cliente não Encontrado", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRespCodCliente.Clear();
                    txtRespNomeCliente.Clear();
                    txtRespCPFCliente.Clear();
                    liberaEmprestimo();
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

        private void procuraClienteCPF()
        {
            MySqlConnection cnn = Conexao.getConnection();

            MySqlDataReader dtr = null;

            string sqlQuery = "SELECT cod_clien,nm_clien,cpf from Cliente where cpf = @cpf";

            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                cmd.Parameters.AddWithValue("@cpf", mskPesquisaCliente.Text);

                dtr = cmd.ExecuteReader();

                if (dtr.Read())
                {
                    if (!checaPendenciasCliente(Convert.ToInt32(dtr["cod_clien"].ToString())))
                    {
                        txtRespCodCliente.Text = dtr["cod_clien"].ToString();
                        txtRespNomeCliente.Text = dtr["nm_clien"].ToString();
                        txtRespCPFCliente.Text = dtr["cpf"].ToString();
                        liberaEmprestimo();
                    }
                }
                else
                {
                    MessageBox.Show("Cliente não Encontrado", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRespCodCliente.Clear();
                    txtRespNomeCliente.Clear();
                    txtRespCPFCliente.Clear();
                    liberaEmprestimo();
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

        //Métodos de Pesquisa do Livro por Opção Escolhida

        private void procuraLivroCod()
        {
            MySqlConnection cnn = Conexao.getConnection();

            MySqlDataReader dtr = null;

            string sqlQuery = "SELECT cod_livro,tit_livro, isbn from Livro where cod_livro = @cod";

            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                cmd.Parameters.AddWithValue("@cod", Convert.ToInt32(mskPesquisaLivro.Text));

                dtr = cmd.ExecuteReader();

                if (dtr.Read())
                {
                    if (checaDisponiblidadeLivro(Convert.ToInt32(dtr["cod_livro"].ToString())))
                    {
                        txtRespCodLivro.Text = dtr["cod_livro"].ToString();
                        txtRespTituloLivro.Text = dtr["tit_livro"].ToString();
                        txtRespISBNLivro.Text = dtr["isbn"].ToString();
                        liberaEmprestimo();
                    }
                }
                else
                {
                    MessageBox.Show("Cliente não Encontrado", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRespCodLivro.Clear();
                    txtRespISBNLivro.Clear();
                    txtRespISBNLivro.Clear();
                    liberaEmprestimo();
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

        private void procuraLivroNome()
        {
            MySqlConnection cnn = Conexao.getConnection();

            MySqlDataReader dtr = null;

            string sqlQuery = "SELECT cod_livro,tit_livro, isbn from Livro where tit_livro = @tit";

            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                cmd.Parameters.AddWithValue("@tit", mskPesquisaLivro.Text);

                dtr = cmd.ExecuteReader();

                if (dtr.Read())
                {
                    if (checaDisponiblidadeLivro(Convert.ToInt32(dtr["cod_livro"].ToString())))
                    {
                        txtRespCodLivro.Text = dtr["cod_livro"].ToString();
                        txtRespTituloLivro.Text = dtr["tit_livro"].ToString();
                        txtRespISBNLivro.Text = dtr["isbn"].ToString();
                        liberaEmprestimo();
                    }
                }
                else
                {
                    MessageBox.Show("Livro não Encontrado", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRespCodLivro.Clear();
                    txtRespISBNLivro.Clear();
                    txtRespISBNLivro.Clear();
                    liberaEmprestimo();
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

        private void procuraLivroISBN()
        {
            MySqlConnection cnn = Conexao.getConnection();

            MySqlDataReader dtr = null;

            string sqlQuery = "SELECT cod_livro,tit_livro, isbn from Livro where isbn = @isbn";

            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                cmd.Parameters.AddWithValue("@isbn", mskPesquisaLivro.Text);

                dtr = cmd.ExecuteReader();

                if (dtr.Read())
                {
                    if (checaDisponiblidadeLivro(Convert.ToInt32(dtr["cod_livro"].ToString())))
                    {
                        txtRespCodLivro.Text = dtr["cod_livro"].ToString();
                        txtRespTituloLivro.Text = dtr["tit_livro"].ToString();
                        txtRespISBNLivro.Text = dtr["isbn"].ToString();
                        liberaEmprestimo();
                    }
                }
                else
                {
                    MessageBox.Show("Livro não Encontrado", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRespCodLivro.Clear();
                    txtRespISBNLivro.Clear();
                    txtRespISBNLivro.Clear();
                    liberaEmprestimo();
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

        //Método de Checagem de Pendencias do Cliente

        private bool checaPendenciasCliente(int cod_cli)
        {
            MySqlConnection cnn = Conexao.getConnection();

            MySqlDataReader dtr = null;

            bool pendencia = false;

            string sqlQuery = "SELECT c.nm_clien, l.tit_livro, e.emp_finalizado from Emprestimo e JOIN Livro l ON (e.cod_livr = l.cod_livro) JOIN Cliente c ON (e.cod_cli = c.cod_clien) where e.cod_cli = @cod";

            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                cmd.Parameters.AddWithValue("@cod", cod_cli);

                dtr = cmd.ExecuteReader();

                if (dtr.Read())
                {
                    if (dtr["emp_finalizado"].ToString() == "N")
                    {
                        MessageBox.Show("Livro " + dtr["tit_livro"].ToString() + " não Devolvido por: " + dtr["nm_clien"].ToString() + "\n" +
                                        "Pendência deve ser resolvida para continuar operação!"
                                        , "Pendência Encontrada!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        pendencia = true;
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

            return pendencia;
        }

        //Método de Checagem de Disponibilidade do Livro

        private bool checaDisponiblidadeLivro(int cod_livro)
        {
            MySqlConnection cnn = Conexao.getConnection();

            MySqlDataReader dtr = null;

            bool disp = true;

            string sqlQuery = "SELECT tit_livro, dispon from Livro where cod_livro = @cod";

            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                cmd.Parameters.AddWithValue("@cod", cod_livro);

                dtr = cmd.ExecuteReader();

                if (dtr.Read())
                {
                    if (dtr["dispon"].ToString() == "N")
                    {
                        MessageBox.Show("Livro " + dtr["tit_livro"].ToString() + " não está disponível para Empréstimo!"
                                        , "Pendência Encontrada!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        disp = false;
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

            return disp;
        }

        //Método de Liberação do Botão de Empréstimo

        private void liberaEmprestimo()
        {
            if (txtRespCodCliente.Text != "" && txtRespCodLivro.Text != "")
            {
                btnFinalizarEmprestimo.Enabled = true;
            }
            else
            {
                btnFinalizarEmprestimo.Enabled = false;
            }
        }

        //Método para Indisponibilizar o Livro a ser Emprestado

        private void pegaLivro(int cod)
        {
            string sqlQuery;

            MySqlConnection cnn = Conexao.getConnection();

            sqlQuery = "UPDATE Livro SET dispon = 'N' WHERE cod_livro = @cod";

            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                cmd.Parameters.Add(new MySqlParameter("@cod", cod));

                cmd.ExecuteNonQuery();

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

        //Método de Finalização do Empréstimo

        private void btnFinalizarEmprestimo_Click(object sender, EventArgs e)
        {
            string sqlQuery;

            MySqlConnection cnn = Conexao.getConnection();

            sqlQuery = "INSERT INTO Emprestimo(dt_retira, dt_devol, cod_livr, cod_cli, emp_finalizado) VALUES(@dt_ret,@dt_ent,@cod_livr,@cod_cli,'N')";

            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);
                cmd.Parameters.Add(new MySqlParameter("@dt_ret", dtHoje.ToString("yyyy-MM-dd HH:mm:ss")));
                cmd.Parameters.Add(new MySqlParameter("@dt_ent", dtEntrega.ToString("yyyy-MM-dd HH:mm:ss")));
                cmd.Parameters.Add(new MySqlParameter("@cod_livr", Convert.ToInt32(txtRespCodLivro.Text)));
                cmd.Parameters.Add(new MySqlParameter("@cod_cli", Convert.ToInt32(txtRespCodCliente.Text)));

                cmd.ExecuteNonQuery();

                pegaLivro(Convert.ToInt32(txtRespCodLivro.Text));

                MessageBox.Show("Empréstimo concluído com sucesso \n Data de Entrega: " + mskDtEntrega.Text, "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();

            }
            catch (Exception ex)
            {
                //MessageBox.Show("Erro ao Concluir Empréstimo", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (cnn != null)
                {
                    cnn.Close();
                }
            }
        }
    }
}
