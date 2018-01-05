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
    public partial class FormLivro : Form
    {
        List<Autor> autores = new List<Autor>();
        List<Genero> generos = new List<Genero>();
        List<Editora> editoras = new List<Editora>();
        int cod_l = -1;


        public FormLivro()
        {
            InitializeComponent();
            preencheListasLivro();
        }

        public FormLivro(int cod)
        {
            InitializeComponent();
            preencheListasLivro();

            this.Text = "Alterar Dados do Livro";
            btnCadastrarLivro.Visible = false;
            btnAlterarDados.Visible = true;

            cod_l = cod;
            getDadosLivro();
            checkAutores();
            checkGeneros();
        }

        private void btnCadastrarLivro_Click(object sender, EventArgs e)
        {
            if (verificaCampos())
            {
                cadastraLivro();
                associaLivro();
                this.Close();
            }
        }

        private List<Autor> listaAutores()
        {
            List<Autor> autores = new List<Autor>();

            MySqlConnection cnn = Conexao.getConnection();

            MySqlDataReader dtr = null;

            string sqlQuery = "SELECT cod_autor, nm_autor from Autor";

            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                dtr = cmd.ExecuteReader();

                while (dtr.Read())
                {
                    Autor at = new Autor(Convert.ToInt32(dtr["cod_autor"]), dtr["nm_autor"].ToString());
                    autores.Add(at);
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
            return autores;
        }

        private List<Genero> listaGeneros()
        {
            List<Genero> generos = new List<Genero>();

            MySqlConnection cnn = Conexao.getConnection();

            MySqlDataReader dtr = null;

            string sqlQuery = "SELECT * from Genero";

            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                dtr = cmd.ExecuteReader();

                while (dtr.Read())
                {
                    Genero gn = new Genero(Convert.ToInt32(dtr["cod_gen"]), dtr["nm_gen"].ToString());
                    generos.Add(gn);
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
            return generos;
        }

        private List<Editora> listaEditoras()
        {
            List<Editora> editoras = new List<Editora>();

            MySqlConnection cnn = Conexao.getConnection();

            MySqlDataReader dtr = null;

            string sqlQuery = "SELECT * from Editora";

            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                dtr = cmd.ExecuteReader();

                while (dtr.Read())
                {
                    Editora ed = new Editora(Convert.ToInt32(dtr["cod_editora"]), dtr["nm_editora"].ToString(), dtr["end_editora"].ToString());
                    editoras.Add(ed);
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
            return editoras;
        }

        private void preencheListasLivro()
        {
            ckListBxAutores.Items.Clear();
            ckLstBxGenero.Items.Clear();
            cbxEditora.Items.Clear();

            autores = listaAutores();
            generos = listaGeneros();
            editoras = listaEditoras();

            foreach (Autor a in autores)
            {
                ckListBxAutores.Items.Add(a.nm_autor);
            }

            foreach (Genero g in generos)
            {
                ckLstBxGenero.Items.Add(g.nm_gen);
            }

            foreach (Editora e in editoras)
            {
                cbxEditora.Items.Add(e.nm_editora);
            }
        }

        private void btnNovoAutor_Click(object sender, EventArgs e)
        {
            FormAutor frmNovoAutor = new FormAutor();
            frmNovoAutor.ShowDialog();
            preencheListasLivro();
        }

        private void btnNovoGenero_Click(object sender, EventArgs e)
        {
            FormGenero frmNovoGenero = new FormGenero();
            frmNovoGenero.ShowDialog();
            preencheListasLivro();
        }

        private void btnNovaEditora_Click(object sender, EventArgs e)
        {
            FormEditora frmNovaEditora = new FormEditora();
            frmNovaEditora.ShowDialog();
            preencheListasLivro();
        }

        private void btnLimparCadLivro_Click(object sender, EventArgs e)
        {
            txtNomeLivro.Clear();
            mskAnoPublicacao.Clear();
            mskISBN.Clear();
            rtxtDesc.Clear();
            ckListBxAutores.ClearSelected();
            ckLstBxGenero.ClearSelected();
            cbxEditora.SelectedIndex = -1;
        }

        private bool verificaCampos()
        {
            bool verificado = true;
            if (txtNomeLivro.Text == "")
            {
                MessageBox.Show("Insira o Nome do Livro", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNomeLivro.Focus();
                verificado = false;
            }
            else if (!mskAnoPublicacao.MaskFull)
            {
                MessageBox.Show("Insira o Ano de Publicação do Livro", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskAnoPublicacao.Focus();
                verificado = false;
            }
            else if (!mskISBN.MaskFull)
            {
                MessageBox.Show("Insira o ISBN do Livro", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mskISBN.Focus();
                verificado = false;
            }
            else if (ckListBxAutores.SelectedItems.Count < 1)
            {
                MessageBox.Show("Selecione um ou mais Autores", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
                verificado = false;
            }
            else if (ckLstBxGenero.SelectedItems.Count < 1)
            {
                MessageBox.Show("Selecione um ou mais Gêneros", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
                verificado = false;
            }
            else if (cbxEditora.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um Gêmero", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
                verificado = false;
            }

            return verificado;
        }

        private void cadastraLivro()
        {
            string sqlQuery;

            MySqlConnection cnn = Conexao.getConnection();

            sqlQuery = "INSERT INTO Livro(isbn, tit_livro, ano, dispon, descr, cod_edit) VALUES (@isbn, @nome, @ano, 'S', @desc, @cod_edit)";


            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                cmd.Parameters.Add(new MySqlParameter("@isbn", mskISBN.Text));
                cmd.Parameters.Add(new MySqlParameter("@nome", txtNomeLivro.Text));
                cmd.Parameters.Add(new MySqlParameter("@ano", mskAnoPublicacao.Text));
                cmd.Parameters.Add(new MySqlParameter("@desc", rtxtDesc.Text));
                cmd.Parameters.Add(new MySqlParameter("@cod_edit", getCodEditora()));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Livro cadastrado com sucesso", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void associaLivro()
        {
            List<int> cod_autores = new List<int>();
            List<int> cod_generos = new List<int>();

            foreach (string a in ckListBxAutores.CheckedItems)
            {
                foreach (Autor at in autores)
                {
                    if (at.nm_autor == a)
                    {
                        cod_autores.Add(at.cod_autor);
                    }
                }
            }

            foreach (string g in ckLstBxGenero.CheckedItems)
            {
                foreach (Genero gn in generos)
                {
                    if (gn.nm_gen == g)
                    {
                        cod_generos.Add(gn.cod_gen);
                    }
                }
            }

            associaAutores(cod_autores, getCodLivro());
            associaGeneros(cod_generos, getCodLivro());
        }

        private int getCodLivro()
        {
            int cod = -1;

            MySqlConnection cnn = Conexao.getConnection();

            MySqlDataReader dtr = null;

            string sqlQuery = "SELECT cod_livro from Livro where isbn = @isbn";

            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                cmd.Parameters.AddWithValue("@isbn", mskISBN.Text);

                dtr = cmd.ExecuteReader();

                if (dtr.Read())
                {
                    cod = Convert.ToInt32(dtr["cod_livro"]);
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

            return cod;
        }

        private int getCodEditora()
        {
            int cod = -1;

            MySqlConnection cnn = Conexao.getConnection();

            MySqlDataReader dtr = null;

            string sqlQuery = "SELECT cod_editora from Editora where nm_editora = @editora";

            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                cmd.Parameters.AddWithValue("@editora", cbxEditora.SelectedItem.ToString());

                dtr = cmd.ExecuteReader();

                if (dtr.Read())
                {
                    cod = Convert.ToInt32(dtr["cod_editora"]);
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

            return cod;
        }

        private void associaGeneros(List<int> generos, int cod_livro)
        {
            string sqlQuery;

            MySqlConnection cnn = Conexao.getConnection();

            sqlQuery = "INSERT INTO GenLivro VALUES (@cod_liv, @cod_genero)";

            foreach (int g in generos)
            {
                try
                {
                    cnn.Open();

                    MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                    cmd.Parameters.Add(new MySqlParameter("@cod_liv", cod_livro));
                    cmd.Parameters.Add(new MySqlParameter("@cod_genero", g));

                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Associar Generos", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void associaAutores(List<int> autores, int cod_livro)
        {
            string sqlQuery;

            MySqlConnection cnn = Conexao.getConnection();

            sqlQuery = "INSERT INTO Autorlivro VALUES (@cod_liv, @cod_autor)";

            foreach (int a in autores)
            {
                try
                {
                    cnn.Open();

                    MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                    cmd.Parameters.Add(new MySqlParameter("@cod_liv", cod_livro));
                    cmd.Parameters.Add(new MySqlParameter("@cod_autor", a));

                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao Associar Autores", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void getDadosLivro()
        {
            MySqlConnection cnn = Conexao.getConnection();

            MySqlDataReader dtr = null;

            string sqlQuery = "SELECT * from Livro where cod_livro = @cod";

            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                cmd.Parameters.AddWithValue("@cod", cod_l);

                dtr = cmd.ExecuteReader();

                if (dtr.Read())
                {
                    txtNomeLivro.Text = dtr["tit_livro"].ToString();
                    mskAnoPublicacao.Text = dtr["ano"].ToString();
                    mskISBN.Text = dtr["isbn"].ToString();
                    rtxtDesc.Text = dtr["descr"].ToString();
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

        private void limparAssosGeneros()
        {
            string sqlQuery;

            MySqlConnection cnn = Conexao.getConnection();

            sqlQuery = "DELETE FROM GenLivro WHERE cod_liv = @cod";

            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                cmd.Parameters.Add(new MySqlParameter("@cod", cod_l));

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

                cmd.Parameters.Add(new MySqlParameter("@cod", cod_l));

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

        private void checkAutores()
        {
            MySqlConnection cnn = Conexao.getConnection();

            MySqlDataReader dtr = null;

            string sqlQuery = "SELECT a.nm_autor from Autor a JOIN Autorlivro l ON a.cod_autor = l.cod_aut where cod_li = @cod";

            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                cmd.Parameters.AddWithValue("@cod", cod_l);

                dtr = cmd.ExecuteReader();

                while (dtr.Read())
                {
                    int index = ckListBxAutores.Items.IndexOf(dtr["nm_autor"].ToString());

                    if (index >= 0)
                    {
                        ckListBxAutores.SetItemChecked(index, true);
                        ckListBxAutores.SelectedItems.Add(dtr["nm_autor"].ToString());
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

        private void checkGeneros()
        {
            MySqlConnection cnn = Conexao.getConnection();

            MySqlDataReader dtr = null;

            string sqlQuery = "SELECT g.nm_gen from Genero g JOIN GenLivro l ON g.cod_gen = l.cod_gene WHERE cod_liv = @cod";

            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                cmd.Parameters.AddWithValue("@cod", cod_l);

                dtr = cmd.ExecuteReader();

                while (dtr.Read())
                {
                    int index = ckLstBxGenero.Items.IndexOf(dtr["nm_gen"].ToString());

                    if (index >= 0)
                    {
                        ckLstBxGenero.SetItemChecked(index, true);
                        ckLstBxGenero.SelectedItems.Add(dtr["nm_gen"].ToString());
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

        private void checkEditora()
        {
            MySqlConnection cnn = Conexao.getConnection();

            MySqlDataReader dtr = null;

            string sqlQuery = "SELECT e.nm_editora from Editora e JOIN Livro l ON e.cod_editora = l.cod_edit WHERE cod_livro = @cod";

            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                cmd.Parameters.AddWithValue("@cod", cod_l);

                dtr = cmd.ExecuteReader();

                if (dtr.Read())
                {
                    cbxEditora.Text = dtr["nm_editora"].ToString();
                    cbxEditora.SelectedItem = dtr["nm_editora"].ToString();

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

        private void btnAlterarDados_Click(object sender, EventArgs e)
        {
            if (verificaCampos())
            {
                alteraLivro();
                limparAssosAutores();
                limparAssosGeneros();
                associaLivro();
                this.Close();
            }
        }

        private void alteraLivro()
        {
            string sqlQuery;

            MySqlConnection cnn = Conexao.getConnection();

            sqlQuery = "UPDATE Livro SET isbn = @isbn, tit_livro = @nome, ano = @ano, descr = @desc, cod_edit = @cod_edit WHERE cod_livro = @cod";

            try
            {
                cnn.Open();

                MySqlCommand cmd = new MySqlCommand(sqlQuery, cnn);

                cmd.Parameters.Add(new MySqlParameter("@isbn", mskISBN.Text));
                cmd.Parameters.Add(new MySqlParameter("@nome", txtNomeLivro.Text));
                cmd.Parameters.Add(new MySqlParameter("@ano", mskAnoPublicacao.Text));
                cmd.Parameters.Add(new MySqlParameter("@desc", rtxtDesc.Text));
                cmd.Parameters.Add(new MySqlParameter("@cod_edit", getCodEditora()));
                cmd.Parameters.Add(new MySqlParameter("@cod", cod_l));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Livro alterado com sucesso", "Sistema Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
}