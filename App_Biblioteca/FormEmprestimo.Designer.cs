namespace App_Biblioteca
{
    partial class FormEmprestimo
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRespISBNLivro = new System.Windows.Forms.TextBox();
            this.txtRespTituloLivro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRespCodLivro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRespCPFCliente = new System.Windows.Forms.TextBox();
            this.txtRespNomeCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRespCodCliente = new System.Windows.Forms.TextBox();
            this.mskPesquisaLivro = new System.Windows.Forms.MaskedTextBox();
            this.mskPesquisaCliente = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisaCliente = new System.Windows.Forms.Button();
            this.btnPesquisaLivro = new System.Windows.Forms.Button();
            this.btnFinalizarEmprestimo = new System.Windows.Forms.Button();
            this.lblDtEntrega = new System.Windows.Forms.Label();
            this.mskDtEntrega = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mskDtRetirada = new System.Windows.Forms.MaskedTextBox();
            this.pesquisaDadoCliente = new System.Windows.Forms.Label();
            this.lblPesquisaLivro = new System.Windows.Forms.Label();
            this.gbxPesquisaLivro = new System.Windows.Forms.GroupBox();
            this.rdbISBNLivro = new System.Windows.Forms.RadioButton();
            this.rdbTituloLivro = new System.Windows.Forms.RadioButton();
            this.rdbCodLivro = new System.Windows.Forms.RadioButton();
            this.gbxPesquisaCliente = new System.Windows.Forms.GroupBox();
            this.rdbCPFCliente = new System.Windows.Forms.RadioButton();
            this.rdbNomeCliente = new System.Windows.Forms.RadioButton();
            this.rdbCodCliente = new System.Windows.Forms.RadioButton();
            this.gbxPesquisaLivro.SuspendLayout();
            this.gbxPesquisaCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "ISBN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Livro";
            // 
            // txtRespISBNLivro
            // 
            this.txtRespISBNLivro.Enabled = false;
            this.txtRespISBNLivro.Location = new System.Drawing.Point(211, 265);
            this.txtRespISBNLivro.Name = "txtRespISBNLivro";
            this.txtRespISBNLivro.Size = new System.Drawing.Size(100, 20);
            this.txtRespISBNLivro.TabIndex = 51;
            // 
            // txtRespTituloLivro
            // 
            this.txtRespTituloLivro.Enabled = false;
            this.txtRespTituloLivro.Location = new System.Drawing.Point(105, 265);
            this.txtRespTituloLivro.Name = "txtRespTituloLivro";
            this.txtRespTituloLivro.Size = new System.Drawing.Size(100, 20);
            this.txtRespTituloLivro.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Código Livro";
            // 
            // txtRespCodLivro
            // 
            this.txtRespCodLivro.Enabled = false;
            this.txtRespCodLivro.Location = new System.Drawing.Point(25, 265);
            this.txtRespCodLivro.Name = "txtRespCodLivro";
            this.txtRespCodLivro.Size = new System.Drawing.Size(66, 20);
            this.txtRespCodLivro.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 46;
            this.label2.Text = "Cliente";
            // 
            // txtRespCPFCliente
            // 
            this.txtRespCPFCliente.Enabled = false;
            this.txtRespCPFCliente.Location = new System.Drawing.Point(208, 125);
            this.txtRespCPFCliente.Name = "txtRespCPFCliente";
            this.txtRespCPFCliente.Size = new System.Drawing.Size(100, 20);
            this.txtRespCPFCliente.TabIndex = 45;
            // 
            // txtRespNomeCliente
            // 
            this.txtRespNomeCliente.Enabled = false;
            this.txtRespNomeCliente.Location = new System.Drawing.Point(102, 125);
            this.txtRespNomeCliente.Name = "txtRespNomeCliente";
            this.txtRespNomeCliente.Size = new System.Drawing.Size(100, 20);
            this.txtRespNomeCliente.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Código Cliente";
            // 
            // txtRespCodCliente
            // 
            this.txtRespCodCliente.Enabled = false;
            this.txtRespCodCliente.Location = new System.Drawing.Point(21, 125);
            this.txtRespCodCliente.Name = "txtRespCodCliente";
            this.txtRespCodCliente.Size = new System.Drawing.Size(70, 20);
            this.txtRespCodCliente.TabIndex = 42;
            // 
            // mskPesquisaLivro
            // 
            this.mskPesquisaLivro.Location = new System.Drawing.Point(25, 216);
            this.mskPesquisaLivro.Name = "mskPesquisaLivro";
            this.mskPesquisaLivro.Size = new System.Drawing.Size(120, 20);
            this.mskPesquisaLivro.TabIndex = 41;
            // 
            // mskPesquisaCliente
            // 
            this.mskPesquisaCliente.Location = new System.Drawing.Point(22, 79);
            this.mskPesquisaCliente.Name = "mskPesquisaCliente";
            this.mskPesquisaCliente.Size = new System.Drawing.Size(120, 20);
            this.mskPesquisaCliente.TabIndex = 40;
            // 
            // btnPesquisaCliente
            // 
            this.btnPesquisaCliente.Location = new System.Drawing.Point(148, 77);
            this.btnPesquisaCliente.Name = "btnPesquisaCliente";
            this.btnPesquisaCliente.Size = new System.Drawing.Size(109, 23);
            this.btnPesquisaCliente.TabIndex = 39;
            this.btnPesquisaCliente.Text = "Pesquisar Cliente";
            this.btnPesquisaCliente.UseVisualStyleBackColor = true;
            this.btnPesquisaCliente.Click += new System.EventHandler(this.btnPesquisaCliente_Click);
            // 
            // btnPesquisaLivro
            // 
            this.btnPesquisaLivro.Location = new System.Drawing.Point(151, 214);
            this.btnPesquisaLivro.Name = "btnPesquisaLivro";
            this.btnPesquisaLivro.Size = new System.Drawing.Size(97, 23);
            this.btnPesquisaLivro.TabIndex = 38;
            this.btnPesquisaLivro.Text = "Pesquisar Livro";
            this.btnPesquisaLivro.UseVisualStyleBackColor = true;
            this.btnPesquisaLivro.Click += new System.EventHandler(this.btnPesquisaLivro_Click);
            // 
            // btnFinalizarEmprestimo
            // 
            this.btnFinalizarEmprestimo.Enabled = false;
            this.btnFinalizarEmprestimo.Location = new System.Drawing.Point(116, 351);
            this.btnFinalizarEmprestimo.Name = "btnFinalizarEmprestimo";
            this.btnFinalizarEmprestimo.Size = new System.Drawing.Size(86, 45);
            this.btnFinalizarEmprestimo.TabIndex = 37;
            this.btnFinalizarEmprestimo.Text = "Finalizar Empréstimo";
            this.btnFinalizarEmprestimo.UseVisualStyleBackColor = true;
            this.btnFinalizarEmprestimo.Click += new System.EventHandler(this.btnFinalizarEmprestimo_Click);
            // 
            // lblDtEntrega
            // 
            this.lblDtEntrega.AutoSize = true;
            this.lblDtEntrega.Location = new System.Drawing.Point(131, 297);
            this.lblDtEntrega.Name = "lblDtEntrega";
            this.lblDtEntrega.Size = new System.Drawing.Size(100, 13);
            this.lblDtEntrega.TabIndex = 36;
            this.lblDtEntrega.Text = "Data de Devolução";
            // 
            // mskDtEntrega
            // 
            this.mskDtEntrega.Enabled = false;
            this.mskDtEntrega.Location = new System.Drawing.Point(131, 317);
            this.mskDtEntrega.Mask = "99/99/9999";
            this.mskDtEntrega.Name = "mskDtEntrega";
            this.mskDtEntrega.Size = new System.Drawing.Size(100, 20);
            this.mskDtEntrega.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Data de Retirada";
            // 
            // mskDtRetirada
            // 
            this.mskDtRetirada.Enabled = false;
            this.mskDtRetirada.Location = new System.Drawing.Point(21, 317);
            this.mskDtRetirada.Mask = "99/99/9999";
            this.mskDtRetirada.Name = "mskDtRetirada";
            this.mskDtRetirada.Size = new System.Drawing.Size(100, 20);
            this.mskDtRetirada.TabIndex = 33;
            // 
            // pesquisaDadoCliente
            // 
            this.pesquisaDadoCliente.AutoSize = true;
            this.pesquisaDadoCliente.Location = new System.Drawing.Point(23, 200);
            this.pesquisaDadoCliente.Name = "pesquisaDadoCliente";
            this.pesquisaDadoCliente.Size = new System.Drawing.Size(110, 13);
            this.pesquisaDadoCliente.TabIndex = 32;
            this.pesquisaDadoCliente.Text = "Informe dado do Livro";
            // 
            // lblPesquisaLivro
            // 
            this.lblPesquisaLivro.AutoSize = true;
            this.lblPesquisaLivro.Location = new System.Drawing.Point(19, 62);
            this.lblPesquisaLivro.Name = "lblPesquisaLivro";
            this.lblPesquisaLivro.Size = new System.Drawing.Size(119, 13);
            this.lblPesquisaLivro.TabIndex = 31;
            this.lblPesquisaLivro.Text = "Informe dado do Cliente";
            // 
            // gbxPesquisaLivro
            // 
            this.gbxPesquisaLivro.Controls.Add(this.rdbISBNLivro);
            this.gbxPesquisaLivro.Controls.Add(this.rdbTituloLivro);
            this.gbxPesquisaLivro.Controls.Add(this.rdbCodLivro);
            this.gbxPesquisaLivro.Location = new System.Drawing.Point(22, 151);
            this.gbxPesquisaLivro.Name = "gbxPesquisaLivro";
            this.gbxPesquisaLivro.Size = new System.Drawing.Size(286, 46);
            this.gbxPesquisaLivro.TabIndex = 30;
            this.gbxPesquisaLivro.TabStop = false;
            this.gbxPesquisaLivro.Text = "Selecione dado a ser Pesquisado";
            // 
            // rdbISBNLivro
            // 
            this.rdbISBNLivro.AutoSize = true;
            this.rdbISBNLivro.Location = new System.Drawing.Point(130, 20);
            this.rdbISBNLivro.Name = "rdbISBNLivro";
            this.rdbISBNLivro.Size = new System.Drawing.Size(50, 17);
            this.rdbISBNLivro.TabIndex = 2;
            this.rdbISBNLivro.Text = "ISBN";
            this.rdbISBNLivro.UseVisualStyleBackColor = true;
            this.rdbISBNLivro.CheckedChanged += new System.EventHandler(this.rdbISBNLivro_CheckedChanged);
            // 
            // rdbTituloLivro
            // 
            this.rdbTituloLivro.AutoSize = true;
            this.rdbTituloLivro.Location = new System.Drawing.Point(71, 20);
            this.rdbTituloLivro.Name = "rdbTituloLivro";
            this.rdbTituloLivro.Size = new System.Drawing.Size(51, 17);
            this.rdbTituloLivro.TabIndex = 1;
            this.rdbTituloLivro.Text = "Titulo";
            this.rdbTituloLivro.UseVisualStyleBackColor = true;
            // 
            // rdbCodLivro
            // 
            this.rdbCodLivro.AutoSize = true;
            this.rdbCodLivro.Checked = true;
            this.rdbCodLivro.Location = new System.Drawing.Point(7, 20);
            this.rdbCodLivro.Name = "rdbCodLivro";
            this.rdbCodLivro.Size = new System.Drawing.Size(58, 17);
            this.rdbCodLivro.TabIndex = 0;
            this.rdbCodLivro.TabStop = true;
            this.rdbCodLivro.Text = "Código";
            this.rdbCodLivro.UseVisualStyleBackColor = true;
            // 
            // gbxPesquisaCliente
            // 
            this.gbxPesquisaCliente.Controls.Add(this.rdbCPFCliente);
            this.gbxPesquisaCliente.Controls.Add(this.rdbNomeCliente);
            this.gbxPesquisaCliente.Controls.Add(this.rdbCodCliente);
            this.gbxPesquisaCliente.Location = new System.Drawing.Point(18, 13);
            this.gbxPesquisaCliente.Name = "gbxPesquisaCliente";
            this.gbxPesquisaCliente.Size = new System.Drawing.Size(293, 46);
            this.gbxPesquisaCliente.TabIndex = 29;
            this.gbxPesquisaCliente.TabStop = false;
            this.gbxPesquisaCliente.Text = "Pesquisar Cliente por";
            // 
            // rdbCPFCliente
            // 
            this.rdbCPFCliente.AutoSize = true;
            this.rdbCPFCliente.Location = new System.Drawing.Point(130, 20);
            this.rdbCPFCliente.Name = "rdbCPFCliente";
            this.rdbCPFCliente.Size = new System.Drawing.Size(45, 17);
            this.rdbCPFCliente.TabIndex = 2;
            this.rdbCPFCliente.Text = "CPF";
            this.rdbCPFCliente.UseVisualStyleBackColor = true;
            this.rdbCPFCliente.CheckedChanged += new System.EventHandler(this.rdbCPFCliente_CheckedChanged);
            // 
            // rdbNomeCliente
            // 
            this.rdbNomeCliente.AutoSize = true;
            this.rdbNomeCliente.Location = new System.Drawing.Point(71, 20);
            this.rdbNomeCliente.Name = "rdbNomeCliente";
            this.rdbNomeCliente.Size = new System.Drawing.Size(53, 17);
            this.rdbNomeCliente.TabIndex = 1;
            this.rdbNomeCliente.Text = "Nome";
            this.rdbNomeCliente.UseVisualStyleBackColor = true;
            // 
            // rdbCodCliente
            // 
            this.rdbCodCliente.AutoSize = true;
            this.rdbCodCliente.Checked = true;
            this.rdbCodCliente.Location = new System.Drawing.Point(7, 20);
            this.rdbCodCliente.Name = "rdbCodCliente";
            this.rdbCodCliente.Size = new System.Drawing.Size(58, 17);
            this.rdbCodCliente.TabIndex = 0;
            this.rdbCodCliente.TabStop = true;
            this.rdbCodCliente.Text = "Código";
            this.rdbCodCliente.UseVisualStyleBackColor = true;
            // 
            // FormEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 408);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRespISBNLivro);
            this.Controls.Add(this.txtRespTituloLivro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRespCodLivro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRespCPFCliente);
            this.Controls.Add(this.txtRespNomeCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRespCodCliente);
            this.Controls.Add(this.mskPesquisaLivro);
            this.Controls.Add(this.mskPesquisaCliente);
            this.Controls.Add(this.btnPesquisaCliente);
            this.Controls.Add(this.btnPesquisaLivro);
            this.Controls.Add(this.btnFinalizarEmprestimo);
            this.Controls.Add(this.lblDtEntrega);
            this.Controls.Add(this.mskDtEntrega);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mskDtRetirada);
            this.Controls.Add(this.pesquisaDadoCliente);
            this.Controls.Add(this.lblPesquisaLivro);
            this.Controls.Add(this.gbxPesquisaLivro);
            this.Controls.Add(this.gbxPesquisaCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormEmprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Novo Empréstimo";
            this.gbxPesquisaLivro.ResumeLayout(false);
            this.gbxPesquisaLivro.PerformLayout();
            this.gbxPesquisaCliente.ResumeLayout(false);
            this.gbxPesquisaCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRespISBNLivro;
        private System.Windows.Forms.TextBox txtRespTituloLivro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRespCodLivro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRespCPFCliente;
        private System.Windows.Forms.TextBox txtRespNomeCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRespCodCliente;
        private System.Windows.Forms.MaskedTextBox mskPesquisaLivro;
        private System.Windows.Forms.MaskedTextBox mskPesquisaCliente;
        private System.Windows.Forms.Button btnPesquisaCliente;
        private System.Windows.Forms.Button btnPesquisaLivro;
        private System.Windows.Forms.Button btnFinalizarEmprestimo;
        private System.Windows.Forms.Label lblDtEntrega;
        private System.Windows.Forms.MaskedTextBox mskDtEntrega;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskDtRetirada;
        private System.Windows.Forms.Label pesquisaDadoCliente;
        private System.Windows.Forms.Label lblPesquisaLivro;
        private System.Windows.Forms.GroupBox gbxPesquisaLivro;
        private System.Windows.Forms.RadioButton rdbISBNLivro;
        private System.Windows.Forms.RadioButton rdbTituloLivro;
        private System.Windows.Forms.RadioButton rdbCodLivro;
        private System.Windows.Forms.GroupBox gbxPesquisaCliente;
        private System.Windows.Forms.RadioButton rdbCPFCliente;
        private System.Windows.Forms.RadioButton rdbNomeCliente;
        private System.Windows.Forms.RadioButton rdbCodCliente;
    }
}