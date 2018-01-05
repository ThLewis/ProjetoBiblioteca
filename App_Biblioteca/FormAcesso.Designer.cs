namespace App_Biblioteca
{
    partial class FormAcesso
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAcessar = new System.Windows.Forms.Button();
            this.txtSenhaAcesso = new System.Windows.Forms.TextBox();
            this.lblSenhaEntrada = new System.Windows.Forms.Label();
            this.txtUsernameAcesso = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAcessar
            // 
            this.btnAcessar.Location = new System.Drawing.Point(271, 237);
            this.btnAcessar.Name = "btnAcessar";
            this.btnAcessar.Size = new System.Drawing.Size(75, 23);
            this.btnAcessar.TabIndex = 10;
            this.btnAcessar.Text = "Acessar";
            this.btnAcessar.UseVisualStyleBackColor = true;
            this.btnAcessar.Click += new System.EventHandler(this.btnAcessar_Click);
            // 
            // txtSenhaAcesso
            // 
            this.txtSenhaAcesso.Location = new System.Drawing.Point(256, 210);
            this.txtSenhaAcesso.Name = "txtSenhaAcesso";
            this.txtSenhaAcesso.PasswordChar = '*';
            this.txtSenhaAcesso.Size = new System.Drawing.Size(141, 20);
            this.txtSenhaAcesso.TabIndex = 9;
            // 
            // lblSenhaEntrada
            // 
            this.lblSenhaEntrada.AutoSize = true;
            this.lblSenhaEntrada.Location = new System.Drawing.Point(152, 213);
            this.lblSenhaEntrada.Name = "lblSenhaEntrada";
            this.lblSenhaEntrada.Size = new System.Drawing.Size(97, 13);
            this.lblSenhaEntrada.TabIndex = 8;
            this.lblSenhaEntrada.Text = "Senha de Acesso: ";
            // 
            // txtUsernameAcesso
            // 
            this.txtUsernameAcesso.Location = new System.Drawing.Point(255, 176);
            this.txtUsernameAcesso.Name = "txtUsernameAcesso";
            this.txtUsernameAcesso.Size = new System.Drawing.Size(142, 20);
            this.txtUsernameAcesso.TabIndex = 7;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(138, 179);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(111, 13);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Username de Acesso:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App_Biblioteca.Properties.Resources.Biblioteca_logo;
            this.pictureBox1.Location = new System.Drawing.Point(171, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FormAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 278);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAcessar);
            this.Controls.Add(this.txtSenhaAcesso);
            this.Controls.Add(this.lblSenhaEntrada);
            this.Controls.Add(this.txtUsernameAcesso);
            this.Controls.Add(this.lblUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAcesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acesso Sistema Biblioteca";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAcessar;
        private System.Windows.Forms.TextBox txtSenhaAcesso;
        private System.Windows.Forms.Label lblSenhaEntrada;
        private System.Windows.Forms.TextBox txtUsernameAcesso;
        private System.Windows.Forms.Label lblUsername;
    }
}

