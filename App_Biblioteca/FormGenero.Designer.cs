namespace App_Biblioteca
{
    partial class FormGenero
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
            this.btnAlterarDadosGenero = new System.Windows.Forms.Button();
            this.btnCadastrarGenero = new System.Windows.Forms.Button();
            this.txtNomeGenero = new System.Windows.Forms.TextBox();
            this.lblGenero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAlterarDadosGenero
            // 
            this.btnAlterarDadosGenero.Location = new System.Drawing.Point(72, 63);
            this.btnAlterarDadosGenero.Name = "btnAlterarDadosGenero";
            this.btnAlterarDadosGenero.Size = new System.Drawing.Size(106, 23);
            this.btnAlterarDadosGenero.TabIndex = 7;
            this.btnAlterarDadosGenero.Text = "Alterar Gênero";
            this.btnAlterarDadosGenero.UseVisualStyleBackColor = true;
            this.btnAlterarDadosGenero.Visible = false;
            this.btnAlterarDadosGenero.Click += new System.EventHandler(this.btnAlterarDadosGenero_Click);
            // 
            // btnCadastrarGenero
            // 
            this.btnCadastrarGenero.Location = new System.Drawing.Point(72, 63);
            this.btnCadastrarGenero.Name = "btnCadastrarGenero";
            this.btnCadastrarGenero.Size = new System.Drawing.Size(106, 23);
            this.btnCadastrarGenero.TabIndex = 6;
            this.btnCadastrarGenero.Text = "Cadastrar Gênero";
            this.btnCadastrarGenero.UseVisualStyleBackColor = true;
            this.btnCadastrarGenero.Click += new System.EventHandler(this.btnCadastrarGenero_Click);
            // 
            // txtNomeGenero
            // 
            this.txtNomeGenero.Location = new System.Drawing.Point(24, 30);
            this.txtNomeGenero.MaxLength = 50;
            this.txtNomeGenero.Name = "txtNomeGenero";
            this.txtNomeGenero.Size = new System.Drawing.Size(192, 20);
            this.txtNomeGenero.TabIndex = 5;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(21, 13);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(45, 13);
            this.lblGenero.TabIndex = 4;
            this.lblGenero.Text = "Gênero:";
            // 
            // FormGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 98);
            this.Controls.Add(this.btnAlterarDadosGenero);
            this.Controls.Add(this.btnCadastrarGenero);
            this.Controls.Add(this.txtNomeGenero);
            this.Controls.Add(this.lblGenero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormGenero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Novo Gênero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterarDadosGenero;
        private System.Windows.Forms.Button btnCadastrarGenero;
        private System.Windows.Forms.TextBox txtNomeGenero;
        private System.Windows.Forms.Label lblGenero;
    }
}