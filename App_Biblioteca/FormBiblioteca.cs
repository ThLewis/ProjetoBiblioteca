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
    public partial class FormBiblioteca : Form
    {
        //Váriaveis que armazenam a linha selecionada em cada Tabela
        int codLivSel = -1;
        int codCliSel = -1;
        int codFunSel = -1;
        int codGenSel = -1;
        int codEdiSel = -1;
        int codAutSel = -1;
        int codEmpSel = -1;
        int codEmpLivSel = -1;

        //Váriáveis para armazenar o Nome do Item selecionado

        string nomeLivSel = "";
        string nomeCliSel = "";
        string nomeFunSel = "";
        string nomeGenSel = "";
        string nomeEdiSel = "";
        string nomeAutSel = "";

        //Métodos Construtor e Load do Form

        public FormBiblioteca()
        {
            InitializeComponent();
            listaTodosLivros();
            listaTodosClientes();
            listaTodosFuncionarios();
            listaTodosGeneros();
            listaTodasEditoras();
            listaTodosAutores();
            listaTodosEmprestimos();
        }

        //Métodos de Consulta

        private void consultarLivro()
        {

            MySqlConnection cnn = Conexao.getConnection();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Livro where tit_livro LIKE @nome";
            cmd.Parameters.AddWithValue("@nome", "%" + txtConsultaNomeLivro.Text + "%");
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            if (dtRecord.Rows.Count >= 1)
            {
                dgvClientes.DataSource = dtRecord;
            }
            else
            {
                MessageBox.Show("Cliente não encontrado", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (cnn != null)
            {
                cnn.Close();
            }

        }

        private void consultarCliente()
        {

            MySqlConnection cnn = Conexao.getConnection();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Cliente where nm_clien LIKE @nome";
            cmd.Parameters.AddWithValue("@nome", "%" + txtConsultaCliente.Text + "%");
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            if (dtRecord.Rows.Count >= 1)
            {
                dgvClientes.DataSource = dtRecord;
            }
            else
            {
                MessageBox.Show("Cliente não encontrado", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (cnn != null)
            {
                cnn.Close();
            }

        }

        private void consultarFuncionario()
        {

            MySqlConnection cnn = Conexao.getConnection();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Funcionario where nm_func LIKE @nome";
            cmd.Parameters.AddWithValue("@nome", "%" + txtConsultaFuncionario.Text + "%");
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            if (dtRecord.Rows.Count >= 1)
            {
                dgvFuncionarios.DataSource = dtRecord;
            }
            else
            {
                MessageBox.Show("Funcionario não encontrado", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (cnn != null)
            {
                cnn.Close();
            }

        }

        private void pesquisarGenero()
        {

            MySqlConnection cnn = Conexao.getConnection();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Genero where nm_gen LIKE @nome";
            cmd.Parameters.AddWithValue("@nome", "%" + txtPesquisarGenero.Text + "%");
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            if (dtRecord.Rows.Count >= 1)
            {
                dgvGeneros.DataSource = dtRecord;
            }
            else
            {
                MessageBox.Show("Gênero não encontrado", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (cnn != null)
            {
                cnn.Close();
            }

        }

        private void pesquisarEditora()
        {

            MySqlConnection cnn = Conexao.getConnection();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Editora where nm_editora LIKE @nome";
            cmd.Parameters.AddWithValue("@nome", "%" + txtPesquisarEditora.Text + "%");
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            if (dtRecord.Rows.Count >= 1)
            {
                dgvEditoras.DataSource = dtRecord;
            }
            else
            {
                MessageBox.Show("Editora não encontrado", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (cnn != null)
            {
                cnn.Close();
            }

        }

        private void pesquisarAutor()
        {

            MySqlConnection cnn = Conexao.getConnection();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Autor where nm_autor LIKE @nome";
            cmd.Parameters.AddWithValue("@nome", "%" + txtPesquisarAutor.Text + "%");
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            if (dtRecord.Rows.Count >= 1)
            {
                dgvAutores.DataSource = dtRecord;
            }
            else
            {
                MessageBox.Show("Autor não encontrado", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (cnn != null)
            {
                cnn.Close();
            }

        }

        //Métodos de Listagem

        private void listaTodosLivros()
        {

            MySqlConnection cnn = Conexao.getConnection();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Livro";
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            if (dtRecord.Rows.Count >= 1)
            {
                dgvLivros.DataSource = dtRecord;
            }
            else
            {
                MessageBox.Show("Livros não encontrados", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (cnn != null)
            {
                cnn.Close();
            }

        }

        private void listaTodosClientes()
        {

            MySqlConnection cnn = Conexao.getConnection();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Cliente";
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            if (dtRecord.Rows.Count >= 1)
            {
                dgvClientes.DataSource = dtRecord;
            }
            else
            {
                MessageBox.Show("Clientes não encontrados", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (cnn != null)
            {
                cnn.Close();
            }

        }

        private void listaTodosFuncionarios()
        {

            MySqlConnection cnn = Conexao.getConnection();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Funcionario";
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            if (dtRecord.Rows.Count >= 1)
            {
                dgvFuncionarios.DataSource = dtRecord;
            }
            else
            {
                MessageBox.Show("Funcionarios não encontrados", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (cnn != null)
            {
                cnn.Close();
            }

        }

        private void listaTodosGeneros()
        {

            MySqlConnection cnn = Conexao.getConnection();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Genero";
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            if (dtRecord.Rows.Count >= 1)
            {
                dgvGeneros.DataSource = dtRecord;
            }
            else
            {
                MessageBox.Show("Generos não encontrados", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (cnn != null)
            {
                cnn.Close();
            }

        }

        private void listaTodasEditoras()
        {

            MySqlConnection cnn = Conexao.getConnection();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Editora";
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            if (dtRecord.Rows.Count >= 1)
            {
                dgvEditoras.DataSource = dtRecord;
            }
            else
            {
                MessageBox.Show("Editoras não encontradas", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (cnn != null)
            {
                cnn.Close();
            }

        }

        private void listaTodosAutores()
        {

            MySqlConnection cnn = Conexao.getConnection();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Autor";
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            if (dtRecord.Rows.Count >= 1)
            {
                dgvAutores.DataSource = dtRecord;
            }
            else
            {
                MessageBox.Show("Autores não encontrados", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (cnn != null)
            {
                cnn.Close();
            }

        }

        private void listaTodosEmprestimos()
        {
            MySqlConnection cnn = Conexao.getConnection();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM Emprestimo";
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);

            DataTable dtRecord = new DataTable();
            sqlDataAdap.Fill(dtRecord);
            if (dtRecord.Rows.Count >= 1)
            {
                dgvEmprestimos.DataSource = dtRecord;
            }

            if (cnn != null)
            {
                cnn.Close();
            }
        }

        //Métodos dos Botões para Listar Registros nas Tabelas

        private void btnListarTodosLivros_Click(object sender, EventArgs e)
        {
            listaTodosLivros();
        }

        private void btnListaTodosClientes_Click(object sender, EventArgs e)
        {
            listaTodosClientes();
        }

        private void btnListarTodosFuncionarios_Click(object sender, EventArgs e)
        {
            listaTodosFuncionarios();
        }

        private void btnListarGeneros_Click(object sender, EventArgs e)
        {
            listaTodosGeneros();
        }

        private void btnListarEditoras_Click(object sender, EventArgs e)
        {
            listaTodasEditoras();
        }

        private void btnListarAutores_Click(object sender, EventArgs e)
        {
            listaTodosAutores();
        }

        //Métodos dos Botões para Consultar

        private void btnConsultaNomeLivro_Click(object sender, EventArgs e)
        {
            consultarLivro();
        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            consultarCliente();
        }

        private void btnConsultarFuncionario_Click(object sender, EventArgs e)
        {
            consultarFuncionario();
        }

        private void btnPesquisarGenero_Click(object sender, EventArgs e)
        {
            pesquisarGenero();
        }

        private void btnPesquisarEditora_Click(object sender, EventArgs e)
        {
            pesquisarEditora();
        }

        private void btnPesquisarAutor_Click(object sender, EventArgs e)
        {
            pesquisarAutor();
        }

        //Métodos de Cliques nas Células

        private void dgvLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvLivros.SelectedCells[0].RowIndex;
            codLivSel = Convert.ToInt32(dgvLivros.Rows[i].Cells[0].Value.ToString());
            nomeLivSel = dgvLivros.Rows[i].Cells[2].Value.ToString();
            btnAlterarLivro.Enabled = true;
            btnExcluirLivro.Enabled = true;
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvClientes.SelectedCells[0].RowIndex;
            codCliSel = Convert.ToInt32(dgvClientes.Rows[i].Cells[0].Value.ToString());
            nomeCliSel = dgvClientes.Rows[i].Cells[1].Value.ToString();
            btnAlterarCliente.Enabled = true;
            btnExcluirCliente.Enabled = true;
        }

        private void dgvFuncionarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvFuncionarios.SelectedCells[0].RowIndex;
            codFunSel = Convert.ToInt32(dgvFuncionarios.Rows[i].Cells[0].Value.ToString());
            nomeFunSel = dgvFuncionarios.Rows[i].Cells[1].Value.ToString();
            btnAlterarFuncionario.Enabled = true;
            btnExcluirFuncionario.Enabled = true;
        }

        private void dgvGeneros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvGeneros.SelectedCells[0].RowIndex;
            codGenSel = Convert.ToInt32(dgvGeneros.Rows[i].Cells[0].Value.ToString());
            nomeGenSel = dgvGeneros.Rows[i].Cells[1].Value.ToString();
            btnAlterarGenero.Enabled = true;
            btnExcluirGenero.Enabled = true;
        }

        private void dgvEditoras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvEditoras.SelectedCells[0].RowIndex;
            codEdiSel = Convert.ToInt32(dgvEditoras.Rows[i].Cells[0].Value.ToString());
            nomeEdiSel = dgvEditoras.Rows[i].Cells[1].Value.ToString();
            btnAlterarEditora.Enabled = true;
            btnExcluirEditora.Enabled = true;
        }

        private void dgvAutores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvAutores.SelectedCells[0].RowIndex;
            codAutSel = Convert.ToInt32(dgvAutores.Rows[i].Cells[0].Value.ToString());
            nomeAutSel = dgvAutores.Rows[i].Cells[1].Value.ToString();
            btnAlterarAutor.Enabled = true;
            btnExcluirAutor.Enabled = true;
        }

        private void dgvEmprestimos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvEmprestimos.SelectedCells[0].RowIndex;
            codEmpSel = Convert.ToInt32(dgvEmprestimos.Rows[i].Cells[0].Value.ToString());
            codEmpLivSel = Convert.ToInt32(dgvEmprestimos.Rows[i].Cells[3].Value.ToString());
            if (dgvEmprestimos.Rows[i].Cells[5].Value.ToString() == "N")
            {
                btnFinalizarEmprestimo.Enabled = true;
            }

        }

        //Métodos dos Botões de Cadastro

        private void btnNovoLivro_Click(object sender, EventArgs e)
        {
            FormLivro frmLivro = new FormLivro();
            frmLivro.ShowDialog();
            listaTodosLivros();
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            FormCliente frmNovoCliente = new FormCliente();
            frmNovoCliente.ShowDialog();
            listaTodosClientes();
        }

        private void btnNovoFuncionario_Click(object sender, EventArgs e)
        {
            FormFuncionario frmFuncionario = new FormFuncionario();
            frmFuncionario.ShowDialog();
            listaTodosFuncionarios();
        }

        private void btnNovoGenero_Click(object sender, EventArgs e)
        {
            FormGenero frmGenero = new FormGenero();
            frmGenero.ShowDialog();
            listaTodosGeneros();
        }

        private void btnNovaEditora_Click(object sender, EventArgs e)
        {
            FormEditora frmEditora = new FormEditora();
            frmEditora.ShowDialog();
            listaTodasEditoras();
        }

        private void btnNovoAutor_Click(object sender, EventArgs e)
        {
            FormAutor frmAutor = new FormAutor();
            frmAutor.ShowDialog();
            listaTodosAutores();
        }

        private void btnNovoEmprestimo_Click(object sender, EventArgs e)
        {
            FormEmprestimo frmEmprestimo = new FormEmprestimo();
            frmEmprestimo.ShowDialog();
            listaTodosEmprestimos();
        }

        //Métodos dos Botões de Alteração

        private void btnAlterarLivro_Click(object sender, EventArgs e)
        {
            FormLivro frmLivro = new FormLivro(codLivSel);
            frmLivro.ShowDialog();
            listaTodosLivros();
            resetSelecaoLivro();
        }

        private void btnAlterarCliente_Click(object sender, EventArgs e)
        {
            FormCliente frmCliente = new FormCliente(codCliSel);
            frmCliente.ShowDialog();
            listaTodosClientes();
            resetSelecaoCliente();
        }

        private void btnAlterarFuncionario_Click(object sender, EventArgs e)
        {
            FormFuncionario frmFuncionario = new FormFuncionario(codFunSel);
            frmFuncionario.ShowDialog();
            listaTodosFuncionarios();
            resetSelecaoFuncionario();
        }

        private void btnAlterarGenero_Click(object sender, EventArgs e)
        {
            FormGenero frmGenero = new FormGenero(codGenSel);
            frmGenero.ShowDialog();
            listaTodosGeneros();
            resetSelecaoGenero();
        }

        private void btnAlterarEditora_Click(object sender, EventArgs e)
        {
            FormEditora frmEditora = new FormEditora(codEdiSel);
            frmEditora.ShowDialog();
            listaTodasEditoras();
            resetSelecaoEditora();
        }

        private void btnAlterarAutor_Click(object sender, EventArgs e)
        {
            FormAutor frmAutor = new FormAutor(codAutSel);
            frmAutor.ShowDialog();
            listaTodosAutores();
            resetSelecaoAutor();
        }

        //Métodos de Botões de Exclusão

        private void btnExcluirLivro_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("O Livro " + nomeLivSel + "  será excluído permanentemente. Deseja excluir?", "Sistema Biblioteca", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlQuery;

                MySqlConnection cnn = Conexao.getConnection();

                sqlQuery = "DELETE FROM Livro WHERE cod_livro = @cod";

                try
                {
                    cnn.Open();

                    MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                    cmd.Parameters.Add(new MySqlParameter("@cod", codLivSel));

                    limparAssosAutores();

                    limparAssosGeneros();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Livro excluido com sucesso", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    listaTodosLivros();

                    resetSelecaoLivro();

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
        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("O Cliente " + nomeCliSel + "  será excluído permanentemente. Deseja excluir?", "Sistema Biblioteca", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlQuery;

                MySqlConnection cnn = Conexao.getConnection();

                sqlQuery = "DELETE FROM Cliente WHERE cod_clien = @cod";

                try
                {
                    cnn.Open();

                    MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                    cmd.Parameters.Add(new MySqlParameter("@cod", codCliSel));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cliente excluido com sucesso", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    listaTodosClientes();

                    resetSelecaoCliente();

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
        }

        private void btnExcluirFuncionario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("O Funcionario " + nomeFunSel + " será excluído permanentemente. Deseja excluir?", "Sistema Biblioteca", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlQuery;

                MySqlConnection cnn = Conexao.getConnection();

                sqlQuery = "DELETE FROM Funcionario WHERE cod_func = @cod";

                try
                {
                    cnn.Open();

                    MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                    cmd.Parameters.Add(new MySqlParameter("@cod", codFunSel));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Funcionario excluido com sucesso", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    listaTodosFuncionarios();

                    resetSelecaoFuncionario();

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
        }

        private void btnExcluirGenero_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("O Gênero " + nomeGenSel + " será excluído permanentemente. Deseja excluir?", "Sistema Biblioteca", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlQuery;

                MySqlConnection cnn = Conexao.getConnection();

                sqlQuery = "DELETE FROM Genero WHERE cod_gen = @cod";

                try
                {
                    cnn.Open();

                    MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                    cmd.Parameters.Add(new MySqlParameter("@cod", codGenSel));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Gênero excluido com sucesso", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    listaTodosGeneros();

                    resetSelecaoGenero();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gênero ainda está associado a outros livros. Não será possivel excluir!", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnExcluirEditora_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("A Editora " + nomeEdiSel + "  será excluída permanentemente. Deseja excluir?", "Sistema Biblioteca", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlQuery;

                MySqlConnection cnn = Conexao.getConnection();

                sqlQuery = "DELETE FROM Editora WHERE cod_editora = @cod";

                try
                {
                    cnn.Open();

                    MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                    cmd.Parameters.Add(new MySqlParameter("@cod", codEdiSel));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Editora excluida com sucesso", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    listaTodasEditoras();

                    resetSelecaoEditora();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Editora ainda está associada a outros livros. Não será possivel excluir!", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnExcluirAutor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("O Autor " + nomeAutSel + "  será excluído permanentemente. Deseja excluir?", "Sistema Biblioteca", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sqlQuery;

                MySqlConnection cnn = Conexao.getConnection();

                sqlQuery = "DELETE FROM Autor WHERE cod_autor = @cod";

                try
                {
                    cnn.Open();

                    MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                    cmd.Parameters.Add(new MySqlParameter("@cod", codAutSel));

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Autor excluido com sucesso", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    listaTodosAutores();

                    resetSelecaoAutor();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Autor ainda está associado a outros livros. Não será possivel excluir!", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        //Métodos para Limpar a Seleção de Registros

        private void resetSelecaoLivro()
        {
            btnAlterarLivro.Enabled = false;
            btnExcluirLivro.Enabled = false;
        }

        private void resetSelecaoCliente()
        {
            btnAlterarCliente.Enabled = false;
            btnExcluirCliente.Enabled = false;
        }

        private void resetSelecaoFuncionario()
        {
            btnAlterarFuncionario.Enabled = false;
            btnExcluirFuncionario.Enabled = false;
        }

        private void resetSelecaoGenero()
        {
            btnAlterarGenero.Enabled = false;
            btnExcluirGenero.Enabled = false;
        }

        private void resetSelecaoEditora()
        {
            btnAlterarEditora.Enabled = false;
            btnExcluirEditora.Enabled = false;
        }

        private void resetSelecaoAutor()
        {
            btnAlterarAutor.Enabled = false;
            btnExcluirAutor.Enabled = false;
        }

        private void resetSelecaoEmprestimo()
        {
            btnFinalizarEmprestimo.Enabled = false;
        }

        //Métodos específicos para Livro

        private void limparAssosGeneros()
        {
            string sqlQuery;

            MySqlConnection cnn = Conexao.getConnection();

            sqlQuery = "DELETE FROM GenLivro WHERE cod_liv = @cod";

            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                cmd.Parameters.Add(new MySqlParameter("@cod", codLivSel));

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Limpar as Associações dos Generos", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (cnn != null)
                {
                    cnn.Close();
                }
            }
        }

        private void limparAssosAutores()
        {
            string sqlQuery;

            MySqlConnection cnn = Conexao.getConnection();

            sqlQuery = "DELETE FROM Autorlivro WHERE cod_li = @cod";

            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                cmd.Parameters.Add(new MySqlParameter("@cod", codLivSel));

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Limpar as Associações dos Autores", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (cnn != null)
                {
                    cnn.Close();
                }
            }
        }

        //Métodos específicos para Emprestimo

        private void finalizaEmprestimo()
        {
            string sqlQuery;

            MySqlConnection cnn = Conexao.getConnection();

            sqlQuery = "UPDATE Emprestimo SET emp_finalizado = 'S' WHERE cod_empres = @cod";

            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                cmd.Parameters.Add(new MySqlParameter("@cod", codEmpSel));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Empréstimo finalizado com sucesso", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);

                listaTodosEmprestimos();

                resetSelecaoEmprestimo();

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

        private void disponibilizaLivro()
        {
            string sqlQuery;

            MySqlConnection cnn = Conexao.getConnection();

            sqlQuery = "UPDATE Livro SET dispon = 'S' WHERE cod_livro = @cod";

            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                cmd.Parameters.Add(new MySqlParameter("@cod", codEmpLivSel));

                cmd.ExecuteNonQuery();

                listaTodosLivros();

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

        //Método de Finalizar Empréstimo

        private void btnFinalizarEmprestimo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Empréstimo de Numero " + codEmpSel + "  será finalizado. Deseja prosseguir?", "Sistema Biblioteca", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                finalizaEmprestimo();
                disponibilizaLivro();
                resetSelecaoEmprestimo();
                listaTodosEmprestimos();
            }
        }

    }
}

