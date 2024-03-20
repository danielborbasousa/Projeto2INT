
namespace Projeto2
{
    partial class Inicio
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
            this.Terms = new System.Windows.Forms.CheckBox();
            this.esqSenha = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.User = new System.Windows.Forms.TextBox();
            this.passw = new System.Windows.Forms.TextBox();
            this.usertexto = new System.Windows.Forms.Label();
            this.senhatexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Terms
            // 
            this.Terms.AutoSize = true;
            this.Terms.Location = new System.Drawing.Point(229, 133);
            this.Terms.Name = "Terms";
            this.Terms.Size = new System.Drawing.Size(116, 17);
            this.Terms.TabIndex = 13;
            this.Terms.Text = "Termos e Licenças";
            this.Terms.UseVisualStyleBackColor = true;
            this.Terms.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // esqSenha
            // 
            this.esqSenha.Location = new System.Drawing.Point(96, 129);
            this.esqSenha.Name = "esqSenha";
            this.esqSenha.Size = new System.Drawing.Size(110, 23);
            this.esqSenha.TabIndex = 9;
            this.esqSenha.Text = "Esqueceu a senha?";
            this.esqSenha.UseVisualStyleBackColor = true;
            this.esqSenha.Click += new System.EventHandler(this.button3_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(151, 169);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(121, 45);
            this.Login.TabIndex = 14;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // User
            // 
            this.User.Location = new System.Drawing.Point(130, 77);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(179, 20);
            this.User.TabIndex = 15;
            // 
            // passw
            // 
            this.passw.Location = new System.Drawing.Point(130, 107);
            this.passw.Name = "passw";
            this.passw.PasswordChar = '*';
            this.passw.Size = new System.Drawing.Size(179, 20);
            this.passw.TabIndex = 16;
            // 
            // usertexto
            // 
            this.usertexto.AutoSize = true;
            this.usertexto.Location = new System.Drawing.Point(89, 80);
            this.usertexto.Name = "usertexto";
            this.usertexto.Size = new System.Drawing.Size(43, 13);
            this.usertexto.TabIndex = 17;
            this.usertexto.Text = "Usuário";
            // 
            // senhatexto
            // 
            this.senhatexto.AutoSize = true;
            this.senhatexto.Location = new System.Drawing.Point(89, 110);
            this.senhatexto.Name = "senhatexto";
            this.senhatexto.Size = new System.Drawing.Size(38, 13);
            this.senhatexto.TabIndex = 18;
            this.senhatexto.Text = "Senha";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 290);
            this.Controls.Add(this.senhatexto);
            this.Controls.Add(this.usertexto);
            this.Controls.Add(this.passw);
            this.Controls.Add(this.User);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Terms);
            this.Controls.Add(this.esqSenha);
            this.Name = "Inicio";
            this.Text = "Tela de Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Terms;
        private System.Windows.Forms.Button esqSenha;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.TextBox User;
        private System.Windows.Forms.TextBox passw;
        private System.Windows.Forms.Label usertexto;
        private System.Windows.Forms.Label senhatexto;
    }
}

