namespace App_Biblioteca
{
    partial class FormLivro
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
            this.btnAlterarDados = new System.Windows.Forms.Button();
            this.mskAnoPublicacao = new System.Windows.Forms.MaskedTextBox();
            this.btnLimparCadLivro = new System.Windows.Forms.Button();
            this.btnCadastrarLivro = new System.Windows.Forms.Button();
            this.ckLstBxGenero = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnNovoGenero = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ckListBxAutores = new System.Windows.Forms.CheckedListBox();
            this.mskISBN = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAnoPublicacao = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.rtxtDesc = new System.Windows.Forms.RichTextBox();
            this.lblGeneros = new System.Windows.Forms.Label();
            this.btnNovaEditora = new System.Windows.Forms.Button();
            this.cbxEditora = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNovoAutor = new System.Windows.Forms.Button();
            this.lblAutores = new System.Windows.Forms.Label();
            this.txtNomeLivro = new System.Windows.Forms.TextBox();
            this.lblTituloLivro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAlterarDados
            // 
            this.btnAlterarDados.Location = new System.Drawing.Point(101, 461);
            this.btnAlterarDados.Name = "btnAlterarDados";
            this.btnAlterarDados.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarDados.TabIndex = 52;
            this.btnAlterarDados.Text = "Alterar";
            this.btnAlterarDados.UseVisualStyleBackColor = true;
            this.btnAlterarDados.Visible = false;
            this.btnAlterarDados.Click += new System.EventHandler(this.btnAlterarDados_Click);
            // 
            // mskAnoPublicacao
            // 
            this.mskAnoPublicacao.Location = new System.Drawing.Point(19, 257);
            this.mskAnoPublicacao.Mask = "9999";
            this.mskAnoPublicacao.Name = "mskAnoPublicacao";
            this.mskAnoPublicacao.Size = new System.Drawing.Size(40, 20);
            this.mskAnoPublicacao.TabIndex = 51;
            // 
            // btnLimparCadLivro
            // 
            this.btnLimparCadLivro.Location = new System.Drawing.Point(182, 461);
            this.btnLimparCadLivro.Name = "btnLimparCadLivro";
            this.btnLimparCadLivro.Size = new System.Drawing.Size(75, 23);
            this.btnLimparCadLivro.TabIndex = 50;
            this.btnLimparCadLivro.Text = "Limpar";
            this.btnLimparCadLivro.UseVisualStyleBackColor = true;
            this.btnLimparCadLivro.Click += new System.EventHandler(this.btnLimparCadLivro_Click);
            // 
            // btnCadastrarLivro
            // 
            this.btnCadastrarLivro.Location = new System.Drawing.Point(101, 461);
            this.btnCadastrarLivro.Name = "btnCadastrarLivro";
            this.btnCadastrarLivro.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarLivro.TabIndex = 49;
            this.btnCadastrarLivro.Text = "Cadastrar";
            this.btnCadastrarLivro.UseVisualStyleBackColor = true;
            this.btnCadastrarLivro.Click += new System.EventHandler(this.btnCadastrarLivro_Click);
            // 
            // ckLstBxGenero
            // 
            this.ckLstBxGenero.FormattingEnabled = true;
            this.ckLstBxGenero.Location = new System.Drawing.Point(197, 69);
            this.ckLstBxGenero.Name = "ckLstBxGenero";
            this.ckLstBxGenero.ScrollAlwaysVisible = true;
            this.ckLstBxGenero.Size = new System.Drawing.Size(158, 94);
            this.ckLstBxGenero.Sorted = true;
            this.ckLstBxGenero.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Generos:";
            // 
            // btnNovoGenero
            // 
            this.btnNovoGenero.Location = new System.Drawing.Point(197, 169);
            this.btnNovoGenero.Name = "btnNovoGenero";
            this.btnNovoGenero.Size = new System.Drawing.Size(87, 24);
            this.btnNovoGenero.TabIndex = 46;
            this.btnNovoGenero.Text = "Novo Genêro";
            this.btnNovoGenero.UseVisualStyleBackColor = true;
            this.btnNovoGenero.Click += new System.EventHandler(this.btnNovoGenero_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Gêneros:";
            // 
            // ckListBxAutores
            // 
            this.ckListBxAutores.FormattingEnabled = true;
            this.ckListBxAutores.Location = new System.Drawing.Point(19, 69);
            this.ckListBxAutores.Name = "ckListBxAutores";
            this.ckListBxAutores.ScrollAlwaysVisible = true;
            this.ckListBxAutores.Size = new System.Drawing.Size(157, 94);
            this.ckListBxAutores.Sorted = true;
            this.ckListBxAutores.TabIndex = 44;
            // 
            // mskISBN
            // 
            this.mskISBN.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskISBN.Location = new System.Drawing.Point(16, 299);
            this.mskISBN.Mask = "999-9-99-999999-9";
            this.mskISBN.Name = "mskISBN";
            this.mskISBN.Size = new System.Drawing.Size(118, 20);
            this.mskISBN.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "ISBN:";
            // 
            // lblAnoPublicacao
            // 
            this.lblAnoPublicacao.AutoSize = true;
            this.lblAnoPublicacao.Location = new System.Drawing.Point(16, 240);
            this.lblAnoPublicacao.Name = "lblAnoPublicacao";
            this.lblAnoPublicacao.Size = new System.Drawing.Size(103, 13);
            this.lblAnoPublicacao.TabIndex = 41;
            this.lblAnoPublicacao.Text = "Ano de Publicação :";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(16, 323);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(58, 13);
            this.lblDesc.TabIndex = 40;
            this.lblDesc.Text = "Descrição:";
            // 
            // rtxtDesc
            // 
            this.rtxtDesc.Location = new System.Drawing.Point(14, 339);
            this.rtxtDesc.MaxLength = 500;
            this.rtxtDesc.Name = "rtxtDesc";
            this.rtxtDesc.Size = new System.Drawing.Size(344, 114);
            this.rtxtDesc.TabIndex = 39;
            this.rtxtDesc.Text = "";
            // 
            // lblGeneros
            // 
            this.lblGeneros.AutoSize = true;
            this.lblGeneros.Location = new System.Drawing.Point(16, 114);
            this.lblGeneros.Name = "lblGeneros";
            this.lblGeneros.Size = new System.Drawing.Size(50, 13);
            this.lblGeneros.TabIndex = 38;
            this.lblGeneros.Text = "Generos:";
            // 
            // btnNovaEditora
            // 
            this.btnNovaEditora.Location = new System.Drawing.Point(265, 216);
            this.btnNovaEditora.Name = "btnNovaEditora";
            this.btnNovaEditora.Size = new System.Drawing.Size(90, 24);
            this.btnNovaEditora.TabIndex = 37;
            this.btnNovaEditora.Text = "Nova Editora";
            this.btnNovaEditora.UseVisualStyleBackColor = true;
            this.btnNovaEditora.Click += new System.EventHandler(this.btnNovaEditora_Click);
            // 
            // cbxEditora
            // 
            this.cbxEditora.FormattingEnabled = true;
            this.cbxEditora.Location = new System.Drawing.Point(19, 216);
            this.cbxEditora.Name = "cbxEditora";
            this.cbxEditora.Size = new System.Drawing.Size(240, 21);
            this.cbxEditora.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Editora:";
            // 
            // btnNovoAutor
            // 
            this.btnNovoAutor.Location = new System.Drawing.Point(19, 169);
            this.btnNovoAutor.Name = "btnNovoAutor";
            this.btnNovoAutor.Size = new System.Drawing.Size(70, 24);
            this.btnNovoAutor.TabIndex = 34;
            this.btnNovoAutor.Text = "Novo Autor";
            this.btnNovoAutor.UseVisualStyleBackColor = true;
            this.btnNovoAutor.Click += new System.EventHandler(this.btnNovoAutor_Click);
            // 
            // lblAutores
            // 
            this.lblAutores.AutoSize = true;
            this.lblAutores.Location = new System.Drawing.Point(13, 53);
            this.lblAutores.Name = "lblAutores";
            this.lblAutores.Size = new System.Drawing.Size(46, 13);
            this.lblAutores.TabIndex = 33;
            this.lblAutores.Text = "Autores:";
            // 
            // txtNomeLivro
            // 
            this.txtNomeLivro.Location = new System.Drawing.Point(14, 29);
            this.txtNomeLivro.Name = "txtNomeLivro";
            this.txtNomeLivro.Size = new System.Drawing.Size(341, 20);
            this.txtNomeLivro.TabIndex = 32;
            // 
            // lblTituloLivro
            // 
            this.lblTituloLivro.AutoSize = true;
            this.lblTituloLivro.Location = new System.Drawing.Point(11, 12);
            this.lblTituloLivro.Name = "lblTituloLivro";
            this.lblTituloLivro.Size = new System.Drawing.Size(38, 13);
            this.lblTituloLivro.TabIndex = 31;
            this.lblTituloLivro.Text = "Título:";
            // 
            // FormLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 496);
            this.Controls.Add(this.btnAlterarDados);
            this.Controls.Add(this.mskAnoPublicacao);
            this.Controls.Add(this.btnLimparCadLivro);
            this.Controls.Add(this.btnCadastrarLivro);
            this.Controls.Add(this.ckLstBxGenero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNovoGenero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ckListBxAutores);
            this.Controls.Add(this.mskISBN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAnoPublicacao);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.rtxtDesc);
            this.Controls.Add(this.lblGeneros);
            this.Controls.Add(this.btnNovaEditora);
            this.Controls.Add(this.cbxEditora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNovoAutor);
            this.Controls.Add(this.lblAutores);
            this.Controls.Add(this.txtNomeLivro);
            this.Controls.Add(this.lblTituloLivro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastrar Livro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterarDados;
        private System.Windows.Forms.MaskedTextBox mskAnoPublicacao;
        private System.Windows.Forms.Button btnLimparCadLivro;
        private System.Windows.Forms.Button btnCadastrarLivro;
        private System.Windows.Forms.CheckedListBox ckLstBxGenero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNovoGenero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox ckListBxAutores;
        private System.Windows.Forms.MaskedTextBox mskISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAnoPublicacao;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.RichTextBox rtxtDesc;
        private System.Windows.Forms.Label lblGeneros;
        private System.Windows.Forms.Button btnNovaEditora;
        private System.Windows.Forms.ComboBox cbxEditora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNovoAutor;
        private System.Windows.Forms.Label lblAutores;
        private System.Windows.Forms.TextBox txtNomeLivro;
        private System.Windows.Forms.Label lblTituloLivro;
    }
}