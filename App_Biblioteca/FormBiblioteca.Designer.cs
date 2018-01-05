namespace App_Biblioteca
{
    partial class FormBiblioteca
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabBiblioteca = new System.Windows.Forms.TabControl();
            this.tabLivros = new System.Windows.Forms.TabPage();
            this.pnlLivros = new System.Windows.Forms.Panel();
            this.btnListarTodosLivros = new System.Windows.Forms.Button();
            this.btnConsultaNomeLivro = new System.Windows.Forms.Button();
            this.lblConsultaNome = new System.Windows.Forms.Label();
            this.txtConsultaNomeLivro = new System.Windows.Forms.TextBox();
            this.btnExcluirLivro = new System.Windows.Forms.Button();
            this.btnAlterarLivro = new System.Windows.Forms.Button();
            this.btnNovoLivro = new System.Windows.Forms.Button();
            this.dgvLivros = new System.Windows.Forms.DataGridView();
            this.cod_livro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_edit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabClientes = new System.Windows.Forms.TabPage();
            this.pnlClientes = new System.Windows.Forms.Panel();
            this.btnListaTodosClientes = new System.Windows.Forms.Button();
            this.btnConsultarCliente = new System.Windows.Forms.Button();
            this.lblConsultaNomeCliente = new System.Windows.Forms.Label();
            this.txtConsultaCliente = new System.Windows.Forms.TextBox();
            this.btnExcluirCliente = new System.Windows.Forms.Button();
            this.btnAlterarCliente = new System.Windows.Forms.Button();
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.cod_clien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabFuncionarios = new System.Windows.Forms.TabPage();
            this.btnListarTodosFuncionarios = new System.Windows.Forms.Button();
            this.btnConsultarFuncionario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConsultaFuncionario = new System.Windows.Forms.TextBox();
            this.btnExcluirFuncionario = new System.Windows.Forms.Button();
            this.btnAlterarFuncionario = new System.Windows.Forms.Button();
            this.btnNovoFuncionario = new System.Windows.Forms.Button();
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.cod_func = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nm_func = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_func = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senha_func = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf_func = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_func = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel_func = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabGenerosAutoresEditoras = new System.Windows.Forms.TabPage();
            this.btnExcluirAutor = new System.Windows.Forms.Button();
            this.btnAlterarAutor = new System.Windows.Forms.Button();
            this.btnNovoAutor = new System.Windows.Forms.Button();
            this.btnListarAutores = new System.Windows.Forms.Button();
            this.btnExcluirEditora = new System.Windows.Forms.Button();
            this.btnAlterarEditora = new System.Windows.Forms.Button();
            this.btnNovaEditora = new System.Windows.Forms.Button();
            this.btnListarEditoras = new System.Windows.Forms.Button();
            this.btnExcluirGenero = new System.Windows.Forms.Button();
            this.btnAlterarGenero = new System.Windows.Forms.Button();
            this.btnNovoGenero = new System.Windows.Forms.Button();
            this.btnListarGeneros = new System.Windows.Forms.Button();
            this.btnPesquisarAutor = new System.Windows.Forms.Button();
            this.txtPesquisarAutor = new System.Windows.Forms.TextBox();
            this.btnPesquisarEditora = new System.Windows.Forms.Button();
            this.txtPesquisarEditora = new System.Windows.Forms.TextBox();
            this.btnPesquisarGenero = new System.Windows.Forms.Button();
            this.txtPesquisarGenero = new System.Windows.Forms.TextBox();
            this.dgvAutores = new System.Windows.Forms.DataGridView();
            this.cod_autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nm_autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pais_ori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEditoras = new System.Windows.Forms.DataGridView();
            this.cod_editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nm_editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGeneros = new System.Windows.Forms.DataGridView();
            this.cod_gen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nm_gen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabEmprestimos = new System.Windows.Forms.TabPage();
            this.btnFinalizarEmprestimo = new System.Windows.Forms.Button();
            this.btnNovoEmprestimo = new System.Windows.Forms.Button();
            this.dgvEmprestimos = new System.Windows.Forms.DataGridView();
            this.cod_empres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_retira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dt_devol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_livr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_cli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp_finalizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabBiblioteca.SuspendLayout();
            this.tabLivros.SuspendLayout();
            this.pnlLivros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).BeginInit();
            this.tabClientes.SuspendLayout();
            this.pnlClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.tabFuncionarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            this.tabGenerosAutoresEditoras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneros)).BeginInit();
            this.tabEmprestimos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabBiblioteca
            // 
            this.tabBiblioteca.Controls.Add(this.tabLivros);
            this.tabBiblioteca.Controls.Add(this.tabClientes);
            this.tabBiblioteca.Controls.Add(this.tabFuncionarios);
            this.tabBiblioteca.Controls.Add(this.tabGenerosAutoresEditoras);
            this.tabBiblioteca.Controls.Add(this.tabEmprestimos);
            this.tabBiblioteca.Location = new System.Drawing.Point(0, -1);
            this.tabBiblioteca.Name = "tabBiblioteca";
            this.tabBiblioteca.SelectedIndex = 0;
            this.tabBiblioteca.Size = new System.Drawing.Size(784, 564);
            this.tabBiblioteca.TabIndex = 9;
            // 
            // tabLivros
            // 
            this.tabLivros.Controls.Add(this.pnlLivros);
            this.tabLivros.Location = new System.Drawing.Point(4, 22);
            this.tabLivros.Name = "tabLivros";
            this.tabLivros.Padding = new System.Windows.Forms.Padding(3);
            this.tabLivros.Size = new System.Drawing.Size(776, 538);
            this.tabLivros.TabIndex = 0;
            this.tabLivros.Text = "Livros";
            this.tabLivros.UseVisualStyleBackColor = true;
            // 
            // pnlLivros
            // 
            this.pnlLivros.Controls.Add(this.btnListarTodosLivros);
            this.pnlLivros.Controls.Add(this.btnConsultaNomeLivro);
            this.pnlLivros.Controls.Add(this.lblConsultaNome);
            this.pnlLivros.Controls.Add(this.txtConsultaNomeLivro);
            this.pnlLivros.Controls.Add(this.btnExcluirLivro);
            this.pnlLivros.Controls.Add(this.btnAlterarLivro);
            this.pnlLivros.Controls.Add(this.btnNovoLivro);
            this.pnlLivros.Controls.Add(this.dgvLivros);
            this.pnlLivros.Location = new System.Drawing.Point(0, 0);
            this.pnlLivros.Name = "pnlLivros";
            this.pnlLivros.Size = new System.Drawing.Size(776, 538);
            this.pnlLivros.TabIndex = 1;
            // 
            // btnListarTodosLivros
            // 
            this.btnListarTodosLivros.Location = new System.Drawing.Point(374, 18);
            this.btnListarTodosLivros.Name = "btnListarTodosLivros";
            this.btnListarTodosLivros.Size = new System.Drawing.Size(75, 23);
            this.btnListarTodosLivros.TabIndex = 7;
            this.btnListarTodosLivros.Text = "Listar Todos";
            this.btnListarTodosLivros.UseVisualStyleBackColor = true;
            this.btnListarTodosLivros.Click += new System.EventHandler(this.btnListarTodosLivros_Click);
            // 
            // btnConsultaNomeLivro
            // 
            this.btnConsultaNomeLivro.Location = new System.Drawing.Point(293, 18);
            this.btnConsultaNomeLivro.Name = "btnConsultaNomeLivro";
            this.btnConsultaNomeLivro.Size = new System.Drawing.Size(75, 23);
            this.btnConsultaNomeLivro.TabIndex = 6;
            this.btnConsultaNomeLivro.Text = "Consultar";
            this.btnConsultaNomeLivro.UseVisualStyleBackColor = true;
            this.btnConsultaNomeLivro.Click += new System.EventHandler(this.btnConsultaNomeLivro_Click);
            // 
            // lblConsultaNome
            // 
            this.lblConsultaNome.AutoSize = true;
            this.lblConsultaNome.Location = new System.Drawing.Point(10, 23);
            this.lblConsultaNome.Name = "lblConsultaNome";
            this.lblConsultaNome.Size = new System.Drawing.Size(102, 13);
            this.lblConsultaNome.TabIndex = 5;
            this.lblConsultaNome.Text = "Pesquisa por Nome:";
            // 
            // txtConsultaNomeLivro
            // 
            this.txtConsultaNomeLivro.Location = new System.Drawing.Point(118, 20);
            this.txtConsultaNomeLivro.Name = "txtConsultaNomeLivro";
            this.txtConsultaNomeLivro.Size = new System.Drawing.Size(169, 20);
            this.txtConsultaNomeLivro.TabIndex = 4;
            // 
            // btnExcluirLivro
            // 
            this.btnExcluirLivro.Enabled = false;
            this.btnExcluirLivro.Location = new System.Drawing.Point(424, 494);
            this.btnExcluirLivro.Name = "btnExcluirLivro";
            this.btnExcluirLivro.Size = new System.Drawing.Size(125, 36);
            this.btnExcluirLivro.TabIndex = 3;
            this.btnExcluirLivro.Text = "Excluir Livro";
            this.btnExcluirLivro.UseVisualStyleBackColor = true;
            this.btnExcluirLivro.Click += new System.EventHandler(this.btnExcluirLivro_Click);
            // 
            // btnAlterarLivro
            // 
            this.btnAlterarLivro.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnAlterarLivro.Enabled = false;
            this.btnAlterarLivro.Location = new System.Drawing.Point(293, 494);
            this.btnAlterarLivro.Name = "btnAlterarLivro";
            this.btnAlterarLivro.Size = new System.Drawing.Size(125, 36);
            this.btnAlterarLivro.TabIndex = 2;
            this.btnAlterarLivro.Text = "Alterar Livro";
            this.btnAlterarLivro.UseVisualStyleBackColor = true;
            this.btnAlterarLivro.Click += new System.EventHandler(this.btnAlterarLivro_Click);
            // 
            // btnNovoLivro
            // 
            this.btnNovoLivro.Location = new System.Drawing.Point(162, 494);
            this.btnNovoLivro.Name = "btnNovoLivro";
            this.btnNovoLivro.Size = new System.Drawing.Size(125, 34);
            this.btnNovoLivro.TabIndex = 1;
            this.btnNovoLivro.Text = "Adicionar Novo Livro";
            this.btnNovoLivro.UseVisualStyleBackColor = true;
            this.btnNovoLivro.Click += new System.EventHandler(this.btnNovoLivro_Click);
            // 
            // dgvLivros
            // 
            this.dgvLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_livro,
            this.titulo,
            this.isbn,
            this.ano,
            this.dispon,
            this.descr,
            this.cod_edit});
            this.dgvLivros.Location = new System.Drawing.Point(13, 48);
            this.dgvLivros.MultiSelect = false;
            this.dgvLivros.Name = "dgvLivros";
            this.dgvLivros.ReadOnly = true;
            this.dgvLivros.Size = new System.Drawing.Size(746, 437);
            this.dgvLivros.TabIndex = 0;
            this.dgvLivros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLivros_CellContentClick);
            // 
            // cod_livro
            // 
            this.cod_livro.DataPropertyName = "cod_livro";
            this.cod_livro.HeaderText = "Cod. Livro";
            this.cod_livro.Name = "cod_livro";
            this.cod_livro.ReadOnly = true;
            this.cod_livro.Width = 40;
            // 
            // titulo
            // 
            this.titulo.DataPropertyName = "tit_livro";
            this.titulo.HeaderText = "Título";
            this.titulo.Name = "titulo";
            this.titulo.ReadOnly = true;
            this.titulo.Width = 250;
            // 
            // isbn
            // 
            this.isbn.DataPropertyName = "isbn";
            this.isbn.HeaderText = "ISBN";
            this.isbn.Name = "isbn";
            this.isbn.ReadOnly = true;
            this.isbn.Width = 150;
            // 
            // ano
            // 
            this.ano.DataPropertyName = "ano";
            this.ano.HeaderText = "Ano";
            this.ano.Name = "ano";
            this.ano.ReadOnly = true;
            // 
            // dispon
            // 
            this.dispon.DataPropertyName = "dispon";
            this.dispon.HeaderText = "Disponivel";
            this.dispon.Name = "dispon";
            this.dispon.ReadOnly = true;
            // 
            // descr
            // 
            this.descr.DataPropertyName = "descr";
            this.descr.HeaderText = "Descrição";
            this.descr.Name = "descr";
            this.descr.ReadOnly = true;
            // 
            // cod_edit
            // 
            this.cod_edit.DataPropertyName = "cod_edit";
            this.cod_edit.HeaderText = "Cod. Editora";
            this.cod_edit.Name = "cod_edit";
            this.cod_edit.ReadOnly = true;
            // 
            // tabClientes
            // 
            this.tabClientes.Controls.Add(this.pnlClientes);
            this.tabClientes.Location = new System.Drawing.Point(4, 22);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientes.Size = new System.Drawing.Size(776, 538);
            this.tabClientes.TabIndex = 1;
            this.tabClientes.Text = "Clientes";
            this.tabClientes.UseVisualStyleBackColor = true;
            // 
            // pnlClientes
            // 
            this.pnlClientes.Controls.Add(this.btnListaTodosClientes);
            this.pnlClientes.Controls.Add(this.btnConsultarCliente);
            this.pnlClientes.Controls.Add(this.lblConsultaNomeCliente);
            this.pnlClientes.Controls.Add(this.txtConsultaCliente);
            this.pnlClientes.Controls.Add(this.btnExcluirCliente);
            this.pnlClientes.Controls.Add(this.btnAlterarCliente);
            this.pnlClientes.Controls.Add(this.btnNovoCliente);
            this.pnlClientes.Controls.Add(this.dgvClientes);
            this.pnlClientes.Location = new System.Drawing.Point(0, 0);
            this.pnlClientes.Name = "pnlClientes";
            this.pnlClientes.Size = new System.Drawing.Size(776, 538);
            this.pnlClientes.TabIndex = 8;
            // 
            // btnListaTodosClientes
            // 
            this.btnListaTodosClientes.Location = new System.Drawing.Point(374, 18);
            this.btnListaTodosClientes.Name = "btnListaTodosClientes";
            this.btnListaTodosClientes.Size = new System.Drawing.Size(75, 23);
            this.btnListaTodosClientes.TabIndex = 7;
            this.btnListaTodosClientes.Text = "Listar Todos";
            this.btnListaTodosClientes.UseVisualStyleBackColor = true;
            this.btnListaTodosClientes.Click += new System.EventHandler(this.btnListaTodosClientes_Click);
            // 
            // btnConsultarCliente
            // 
            this.btnConsultarCliente.Location = new System.Drawing.Point(293, 18);
            this.btnConsultarCliente.Name = "btnConsultarCliente";
            this.btnConsultarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarCliente.TabIndex = 6;
            this.btnConsultarCliente.Text = "Consultar";
            this.btnConsultarCliente.UseVisualStyleBackColor = true;
            this.btnConsultarCliente.Click += new System.EventHandler(this.btnConsultarCliente_Click);
            // 
            // lblConsultaNomeCliente
            // 
            this.lblConsultaNomeCliente.AutoSize = true;
            this.lblConsultaNomeCliente.Location = new System.Drawing.Point(10, 23);
            this.lblConsultaNomeCliente.Name = "lblConsultaNomeCliente";
            this.lblConsultaNomeCliente.Size = new System.Drawing.Size(102, 13);
            this.lblConsultaNomeCliente.TabIndex = 5;
            this.lblConsultaNomeCliente.Text = "Pesquisa por Nome:";
            // 
            // txtConsultaCliente
            // 
            this.txtConsultaCliente.Location = new System.Drawing.Point(118, 20);
            this.txtConsultaCliente.Name = "txtConsultaCliente";
            this.txtConsultaCliente.Size = new System.Drawing.Size(169, 20);
            this.txtConsultaCliente.TabIndex = 4;
            // 
            // btnExcluirCliente
            // 
            this.btnExcluirCliente.Enabled = false;
            this.btnExcluirCliente.Location = new System.Drawing.Point(424, 494);
            this.btnExcluirCliente.Name = "btnExcluirCliente";
            this.btnExcluirCliente.Size = new System.Drawing.Size(125, 36);
            this.btnExcluirCliente.TabIndex = 3;
            this.btnExcluirCliente.Text = "Excluir Cliente";
            this.btnExcluirCliente.UseVisualStyleBackColor = true;
            this.btnExcluirCliente.Click += new System.EventHandler(this.btnExcluirCliente_Click);
            // 
            // btnAlterarCliente
            // 
            this.btnAlterarCliente.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnAlterarCliente.Enabled = false;
            this.btnAlterarCliente.Location = new System.Drawing.Point(293, 494);
            this.btnAlterarCliente.Name = "btnAlterarCliente";
            this.btnAlterarCliente.Size = new System.Drawing.Size(125, 36);
            this.btnAlterarCliente.TabIndex = 2;
            this.btnAlterarCliente.Text = "Alterar Cliente";
            this.btnAlterarCliente.UseVisualStyleBackColor = true;
            this.btnAlterarCliente.Click += new System.EventHandler(this.btnAlterarCliente_Click);
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.Location = new System.Drawing.Point(162, 494);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(125, 34);
            this.btnNovoCliente.TabIndex = 1;
            this.btnNovoCliente.Text = "Adicionar Novo Cliente";
            this.btnNovoCliente.UseVisualStyleBackColor = true;
            this.btnNovoCliente.Click += new System.EventHandler(this.btnNovoCliente_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_clien,
            this.nome,
            this.email,
            this.senha,
            this.cpf,
            this.end_cliente,
            this.telefone,
            this.sexo});
            this.dgvClientes.Location = new System.Drawing.Point(13, 48);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(746, 437);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick);
            // 
            // cod_clien
            // 
            this.cod_clien.DataPropertyName = "cod_clien";
            this.cod_clien.HeaderText = "Cod. Cliente";
            this.cod_clien.Name = "cod_clien";
            this.cod_clien.ReadOnly = true;
            this.cod_clien.Width = 50;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nm_clien";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // senha
            // 
            this.senha.DataPropertyName = "senha";
            this.senha.HeaderText = "Senha";
            this.senha.Name = "senha";
            this.senha.ReadOnly = true;
            // 
            // cpf
            // 
            this.cpf.DataPropertyName = "cpf";
            this.cpf.HeaderText = "CPF";
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
            // 
            // end_cliente
            // 
            this.end_cliente.DataPropertyName = "end_cliente";
            this.end_cliente.HeaderText = "Endereço";
            this.end_cliente.Name = "end_cliente";
            this.end_cliente.ReadOnly = true;
            // 
            // telefone
            // 
            this.telefone.DataPropertyName = "telefone";
            this.telefone.HeaderText = "Telefone";
            this.telefone.Name = "telefone";
            this.telefone.ReadOnly = true;
            // 
            // sexo
            // 
            this.sexo.DataPropertyName = "sexo";
            this.sexo.HeaderText = "Sexo";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            // 
            // tabFuncionarios
            // 
            this.tabFuncionarios.Controls.Add(this.btnListarTodosFuncionarios);
            this.tabFuncionarios.Controls.Add(this.btnConsultarFuncionario);
            this.tabFuncionarios.Controls.Add(this.label1);
            this.tabFuncionarios.Controls.Add(this.txtConsultaFuncionario);
            this.tabFuncionarios.Controls.Add(this.btnExcluirFuncionario);
            this.tabFuncionarios.Controls.Add(this.btnAlterarFuncionario);
            this.tabFuncionarios.Controls.Add(this.btnNovoFuncionario);
            this.tabFuncionarios.Controls.Add(this.dgvFuncionarios);
            this.tabFuncionarios.Location = new System.Drawing.Point(4, 22);
            this.tabFuncionarios.Name = "tabFuncionarios";
            this.tabFuncionarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabFuncionarios.Size = new System.Drawing.Size(776, 538);
            this.tabFuncionarios.TabIndex = 3;
            this.tabFuncionarios.Text = "Funcionários";
            this.tabFuncionarios.UseVisualStyleBackColor = true;
            // 
            // btnListarTodosFuncionarios
            // 
            this.btnListarTodosFuncionarios.Location = new System.Drawing.Point(374, 18);
            this.btnListarTodosFuncionarios.Name = "btnListarTodosFuncionarios";
            this.btnListarTodosFuncionarios.Size = new System.Drawing.Size(75, 23);
            this.btnListarTodosFuncionarios.TabIndex = 15;
            this.btnListarTodosFuncionarios.Text = "Listar Todos";
            this.btnListarTodosFuncionarios.UseVisualStyleBackColor = true;
            this.btnListarTodosFuncionarios.Click += new System.EventHandler(this.btnListarTodosFuncionarios_Click);
            // 
            // btnConsultarFuncionario
            // 
            this.btnConsultarFuncionario.Location = new System.Drawing.Point(293, 18);
            this.btnConsultarFuncionario.Name = "btnConsultarFuncionario";
            this.btnConsultarFuncionario.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarFuncionario.TabIndex = 14;
            this.btnConsultarFuncionario.Text = "Consultar";
            this.btnConsultarFuncionario.UseVisualStyleBackColor = true;
            this.btnConsultarFuncionario.Click += new System.EventHandler(this.btnConsultarFuncionario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Pesquisa por Nome:";
            // 
            // txtConsultaFuncionario
            // 
            this.txtConsultaFuncionario.Location = new System.Drawing.Point(118, 20);
            this.txtConsultaFuncionario.Name = "txtConsultaFuncionario";
            this.txtConsultaFuncionario.Size = new System.Drawing.Size(169, 20);
            this.txtConsultaFuncionario.TabIndex = 12;
            // 
            // btnExcluirFuncionario
            // 
            this.btnExcluirFuncionario.Enabled = false;
            this.btnExcluirFuncionario.Location = new System.Drawing.Point(424, 494);
            this.btnExcluirFuncionario.Name = "btnExcluirFuncionario";
            this.btnExcluirFuncionario.Size = new System.Drawing.Size(125, 36);
            this.btnExcluirFuncionario.TabIndex = 11;
            this.btnExcluirFuncionario.Text = "Excluir Funcionario";
            this.btnExcluirFuncionario.UseVisualStyleBackColor = true;
            this.btnExcluirFuncionario.Click += new System.EventHandler(this.btnExcluirFuncionario_Click);
            // 
            // btnAlterarFuncionario
            // 
            this.btnAlterarFuncionario.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnAlterarFuncionario.Enabled = false;
            this.btnAlterarFuncionario.Location = new System.Drawing.Point(293, 493);
            this.btnAlterarFuncionario.Name = "btnAlterarFuncionario";
            this.btnAlterarFuncionario.Size = new System.Drawing.Size(125, 36);
            this.btnAlterarFuncionario.TabIndex = 10;
            this.btnAlterarFuncionario.Text = "Alterar Funcionario";
            this.btnAlterarFuncionario.UseVisualStyleBackColor = true;
            this.btnAlterarFuncionario.Click += new System.EventHandler(this.btnAlterarFuncionario_Click);
            // 
            // btnNovoFuncionario
            // 
            this.btnNovoFuncionario.Location = new System.Drawing.Point(162, 494);
            this.btnNovoFuncionario.Name = "btnNovoFuncionario";
            this.btnNovoFuncionario.Size = new System.Drawing.Size(125, 34);
            this.btnNovoFuncionario.TabIndex = 9;
            this.btnNovoFuncionario.Text = "Adicionar Novo Funcionario";
            this.btnNovoFuncionario.UseVisualStyleBackColor = true;
            this.btnNovoFuncionario.Click += new System.EventHandler(this.btnNovoFuncionario_Click);
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_func,
            this.nm_func,
            this.email_func,
            this.senha_func,
            this.cpf_func,
            this.end_func,
            this.tel_func});
            this.dgvFuncionarios.Location = new System.Drawing.Point(13, 48);
            this.dgvFuncionarios.MultiSelect = false;
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.ReadOnly = true;
            this.dgvFuncionarios.Size = new System.Drawing.Size(746, 437);
            this.dgvFuncionarios.TabIndex = 8;
            this.dgvFuncionarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFuncionarios_CellContentClick);
            // 
            // cod_func
            // 
            this.cod_func.DataPropertyName = "cod_func";
            this.cod_func.HeaderText = "Cod. Func";
            this.cod_func.Name = "cod_func";
            this.cod_func.ReadOnly = true;
            this.cod_func.Width = 50;
            // 
            // nm_func
            // 
            this.nm_func.DataPropertyName = "nm_func";
            this.nm_func.HeaderText = "Nome";
            this.nm_func.Name = "nm_func";
            this.nm_func.ReadOnly = true;
            // 
            // email_func
            // 
            this.email_func.DataPropertyName = "email_func";
            this.email_func.HeaderText = "Email";
            this.email_func.Name = "email_func";
            this.email_func.ReadOnly = true;
            this.email_func.Width = 150;
            // 
            // senha_func
            // 
            this.senha_func.DataPropertyName = "senha_func";
            this.senha_func.HeaderText = "Senha";
            this.senha_func.Name = "senha_func";
            this.senha_func.ReadOnly = true;
            // 
            // cpf_func
            // 
            this.cpf_func.DataPropertyName = "cpf_func";
            this.cpf_func.HeaderText = "CPF";
            this.cpf_func.Name = "cpf_func";
            this.cpf_func.ReadOnly = true;
            // 
            // end_func
            // 
            this.end_func.DataPropertyName = "end_func";
            this.end_func.HeaderText = "Endereço";
            this.end_func.Name = "end_func";
            this.end_func.ReadOnly = true;
            // 
            // tel_func
            // 
            this.tel_func.DataPropertyName = "tel_func";
            this.tel_func.HeaderText = "Telefone";
            this.tel_func.Name = "tel_func";
            this.tel_func.ReadOnly = true;
            // 
            // tabGenerosAutoresEditoras
            // 
            this.tabGenerosAutoresEditoras.Controls.Add(this.btnExcluirAutor);
            this.tabGenerosAutoresEditoras.Controls.Add(this.btnAlterarAutor);
            this.tabGenerosAutoresEditoras.Controls.Add(this.btnNovoAutor);
            this.tabGenerosAutoresEditoras.Controls.Add(this.btnListarAutores);
            this.tabGenerosAutoresEditoras.Controls.Add(this.btnExcluirEditora);
            this.tabGenerosAutoresEditoras.Controls.Add(this.btnAlterarEditora);
            this.tabGenerosAutoresEditoras.Controls.Add(this.btnNovaEditora);
            this.tabGenerosAutoresEditoras.Controls.Add(this.btnListarEditoras);
            this.tabGenerosAutoresEditoras.Controls.Add(this.btnExcluirGenero);
            this.tabGenerosAutoresEditoras.Controls.Add(this.btnAlterarGenero);
            this.tabGenerosAutoresEditoras.Controls.Add(this.btnNovoGenero);
            this.tabGenerosAutoresEditoras.Controls.Add(this.btnListarGeneros);
            this.tabGenerosAutoresEditoras.Controls.Add(this.btnPesquisarAutor);
            this.tabGenerosAutoresEditoras.Controls.Add(this.txtPesquisarAutor);
            this.tabGenerosAutoresEditoras.Controls.Add(this.btnPesquisarEditora);
            this.tabGenerosAutoresEditoras.Controls.Add(this.txtPesquisarEditora);
            this.tabGenerosAutoresEditoras.Controls.Add(this.btnPesquisarGenero);
            this.tabGenerosAutoresEditoras.Controls.Add(this.txtPesquisarGenero);
            this.tabGenerosAutoresEditoras.Controls.Add(this.dgvAutores);
            this.tabGenerosAutoresEditoras.Controls.Add(this.dgvEditoras);
            this.tabGenerosAutoresEditoras.Controls.Add(this.dgvGeneros);
            this.tabGenerosAutoresEditoras.Location = new System.Drawing.Point(4, 22);
            this.tabGenerosAutoresEditoras.Name = "tabGenerosAutoresEditoras";
            this.tabGenerosAutoresEditoras.Padding = new System.Windows.Forms.Padding(3);
            this.tabGenerosAutoresEditoras.Size = new System.Drawing.Size(776, 538);
            this.tabGenerosAutoresEditoras.TabIndex = 2;
            this.tabGenerosAutoresEditoras.Text = "Gêneros/Autores/Editoras";
            this.tabGenerosAutoresEditoras.UseVisualStyleBackColor = true;
            // 
            // btnExcluirAutor
            // 
            this.btnExcluirAutor.Enabled = false;
            this.btnExcluirAutor.Location = new System.Drawing.Point(586, 502);
            this.btnExcluirAutor.Name = "btnExcluirAutor";
            this.btnExcluirAutor.Size = new System.Drawing.Size(100, 23);
            this.btnExcluirAutor.TabIndex = 20;
            this.btnExcluirAutor.Text = "Excluir Autor";
            this.btnExcluirAutor.UseVisualStyleBackColor = true;
            this.btnExcluirAutor.Click += new System.EventHandler(this.btnExcluirAutor_Click);
            // 
            // btnAlterarAutor
            // 
            this.btnAlterarAutor.Enabled = false;
            this.btnAlterarAutor.Location = new System.Drawing.Point(586, 472);
            this.btnAlterarAutor.Name = "btnAlterarAutor";
            this.btnAlterarAutor.Size = new System.Drawing.Size(100, 23);
            this.btnAlterarAutor.TabIndex = 19;
            this.btnAlterarAutor.Text = "Alterar Autor";
            this.btnAlterarAutor.UseVisualStyleBackColor = true;
            this.btnAlterarAutor.Click += new System.EventHandler(this.btnAlterarAutor_Click);
            // 
            // btnNovoAutor
            // 
            this.btnNovoAutor.Location = new System.Drawing.Point(586, 442);
            this.btnNovoAutor.Name = "btnNovoAutor";
            this.btnNovoAutor.Size = new System.Drawing.Size(100, 23);
            this.btnNovoAutor.TabIndex = 18;
            this.btnNovoAutor.Text = "Novo Autor";
            this.btnNovoAutor.UseVisualStyleBackColor = true;
            this.btnNovoAutor.Click += new System.EventHandler(this.btnNovoAutor_Click);
            // 
            // btnListarAutores
            // 
            this.btnListarAutores.Location = new System.Drawing.Point(586, 412);
            this.btnListarAutores.Name = "btnListarAutores";
            this.btnListarAutores.Size = new System.Drawing.Size(100, 23);
            this.btnListarAutores.TabIndex = 17;
            this.btnListarAutores.Text = "Listar Autores";
            this.btnListarAutores.UseVisualStyleBackColor = true;
            this.btnListarAutores.Click += new System.EventHandler(this.btnListarAutores_Click);
            // 
            // btnExcluirEditora
            // 
            this.btnExcluirEditora.Enabled = false;
            this.btnExcluirEditora.Location = new System.Drawing.Point(290, 502);
            this.btnExcluirEditora.Name = "btnExcluirEditora";
            this.btnExcluirEditora.Size = new System.Drawing.Size(100, 23);
            this.btnExcluirEditora.TabIndex = 16;
            this.btnExcluirEditora.Text = "Excluir Editora";
            this.btnExcluirEditora.UseVisualStyleBackColor = true;
            this.btnExcluirEditora.Click += new System.EventHandler(this.btnExcluirEditora_Click);
            // 
            // btnAlterarEditora
            // 
            this.btnAlterarEditora.Enabled = false;
            this.btnAlterarEditora.Location = new System.Drawing.Point(290, 472);
            this.btnAlterarEditora.Name = "btnAlterarEditora";
            this.btnAlterarEditora.Size = new System.Drawing.Size(100, 23);
            this.btnAlterarEditora.TabIndex = 15;
            this.btnAlterarEditora.Text = "Alterar Editora";
            this.btnAlterarEditora.UseVisualStyleBackColor = true;
            this.btnAlterarEditora.Click += new System.EventHandler(this.btnAlterarEditora_Click);
            // 
            // btnNovaEditora
            // 
            this.btnNovaEditora.Location = new System.Drawing.Point(290, 442);
            this.btnNovaEditora.Name = "btnNovaEditora";
            this.btnNovaEditora.Size = new System.Drawing.Size(100, 23);
            this.btnNovaEditora.TabIndex = 14;
            this.btnNovaEditora.Text = "Nova Editora";
            this.btnNovaEditora.UseVisualStyleBackColor = true;
            this.btnNovaEditora.Click += new System.EventHandler(this.btnNovaEditora_Click);
            // 
            // btnListarEditoras
            // 
            this.btnListarEditoras.Location = new System.Drawing.Point(290, 412);
            this.btnListarEditoras.Name = "btnListarEditoras";
            this.btnListarEditoras.Size = new System.Drawing.Size(100, 23);
            this.btnListarEditoras.TabIndex = 13;
            this.btnListarEditoras.Text = "Listar Editoras";
            this.btnListarEditoras.UseVisualStyleBackColor = true;
            this.btnListarEditoras.Click += new System.EventHandler(this.btnListarEditoras_Click);
            // 
            // btnExcluirGenero
            // 
            this.btnExcluirGenero.Enabled = false;
            this.btnExcluirGenero.Location = new System.Drawing.Point(51, 502);
            this.btnExcluirGenero.Name = "btnExcluirGenero";
            this.btnExcluirGenero.Size = new System.Drawing.Size(100, 23);
            this.btnExcluirGenero.TabIndex = 12;
            this.btnExcluirGenero.Text = "Excluir Genero";
            this.btnExcluirGenero.UseVisualStyleBackColor = true;
            this.btnExcluirGenero.Click += new System.EventHandler(this.btnExcluirGenero_Click);
            // 
            // btnAlterarGenero
            // 
            this.btnAlterarGenero.Enabled = false;
            this.btnAlterarGenero.Location = new System.Drawing.Point(51, 472);
            this.btnAlterarGenero.Name = "btnAlterarGenero";
            this.btnAlterarGenero.Size = new System.Drawing.Size(100, 23);
            this.btnAlterarGenero.TabIndex = 11;
            this.btnAlterarGenero.Text = "Alterar Gênero";
            this.btnAlterarGenero.UseVisualStyleBackColor = true;
            this.btnAlterarGenero.Click += new System.EventHandler(this.btnAlterarGenero_Click);
            // 
            // btnNovoGenero
            // 
            this.btnNovoGenero.Location = new System.Drawing.Point(51, 442);
            this.btnNovoGenero.Name = "btnNovoGenero";
            this.btnNovoGenero.Size = new System.Drawing.Size(100, 23);
            this.btnNovoGenero.TabIndex = 10;
            this.btnNovoGenero.Text = "Novo Gênero";
            this.btnNovoGenero.UseVisualStyleBackColor = true;
            this.btnNovoGenero.Click += new System.EventHandler(this.btnNovoGenero_Click);
            // 
            // btnListarGeneros
            // 
            this.btnListarGeneros.Location = new System.Drawing.Point(51, 412);
            this.btnListarGeneros.Name = "btnListarGeneros";
            this.btnListarGeneros.Size = new System.Drawing.Size(100, 23);
            this.btnListarGeneros.TabIndex = 9;
            this.btnListarGeneros.Text = "Listar Generos";
            this.btnListarGeneros.UseVisualStyleBackColor = true;
            this.btnListarGeneros.Click += new System.EventHandler(this.btnListarGeneros_Click);
            // 
            // btnPesquisarAutor
            // 
            this.btnPesquisarAutor.Location = new System.Drawing.Point(665, 18);
            this.btnPesquisarAutor.Name = "btnPesquisarAutor";
            this.btnPesquisarAutor.Size = new System.Drawing.Size(105, 23);
            this.btnPesquisarAutor.TabIndex = 8;
            this.btnPesquisarAutor.Text = "Pesquisar Autor";
            this.btnPesquisarAutor.UseVisualStyleBackColor = true;
            this.btnPesquisarAutor.Click += new System.EventHandler(this.btnPesquisarAutor_Click);
            // 
            // txtPesquisarAutor
            // 
            this.txtPesquisarAutor.Location = new System.Drawing.Point(485, 20);
            this.txtPesquisarAutor.Name = "txtPesquisarAutor";
            this.txtPesquisarAutor.Size = new System.Drawing.Size(174, 20);
            this.txtPesquisarAutor.TabIndex = 7;
            // 
            // btnPesquisarEditora
            // 
            this.btnPesquisarEditora.Location = new System.Drawing.Point(363, 19);
            this.btnPesquisarEditora.Name = "btnPesquisarEditora";
            this.btnPesquisarEditora.Size = new System.Drawing.Size(115, 23);
            this.btnPesquisarEditora.TabIndex = 6;
            this.btnPesquisarEditora.Text = "Pesquisar Editora";
            this.btnPesquisarEditora.UseVisualStyleBackColor = true;
            this.btnPesquisarEditora.Click += new System.EventHandler(this.btnPesquisarEditora_Click);
            // 
            // txtPesquisarEditora
            // 
            this.txtPesquisarEditora.Location = new System.Drawing.Point(209, 22);
            this.txtPesquisarEditora.Name = "txtPesquisarEditora";
            this.txtPesquisarEditora.Size = new System.Drawing.Size(148, 20);
            this.txtPesquisarEditora.TabIndex = 5;
            // 
            // btnPesquisarGenero
            // 
            this.btnPesquisarGenero.Location = new System.Drawing.Point(102, 20);
            this.btnPesquisarGenero.Name = "btnPesquisarGenero";
            this.btnPesquisarGenero.Size = new System.Drawing.Size(101, 23);
            this.btnPesquisarGenero.TabIndex = 4;
            this.btnPesquisarGenero.Text = "Pesquisar Genero";
            this.btnPesquisarGenero.UseVisualStyleBackColor = true;
            this.btnPesquisarGenero.Click += new System.EventHandler(this.btnPesquisarGenero_Click);
            // 
            // txtPesquisarGenero
            // 
            this.txtPesquisarGenero.Location = new System.Drawing.Point(9, 22);
            this.txtPesquisarGenero.Name = "txtPesquisarGenero";
            this.txtPesquisarGenero.Size = new System.Drawing.Size(87, 20);
            this.txtPesquisarGenero.TabIndex = 3;
            // 
            // dgvAutores
            // 
            this.dgvAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_autor,
            this.nm_autor,
            this.pais_ori});
            this.dgvAutores.Location = new System.Drawing.Point(485, 47);
            this.dgvAutores.Name = "dgvAutores";
            this.dgvAutores.Size = new System.Drawing.Size(285, 350);
            this.dgvAutores.TabIndex = 2;
            this.dgvAutores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAutores_CellContentClick);
            // 
            // cod_autor
            // 
            this.cod_autor.DataPropertyName = "cod_autor";
            this.cod_autor.HeaderText = "Cod.";
            this.cod_autor.Name = "cod_autor";
            this.cod_autor.ReadOnly = true;
            this.cod_autor.Width = 35;
            // 
            // nm_autor
            // 
            this.nm_autor.DataPropertyName = "nm_autor";
            this.nm_autor.HeaderText = "Autor";
            this.nm_autor.Name = "nm_autor";
            this.nm_autor.ReadOnly = true;
            // 
            // pais_ori
            // 
            this.pais_ori.DataPropertyName = "pais_ori";
            this.pais_ori.HeaderText = "Pais de Origem";
            this.pais_ori.Name = "pais_ori";
            this.pais_ori.ReadOnly = true;
            this.pais_ori.Width = 90;
            // 
            // dgvEditoras
            // 
            this.dgvEditoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditoras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_editora,
            this.nm_editora,
            this.end_editora});
            this.dgvEditoras.Location = new System.Drawing.Point(209, 47);
            this.dgvEditoras.Name = "dgvEditoras";
            this.dgvEditoras.Size = new System.Drawing.Size(270, 350);
            this.dgvEditoras.TabIndex = 1;
            this.dgvEditoras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEditoras_CellContentClick);
            // 
            // cod_editora
            // 
            this.cod_editora.DataPropertyName = "cod_editora";
            this.cod_editora.HeaderText = "Cod.";
            this.cod_editora.Name = "cod_editora";
            this.cod_editora.ReadOnly = true;
            this.cod_editora.Width = 35;
            // 
            // nm_editora
            // 
            this.nm_editora.DataPropertyName = "nm_editora";
            this.nm_editora.HeaderText = "Editora";
            this.nm_editora.Name = "nm_editora";
            this.nm_editora.ReadOnly = true;
            this.nm_editora.Width = 105;
            // 
            // end_editora
            // 
            this.end_editora.DataPropertyName = "end_editora";
            this.end_editora.HeaderText = "País de Origem";
            this.end_editora.Name = "end_editora";
            this.end_editora.ReadOnly = true;
            this.end_editora.Width = 70;
            // 
            // dgvGeneros
            // 
            this.dgvGeneros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeneros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_gen,
            this.nm_gen});
            this.dgvGeneros.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvGeneros.Location = new System.Drawing.Point(8, 48);
            this.dgvGeneros.Name = "dgvGeneros";
            this.dgvGeneros.Size = new System.Drawing.Size(195, 350);
            this.dgvGeneros.TabIndex = 0;
            this.dgvGeneros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGeneros_CellContentClick);
            // 
            // cod_gen
            // 
            this.cod_gen.DataPropertyName = "cod_gen";
            this.cod_gen.HeaderText = "Cod.";
            this.cod_gen.Name = "cod_gen";
            this.cod_gen.ReadOnly = true;
            this.cod_gen.Width = 35;
            // 
            // nm_gen
            // 
            this.nm_gen.DataPropertyName = "nm_gen";
            this.nm_gen.HeaderText = "Gênero Literário";
            this.nm_gen.Name = "nm_gen";
            this.nm_gen.ReadOnly = true;
            // 
            // tabEmprestimos
            // 
            this.tabEmprestimos.Controls.Add(this.btnFinalizarEmprestimo);
            this.tabEmprestimos.Controls.Add(this.btnNovoEmprestimo);
            this.tabEmprestimos.Controls.Add(this.dgvEmprestimos);
            this.tabEmprestimos.Location = new System.Drawing.Point(4, 22);
            this.tabEmprestimos.Name = "tabEmprestimos";
            this.tabEmprestimos.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmprestimos.Size = new System.Drawing.Size(776, 538);
            this.tabEmprestimos.TabIndex = 4;
            this.tabEmprestimos.Text = "Empréstimos";
            this.tabEmprestimos.UseVisualStyleBackColor = true;
            // 
            // btnFinalizarEmprestimo
            // 
            this.btnFinalizarEmprestimo.Enabled = false;
            this.btnFinalizarEmprestimo.Location = new System.Drawing.Point(579, 262);
            this.btnFinalizarEmprestimo.Name = "btnFinalizarEmprestimo";
            this.btnFinalizarEmprestimo.Size = new System.Drawing.Size(152, 54);
            this.btnFinalizarEmprestimo.TabIndex = 2;
            this.btnFinalizarEmprestimo.Text = "Finalizar Empréstimo";
            this.btnFinalizarEmprestimo.UseVisualStyleBackColor = true;
            this.btnFinalizarEmprestimo.Click += new System.EventHandler(this.btnFinalizarEmprestimo_Click);
            // 
            // btnNovoEmprestimo
            // 
            this.btnNovoEmprestimo.Location = new System.Drawing.Point(579, 202);
            this.btnNovoEmprestimo.Name = "btnNovoEmprestimo";
            this.btnNovoEmprestimo.Size = new System.Drawing.Size(152, 54);
            this.btnNovoEmprestimo.TabIndex = 1;
            this.btnNovoEmprestimo.Text = "Efetuar Novo Empréstimo";
            this.btnNovoEmprestimo.UseVisualStyleBackColor = true;
            this.btnNovoEmprestimo.Click += new System.EventHandler(this.btnNovoEmprestimo_Click);
            // 
            // dgvEmprestimos
            // 
            this.dgvEmprestimos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmprestimos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod_empres,
            this.dt_retira,
            this.dt_devol,
            this.cod_livr,
            this.cod_cli,
            this.emp_finalizado});
            this.dgvEmprestimos.Location = new System.Drawing.Point(13, 21);
            this.dgvEmprestimos.Name = "dgvEmprestimos";
            this.dgvEmprestimos.Size = new System.Drawing.Size(523, 507);
            this.dgvEmprestimos.TabIndex = 0;
            this.dgvEmprestimos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmprestimos_CellContentClick);
            // 
            // cod_empres
            // 
            this.cod_empres.DataPropertyName = "cod_empres";
            this.cod_empres.HeaderText = "Cod. Emprestimo";
            this.cod_empres.Name = "cod_empres";
            this.cod_empres.ReadOnly = true;
            this.cod_empres.Width = 70;
            // 
            // dt_retira
            // 
            this.dt_retira.DataPropertyName = "dt_retira";
            this.dt_retira.HeaderText = "Data de Retirada";
            this.dt_retira.Name = "dt_retira";
            this.dt_retira.ReadOnly = true;
            this.dt_retira.Width = 70;
            // 
            // dt_devol
            // 
            this.dt_devol.DataPropertyName = "dt_devol";
            this.dt_devol.HeaderText = "Data de Devolução";
            this.dt_devol.Name = "dt_devol";
            this.dt_devol.ReadOnly = true;
            this.dt_devol.Width = 70;
            // 
            // cod_livr
            // 
            this.cod_livr.DataPropertyName = "cod_livr";
            this.cod_livr.HeaderText = "Cod. Livro";
            this.cod_livr.Name = "cod_livr";
            this.cod_livr.ReadOnly = true;
            this.cod_livr.Width = 70;
            // 
            // cod_cli
            // 
            this.cod_cli.DataPropertyName = "cod_cli";
            this.cod_cli.HeaderText = "Cod. Cliente";
            this.cod_cli.Name = "cod_cli";
            this.cod_cli.ReadOnly = true;
            this.cod_cli.Width = 70;
            // 
            // emp_finalizado
            // 
            this.emp_finalizado.DataPropertyName = "emp_finalizado";
            this.emp_finalizado.HeaderText = "Finalizado";
            this.emp_finalizado.Name = "emp_finalizado";
            this.emp_finalizado.ReadOnly = true;
            this.emp_finalizado.Width = 70;
            // 
            // FormBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.tabBiblioteca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormBiblioteca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Biblioteca";
            this.tabBiblioteca.ResumeLayout(false);
            this.tabLivros.ResumeLayout(false);
            this.pnlLivros.ResumeLayout(false);
            this.pnlLivros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).EndInit();
            this.tabClientes.ResumeLayout(false);
            this.pnlClientes.ResumeLayout(false);
            this.pnlClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.tabFuncionarios.ResumeLayout(false);
            this.tabFuncionarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            this.tabGenerosAutoresEditoras.ResumeLayout(false);
            this.tabGenerosAutoresEditoras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneros)).EndInit();
            this.tabEmprestimos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestimos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabBiblioteca;
        private System.Windows.Forms.TabPage tabLivros;
        private System.Windows.Forms.Panel pnlLivros;
        private System.Windows.Forms.Button btnListarTodosLivros;
        private System.Windows.Forms.Button btnConsultaNomeLivro;
        private System.Windows.Forms.Label lblConsultaNome;
        private System.Windows.Forms.TextBox txtConsultaNomeLivro;
        private System.Windows.Forms.Button btnExcluirLivro;
        private System.Windows.Forms.Button btnAlterarLivro;
        private System.Windows.Forms.Button btnNovoLivro;
        private System.Windows.Forms.DataGridView dgvLivros;
        private System.Windows.Forms.TabPage tabClientes;
        private System.Windows.Forms.Panel pnlClientes;
        private System.Windows.Forms.Button btnListaTodosClientes;
        private System.Windows.Forms.Button btnConsultarCliente;
        private System.Windows.Forms.Label lblConsultaNomeCliente;
        private System.Windows.Forms.TextBox txtConsultaCliente;
        private System.Windows.Forms.Button btnExcluirCliente;
        private System.Windows.Forms.Button btnAlterarCliente;
        private System.Windows.Forms.Button btnNovoCliente;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TabPage tabFuncionarios;
        private System.Windows.Forms.Button btnListarTodosFuncionarios;
        private System.Windows.Forms.Button btnConsultarFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConsultaFuncionario;
        private System.Windows.Forms.Button btnExcluirFuncionario;
        private System.Windows.Forms.Button btnAlterarFuncionario;
        private System.Windows.Forms.Button btnNovoFuncionario;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.TabPage tabGenerosAutoresEditoras;
        private System.Windows.Forms.Button btnExcluirAutor;
        private System.Windows.Forms.Button btnAlterarAutor;
        private System.Windows.Forms.Button btnNovoAutor;
        private System.Windows.Forms.Button btnListarAutores;
        private System.Windows.Forms.Button btnExcluirEditora;
        private System.Windows.Forms.Button btnAlterarEditora;
        private System.Windows.Forms.Button btnNovaEditora;
        private System.Windows.Forms.Button btnListarEditoras;
        private System.Windows.Forms.Button btnExcluirGenero;
        private System.Windows.Forms.Button btnAlterarGenero;
        private System.Windows.Forms.Button btnNovoGenero;
        private System.Windows.Forms.Button btnListarGeneros;
        private System.Windows.Forms.Button btnPesquisarAutor;
        private System.Windows.Forms.TextBox txtPesquisarAutor;
        private System.Windows.Forms.Button btnPesquisarEditora;
        private System.Windows.Forms.TextBox txtPesquisarEditora;
        private System.Windows.Forms.Button btnPesquisarGenero;
        private System.Windows.Forms.TextBox txtPesquisarGenero;
        private System.Windows.Forms.DataGridView dgvAutores;
        private System.Windows.Forms.DataGridView dgvEditoras;
        private System.Windows.Forms.DataGridView dgvGeneros;
        private System.Windows.Forms.TabPage tabEmprestimos;
        private System.Windows.Forms.Button btnFinalizarEmprestimo;
        private System.Windows.Forms.Button btnNovoEmprestimo;
        private System.Windows.Forms.DataGridView dgvEmprestimos;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nm_autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn pais_ori;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_editora;
        private System.Windows.Forms.DataGridViewTextBoxColumn nm_editora;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_editora;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_gen;
        private System.Windows.Forms.DataGridViewTextBoxColumn nm_gen;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_empres;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_retira;
        private System.Windows.Forms.DataGridViewTextBoxColumn dt_devol;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_livr;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_cli;
        private System.Windows.Forms.DataGridViewTextBoxColumn emp_finalizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_livro;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispon;
        private System.Windows.Forms.DataGridViewTextBoxColumn descr;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_clien;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_func;
        private System.Windows.Forms.DataGridViewTextBoxColumn nm_func;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_func;
        private System.Windows.Forms.DataGridViewTextBoxColumn senha_func;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf_func;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_func;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel_func;
    }
}