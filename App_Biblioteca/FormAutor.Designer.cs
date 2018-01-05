namespace App_Biblioteca
{
    partial class FormAutor
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
            this.btnAlterarDadosAutor = new System.Windows.Forms.Button();
            this.txtPaisOrigem = new System.Windows.Forms.TextBox();
            this.lblPaisOrigemn = new System.Windows.Forms.Label();
            this.btnCadastrarAutor = new System.Windows.Forms.Button();
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.lblNomeAutor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAlterarDadosAutor
            // 
            this.btnAlterarDadosAutor.Location = new System.Drawing.Point(75, 98);
            this.btnAlterarDadosAutor.Name = "btnAlterarDadosAutor";
            this.btnAlterarDadosAutor.Size = new System.Drawing.Size(103, 23);
            this.btnAlterarDadosAutor.TabIndex = 10;
            this.btnAlterarDadosAutor.Text = "Alterar Autor";
            this.btnAlterarDadosAutor.UseVisualStyleBackColor = true;
            this.btnAlterarDadosAutor.Visible = false;
            this.btnAlterarDadosAutor.Click += new System.EventHandler(this.btnAlterarDadosAutor_Click);
            // 
            // txtPaisOrigem
            // 
            this.txtPaisOrigem.Location = new System.Drawing.Point(18, 72);
            this.txtPaisOrigem.MaxLength = 30;
            this.txtPaisOrigem.Name = "txtPaisOrigem";
            this.txtPaisOrigem.Size = new System.Drawing.Size(141, 20);
            this.txtPaisOrigem.TabIndex = 7;
            // 
            // lblPaisOrigemn
            // 
            this.lblPaisOrigemn.AutoSize = true;
            this.lblPaisOrigemn.Location = new System.Drawing.Point(15, 55);
            this.lblPaisOrigemn.Name = "lblPaisOrigemn";
            this.lblPaisOrigemn.Size = new System.Drawing.Size(81, 13);
            this.lblPaisOrigemn.TabIndex = 8;
            this.lblPaisOrigemn.Text = "Pais de Origem:";
            // 
            // btnCadastrarAutor
            // 
            this.btnCadastrarAutor.Location = new System.Drawing.Point(75, 98);
            this.btnCadastrarAutor.Name = "btnCadastrarAutor";
            this.btnCadastrarAutor.Size = new System.Drawing.Size(103, 23);
            this.btnCadastrarAutor.TabIndex = 9;
            this.btnCadastrarAutor.Text = "Cadastrar Autor";
            this.btnCadastrarAutor.UseVisualStyleBackColor = true;
            this.btnCadastrarAutor.Click += new System.EventHandler(this.btnCadastrarAutor_Click);
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.Location = new System.Drawing.Point(15, 28);
            this.txtNomeAutor.MaxLength = 100;
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(227, 20);
            this.txtNomeAutor.TabIndex = 6;
            // 
            // lblNomeAutor
            // 
            this.lblNomeAutor.AutoSize = true;
            this.lblNomeAutor.Location = new System.Drawing.Point(12, 11);
            this.lblNomeAutor.Name = "lblNomeAutor";
            this.lblNomeAutor.Size = new System.Drawing.Size(81, 13);
            this.lblNomeAutor.TabIndex = 5;
            this.lblNomeAutor.Text = "Nome do Autor:";
            // 
            // FormAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 132);
            this.Controls.Add(this.btnAlterarDadosAutor);
            this.Controls.Add(this.txtPaisOrigem);
            this.Controls.Add(this.lblPaisOrigemn);
            this.Controls.Add(this.btnCadastrarAutor);
            this.Controls.Add(this.txtNomeAutor);
            this.Controls.Add(this.lblNomeAutor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Novo Autor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterarDadosAutor;
        private System.Windows.Forms.TextBox txtPaisOrigem;
        private System.Windows.Forms.Label lblPaisOrigemn;
        private System.Windows.Forms.Button btnCadastrarAutor;
        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.Label lblNomeAutor;
    }
}