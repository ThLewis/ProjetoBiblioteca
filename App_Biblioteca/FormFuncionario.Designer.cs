namespace App_Biblioteca
{
    partial class FormFuncionario
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
            this.btnAlterarDadosFuncionario = new System.Windows.Forms.Button();
            this.btnLimparCamposFuncionario = new System.Windows.Forms.Button();
            this.btnCadastrarFuncionario = new System.Windows.Forms.Button();
            this.mskCPFFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.lblCPFCad = new System.Windows.Forms.Label();
            this.mskTelefoneFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefoneCad = new System.Windows.Forms.Label();
            this.txtEnderecoFuncionario = new System.Windows.Forms.TextBox();
            this.lblEnderecoCad = new System.Windows.Forms.Label();
            this.txtSenhaFuncionario = new System.Windows.Forms.TextBox();
            this.lblSenhaCad = new System.Windows.Forms.Label();
            this.txtEmailFuncionario = new System.Windows.Forms.TextBox();
            this.lblEmailCad = new System.Windows.Forms.Label();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.lblNomeCad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAlterarDadosFuncionario
            // 
            this.btnAlterarDadosFuncionario.Location = new System.Drawing.Point(77, 245);
            this.btnAlterarDadosFuncionario.Name = "btnAlterarDadosFuncionario";
            this.btnAlterarDadosFuncionario.Size = new System.Drawing.Size(85, 28);
            this.btnAlterarDadosFuncionario.TabIndex = 47;
            this.btnAlterarDadosFuncionario.Text = "Alterar Dados";
            this.btnAlterarDadosFuncionario.UseVisualStyleBackColor = true;
            this.btnAlterarDadosFuncionario.Visible = false;
            this.btnAlterarDadosFuncionario.Click += new System.EventHandler(this.btnAlterarDadosFuncionario_Click);
            // 
            // btnLimparCamposFuncionario
            // 
            this.btnLimparCamposFuncionario.Location = new System.Drawing.Point(177, 245);
            this.btnLimparCamposFuncionario.Name = "btnLimparCamposFuncionario";
            this.btnLimparCamposFuncionario.Size = new System.Drawing.Size(85, 28);
            this.btnLimparCamposFuncionario.TabIndex = 46;
            this.btnLimparCamposFuncionario.Text = "Limpar";
            this.btnLimparCamposFuncionario.UseVisualStyleBackColor = true;
            this.btnLimparCamposFuncionario.Click += new System.EventHandler(this.btnLimparCamposFuncionario_Click);
            // 
            // btnCadastrarFuncionario
            // 
            this.btnCadastrarFuncionario.Location = new System.Drawing.Point(77, 245);
            this.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            this.btnCadastrarFuncionario.Size = new System.Drawing.Size(85, 28);
            this.btnCadastrarFuncionario.TabIndex = 45;
            this.btnCadastrarFuncionario.Text = "Cadastrar";
            this.btnCadastrarFuncionario.UseVisualStyleBackColor = true;
            this.btnCadastrarFuncionario.Click += new System.EventHandler(this.btnCadastrarFuncionario_Click);
            // 
            // mskCPFFuncionario
            // 
            this.mskCPFFuncionario.Location = new System.Drawing.Point(177, 201);
            this.mskCPFFuncionario.Mask = "999.999.999-99";
            this.mskCPFFuncionario.Name = "mskCPFFuncionario";
            this.mskCPFFuncionario.Size = new System.Drawing.Size(96, 20);
            this.mskCPFFuncionario.TabIndex = 44;
            // 
            // lblCPFCad
            // 
            this.lblCPFCad.AutoSize = true;
            this.lblCPFCad.Location = new System.Drawing.Point(174, 185);
            this.lblCPFCad.Name = "lblCPFCad";
            this.lblCPFCad.Size = new System.Drawing.Size(30, 13);
            this.lblCPFCad.TabIndex = 43;
            this.lblCPFCad.Text = "CPF:";
            // 
            // mskTelefoneFuncionario
            // 
            this.mskTelefoneFuncionario.Location = new System.Drawing.Point(24, 201);
            this.mskTelefoneFuncionario.Mask = "(99) 99999-999";
            this.mskTelefoneFuncionario.Name = "mskTelefoneFuncionario";
            this.mskTelefoneFuncionario.Size = new System.Drawing.Size(104, 20);
            this.mskTelefoneFuncionario.TabIndex = 42;
            // 
            // lblTelefoneCad
            // 
            this.lblTelefoneCad.AutoSize = true;
            this.lblTelefoneCad.Location = new System.Drawing.Point(24, 185);
            this.lblTelefoneCad.Name = "lblTelefoneCad";
            this.lblTelefoneCad.Size = new System.Drawing.Size(52, 13);
            this.lblTelefoneCad.TabIndex = 41;
            this.lblTelefoneCad.Text = "Telefone:";
            // 
            // txtEnderecoFuncionario
            // 
            this.txtEnderecoFuncionario.Location = new System.Drawing.Point(24, 157);
            this.txtEnderecoFuncionario.Name = "txtEnderecoFuncionario";
            this.txtEnderecoFuncionario.Size = new System.Drawing.Size(285, 20);
            this.txtEnderecoFuncionario.TabIndex = 40;
            // 
            // lblEnderecoCad
            // 
            this.lblEnderecoCad.AutoSize = true;
            this.lblEnderecoCad.Location = new System.Drawing.Point(21, 141);
            this.lblEnderecoCad.Name = "lblEnderecoCad";
            this.lblEnderecoCad.Size = new System.Drawing.Size(56, 13);
            this.lblEnderecoCad.TabIndex = 39;
            this.lblEnderecoCad.Text = "Endereço:";
            // 
            // txtSenhaFuncionario
            // 
            this.txtSenhaFuncionario.Location = new System.Drawing.Point(24, 113);
            this.txtSenhaFuncionario.Name = "txtSenhaFuncionario";
            this.txtSenhaFuncionario.Size = new System.Drawing.Size(204, 20);
            this.txtSenhaFuncionario.TabIndex = 38;
            // 
            // lblSenhaCad
            // 
            this.lblSenhaCad.AutoSize = true;
            this.lblSenhaCad.Location = new System.Drawing.Point(21, 97);
            this.lblSenhaCad.Name = "lblSenhaCad";
            this.lblSenhaCad.Size = new System.Drawing.Size(41, 13);
            this.lblSenhaCad.TabIndex = 37;
            this.lblSenhaCad.Text = "Senha:";
            // 
            // txtEmailFuncionario
            // 
            this.txtEmailFuncionario.Location = new System.Drawing.Point(24, 69);
            this.txtEmailFuncionario.Name = "txtEmailFuncionario";
            this.txtEmailFuncionario.Size = new System.Drawing.Size(285, 20);
            this.txtEmailFuncionario.TabIndex = 36;
            // 
            // lblEmailCad
            // 
            this.lblEmailCad.AutoSize = true;
            this.lblEmailCad.Location = new System.Drawing.Point(21, 53);
            this.lblEmailCad.Name = "lblEmailCad";
            this.lblEmailCad.Size = new System.Drawing.Size(35, 13);
            this.lblEmailCad.TabIndex = 35;
            this.lblEmailCad.Text = "Email:";
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Location = new System.Drawing.Point(24, 26);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(285, 20);
            this.txtNomeFuncionario.TabIndex = 34;
            // 
            // lblNomeCad
            // 
            this.lblNomeCad.AutoSize = true;
            this.lblNomeCad.Location = new System.Drawing.Point(21, 10);
            this.lblNomeCad.Name = "lblNomeCad";
            this.lblNomeCad.Size = new System.Drawing.Size(38, 13);
            this.lblNomeCad.TabIndex = 33;
            this.lblNomeCad.Text = "Nome:";
            // 
            // FormFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 283);
            this.Controls.Add(this.btnAlterarDadosFuncionario);
            this.Controls.Add(this.btnLimparCamposFuncionario);
            this.Controls.Add(this.btnCadastrarFuncionario);
            this.Controls.Add(this.mskCPFFuncionario);
            this.Controls.Add(this.lblCPFCad);
            this.Controls.Add(this.mskTelefoneFuncionario);
            this.Controls.Add(this.lblTelefoneCad);
            this.Controls.Add(this.txtEnderecoFuncionario);
            this.Controls.Add(this.lblEnderecoCad);
            this.Controls.Add(this.txtSenhaFuncionario);
            this.Controls.Add(this.lblSenhaCad);
            this.Controls.Add(this.txtEmailFuncionario);
            this.Controls.Add(this.lblEmailCad);
            this.Controls.Add(this.txtNomeFuncionario);
            this.Controls.Add(this.lblNomeCad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Novo Funcionario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterarDadosFuncionario;
        private System.Windows.Forms.Button btnLimparCamposFuncionario;
        private System.Windows.Forms.Button btnCadastrarFuncionario;
        private System.Windows.Forms.MaskedTextBox mskCPFFuncionario;
        private System.Windows.Forms.Label lblCPFCad;
        private System.Windows.Forms.MaskedTextBox mskTelefoneFuncionario;
        private System.Windows.Forms.Label lblTelefoneCad;
        private System.Windows.Forms.TextBox txtEnderecoFuncionario;
        private System.Windows.Forms.Label lblEnderecoCad;
        private System.Windows.Forms.TextBox txtSenhaFuncionario;
        private System.Windows.Forms.Label lblSenhaCad;
        private System.Windows.Forms.TextBox txtEmailFuncionario;
        private System.Windows.Forms.Label lblEmailCad;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.Label lblNomeCad;
    }
}