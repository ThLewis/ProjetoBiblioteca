namespace App_Biblioteca
{
    partial class FormCliente
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
            this.btnAlterarDadosCliente = new System.Windows.Forms.Button();
            this.btnLimparCamposCliente = new System.Windows.Forms.Button();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.gbxSexoCliente = new System.Windows.Forms.GroupBox();
            this.rbnMasculino = new System.Windows.Forms.RadioButton();
            this.rbnFeminino = new System.Windows.Forms.RadioButton();
            this.mskCPFCliente = new System.Windows.Forms.MaskedTextBox();
            this.lblCPFCad = new System.Windows.Forms.Label();
            this.mskTelefoneCliente = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefoneCad = new System.Windows.Forms.Label();
            this.txtEnderecoCliente = new System.Windows.Forms.TextBox();
            this.lblEnderecoCad = new System.Windows.Forms.Label();
            this.txtSenhaCliente = new System.Windows.Forms.TextBox();
            this.lblSenhaCad = new System.Windows.Forms.Label();
            this.txtEmailCliente = new System.Windows.Forms.TextBox();
            this.lblEmailCad = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblNomeCad = new System.Windows.Forms.Label();
            this.gbxSexoCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAlterarDadosCliente
            // 
            this.btnAlterarDadosCliente.Location = new System.Drawing.Point(79, 299);
            this.btnAlterarDadosCliente.Name = "btnAlterarDadosCliente";
            this.btnAlterarDadosCliente.Size = new System.Drawing.Size(85, 28);
            this.btnAlterarDadosCliente.TabIndex = 32;
            this.btnAlterarDadosCliente.Text = "Alterar Dados";
            this.btnAlterarDadosCliente.UseVisualStyleBackColor = true;
            this.btnAlterarDadosCliente.Visible = false;
            this.btnAlterarDadosCliente.Click += new System.EventHandler(this.btnAlterarDadosCliente_Click);
            // 
            // btnLimparCamposCliente
            // 
            this.btnLimparCamposCliente.Location = new System.Drawing.Point(179, 299);
            this.btnLimparCamposCliente.Name = "btnLimparCamposCliente";
            this.btnLimparCamposCliente.Size = new System.Drawing.Size(85, 28);
            this.btnLimparCamposCliente.TabIndex = 31;
            this.btnLimparCamposCliente.Text = "Limpar";
            this.btnLimparCamposCliente.UseVisualStyleBackColor = true;
            this.btnLimparCamposCliente.Click += new System.EventHandler(this.btnLimparCamposCliente_Click);
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Location = new System.Drawing.Point(79, 299);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(85, 28);
            this.btnCadastrarCliente.TabIndex = 30;
            this.btnCadastrarCliente.Text = "Cadastrar";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // gbxSexoCliente
            // 
            this.gbxSexoCliente.Controls.Add(this.rbnMasculino);
            this.gbxSexoCliente.Controls.Add(this.rbnFeminino);
            this.gbxSexoCliente.Location = new System.Drawing.Point(26, 143);
            this.gbxSexoCliente.Name = "gbxSexoCliente";
            this.gbxSexoCliente.Size = new System.Drawing.Size(201, 42);
            this.gbxSexoCliente.TabIndex = 29;
            this.gbxSexoCliente.TabStop = false;
            this.gbxSexoCliente.Text = "Sexo";
            // 
            // rbnMasculino
            // 
            this.rbnMasculino.AutoSize = true;
            this.rbnMasculino.Location = new System.Drawing.Point(86, 19);
            this.rbnMasculino.Name = "rbnMasculino";
            this.rbnMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbnMasculino.TabIndex = 1;
            this.rbnMasculino.Text = "Masculino";
            this.rbnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbnFeminino
            // 
            this.rbnFeminino.AutoSize = true;
            this.rbnFeminino.Checked = true;
            this.rbnFeminino.Location = new System.Drawing.Point(7, 20);
            this.rbnFeminino.Name = "rbnFeminino";
            this.rbnFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbnFeminino.TabIndex = 0;
            this.rbnFeminino.TabStop = true;
            this.rbnFeminino.Text = "Feminino";
            this.rbnFeminino.UseVisualStyleBackColor = true;
            // 
            // mskCPFCliente
            // 
            this.mskCPFCliente.Location = new System.Drawing.Point(179, 255);
            this.mskCPFCliente.Mask = "999.999.999-99";
            this.mskCPFCliente.Name = "mskCPFCliente";
            this.mskCPFCliente.Size = new System.Drawing.Size(96, 20);
            this.mskCPFCliente.TabIndex = 28;
            // 
            // lblCPFCad
            // 
            this.lblCPFCad.AutoSize = true;
            this.lblCPFCad.Location = new System.Drawing.Point(176, 239);
            this.lblCPFCad.Name = "lblCPFCad";
            this.lblCPFCad.Size = new System.Drawing.Size(30, 13);
            this.lblCPFCad.TabIndex = 27;
            this.lblCPFCad.Text = "CPF:";
            // 
            // mskTelefoneCliente
            // 
            this.mskTelefoneCliente.Location = new System.Drawing.Point(26, 255);
            this.mskTelefoneCliente.Mask = "(99) 99999-999";
            this.mskTelefoneCliente.Name = "mskTelefoneCliente";
            this.mskTelefoneCliente.Size = new System.Drawing.Size(104, 20);
            this.mskTelefoneCliente.TabIndex = 26;
            // 
            // lblTelefoneCad
            // 
            this.lblTelefoneCad.AutoSize = true;
            this.lblTelefoneCad.Location = new System.Drawing.Point(26, 239);
            this.lblTelefoneCad.Name = "lblTelefoneCad";
            this.lblTelefoneCad.Size = new System.Drawing.Size(52, 13);
            this.lblTelefoneCad.TabIndex = 25;
            this.lblTelefoneCad.Text = "Telefone:";
            // 
            // txtEnderecoCliente
            // 
            this.txtEnderecoCliente.Location = new System.Drawing.Point(26, 211);
            this.txtEnderecoCliente.Name = "txtEnderecoCliente";
            this.txtEnderecoCliente.Size = new System.Drawing.Size(285, 20);
            this.txtEnderecoCliente.TabIndex = 24;
            // 
            // lblEnderecoCad
            // 
            this.lblEnderecoCad.AutoSize = true;
            this.lblEnderecoCad.Location = new System.Drawing.Point(23, 195);
            this.lblEnderecoCad.Name = "lblEnderecoCad";
            this.lblEnderecoCad.Size = new System.Drawing.Size(56, 13);
            this.lblEnderecoCad.TabIndex = 23;
            this.lblEnderecoCad.Text = "Endereço:";
            // 
            // txtSenhaCliente
            // 
            this.txtSenhaCliente.Location = new System.Drawing.Point(23, 116);
            this.txtSenhaCliente.Name = "txtSenhaCliente";
            this.txtSenhaCliente.Size = new System.Drawing.Size(204, 20);
            this.txtSenhaCliente.TabIndex = 22;
            // 
            // lblSenhaCad
            // 
            this.lblSenhaCad.AutoSize = true;
            this.lblSenhaCad.Location = new System.Drawing.Point(20, 100);
            this.lblSenhaCad.Name = "lblSenhaCad";
            this.lblSenhaCad.Size = new System.Drawing.Size(41, 13);
            this.lblSenhaCad.TabIndex = 21;
            this.lblSenhaCad.Text = "Senha:";
            // 
            // txtEmailCliente
            // 
            this.txtEmailCliente.Location = new System.Drawing.Point(23, 72);
            this.txtEmailCliente.Name = "txtEmailCliente";
            this.txtEmailCliente.Size = new System.Drawing.Size(285, 20);
            this.txtEmailCliente.TabIndex = 20;
            // 
            // lblEmailCad
            // 
            this.lblEmailCad.AutoSize = true;
            this.lblEmailCad.Location = new System.Drawing.Point(20, 56);
            this.lblEmailCad.Name = "lblEmailCad";
            this.lblEmailCad.Size = new System.Drawing.Size(35, 13);
            this.lblEmailCad.TabIndex = 19;
            this.lblEmailCad.Text = "Email:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(23, 29);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(285, 20);
            this.txtNomeCliente.TabIndex = 18;
            // 
            // lblNomeCad
            // 
            this.lblNomeCad.AutoSize = true;
            this.lblNomeCad.Location = new System.Drawing.Point(20, 13);
            this.lblNomeCad.Name = "lblNomeCad";
            this.lblNomeCad.Size = new System.Drawing.Size(38, 13);
            this.lblNomeCad.TabIndex = 17;
            this.lblNomeCad.Text = "Nome:";
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 340);
            this.Controls.Add(this.btnAlterarDadosCliente);
            this.Controls.Add(this.btnLimparCamposCliente);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Controls.Add(this.gbxSexoCliente);
            this.Controls.Add(this.mskCPFCliente);
            this.Controls.Add(this.lblCPFCad);
            this.Controls.Add(this.mskTelefoneCliente);
            this.Controls.Add(this.lblTelefoneCad);
            this.Controls.Add(this.txtEnderecoCliente);
            this.Controls.Add(this.lblEnderecoCad);
            this.Controls.Add(this.txtSenhaCliente);
            this.Controls.Add(this.lblSenhaCad);
            this.Controls.Add(this.txtEmailCliente);
            this.Controls.Add(this.lblEmailCad);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.lblNomeCad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastrar Cliente";
            this.gbxSexoCliente.ResumeLayout(false);
            this.gbxSexoCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterarDadosCliente;
        private System.Windows.Forms.Button btnLimparCamposCliente;
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.GroupBox gbxSexoCliente;
        private System.Windows.Forms.RadioButton rbnMasculino;
        private System.Windows.Forms.RadioButton rbnFeminino;
        private System.Windows.Forms.MaskedTextBox mskCPFCliente;
        private System.Windows.Forms.Label lblCPFCad;
        private System.Windows.Forms.MaskedTextBox mskTelefoneCliente;
        private System.Windows.Forms.Label lblTelefoneCad;
        private System.Windows.Forms.TextBox txtEnderecoCliente;
        private System.Windows.Forms.Label lblEnderecoCad;
        private System.Windows.Forms.TextBox txtSenhaCliente;
        private System.Windows.Forms.Label lblSenhaCad;
        private System.Windows.Forms.TextBox txtEmailCliente;
        private System.Windows.Forms.Label lblEmailCad;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lblNomeCad;
    }
}