namespace App_Biblioteca
{
    partial class FormEditora
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
            this.btnAlterarDadosEditora = new System.Windows.Forms.Button();
            this.btnCadastrarEditora = new System.Windows.Forms.Button();
            this.txtEnderecoEditora = new System.Windows.Forms.TextBox();
            this.lblEndEditora = new System.Windows.Forms.Label();
            this.txtNomeEditora = new System.Windows.Forms.TextBox();
            this.lblNomeEditora = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAlterarDadosEditora
            // 
            this.btnAlterarDadosEditora.Location = new System.Drawing.Point(87, 100);
            this.btnAlterarDadosEditora.Name = "btnAlterarDadosEditora";
            this.btnAlterarDadosEditora.Size = new System.Drawing.Size(98, 23);
            this.btnAlterarDadosEditora.TabIndex = 11;
            this.btnAlterarDadosEditora.Text = "Alterar Editora";
            this.btnAlterarDadosEditora.UseVisualStyleBackColor = true;
            this.btnAlterarDadosEditora.Visible = false;
            this.btnAlterarDadosEditora.Click += new System.EventHandler(this.btnAlterarDadosEditora_Click);
            // 
            // btnCadastrarEditora
            // 
            this.btnCadastrarEditora.Location = new System.Drawing.Point(87, 100);
            this.btnCadastrarEditora.Name = "btnCadastrarEditora";
            this.btnCadastrarEditora.Size = new System.Drawing.Size(98, 23);
            this.btnCadastrarEditora.TabIndex = 10;
            this.btnCadastrarEditora.Text = "Cadastrar Editora";
            this.btnCadastrarEditora.UseVisualStyleBackColor = true;
            this.btnCadastrarEditora.Click += new System.EventHandler(this.btnCadastrarEditora_Click);
            // 
            // txtEnderecoEditora
            // 
            this.txtEnderecoEditora.Location = new System.Drawing.Point(19, 74);
            this.txtEnderecoEditora.MaxLength = 500;
            this.txtEnderecoEditora.Name = "txtEnderecoEditora";
            this.txtEnderecoEditora.Size = new System.Drawing.Size(239, 20);
            this.txtEnderecoEditora.TabIndex = 9;
            // 
            // lblEndEditora
            // 
            this.lblEndEditora.AutoSize = true;
            this.lblEndEditora.Location = new System.Drawing.Point(16, 57);
            this.lblEndEditora.Name = "lblEndEditora";
            this.lblEndEditora.Size = new System.Drawing.Size(56, 13);
            this.lblEndEditora.TabIndex = 8;
            this.lblEndEditora.Text = "Endereço:";
            // 
            // txtNomeEditora
            // 
            this.txtNomeEditora.Location = new System.Drawing.Point(16, 30);
            this.txtNomeEditora.MaxLength = 50;
            this.txtNomeEditora.Name = "txtNomeEditora";
            this.txtNomeEditora.Size = new System.Drawing.Size(139, 20);
            this.txtNomeEditora.TabIndex = 7;
            // 
            // lblNomeEditora
            // 
            this.lblNomeEditora.AutoSize = true;
            this.lblNomeEditora.Location = new System.Drawing.Point(13, 13);
            this.lblNomeEditora.Name = "lblNomeEditora";
            this.lblNomeEditora.Size = new System.Drawing.Size(89, 13);
            this.lblNomeEditora.TabIndex = 6;
            this.lblNomeEditora.Text = "Nome da Editora:";
            // 
            // FormEditora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 136);
            this.Controls.Add(this.btnAlterarDadosEditora);
            this.Controls.Add(this.btnCadastrarEditora);
            this.Controls.Add(this.txtEnderecoEditora);
            this.Controls.Add(this.lblEndEditora);
            this.Controls.Add(this.txtNomeEditora);
            this.Controls.Add(this.lblNomeEditora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormEditora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nova Editora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterarDadosEditora;
        private System.Windows.Forms.Button btnCadastrarEditora;
        private System.Windows.Forms.TextBox txtEnderecoEditora;
        private System.Windows.Forms.Label lblEndEditora;
        private System.Windows.Forms.TextBox txtNomeEditora;
        private System.Windows.Forms.Label lblNomeEditora;
    }
}