using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto2
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // esqueci a senha
            esqSenha telasenha = new esqSenha();
            telasenha.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // se cadastrar

        }
        // Essa parte é do botão login
        private void Login_Click(object sender, EventArgs e)
        {
            if (User.Text == "")
                // Campos do Usuário em Branco
            {
                MessageBox.Show("Preencha o Usuário!");
            }
            else if (passw.Text == "")
                // Senha em Branco
            {
                MessageBox.Show("Preencha a Senha!");
            }
            if (User.Text == "Admin" && passw.Text == "Admin")
            {
                // Abre a Tela 7, vulgo tela CONTA
                MessageBox.Show("Bem Vindo!");
                Conta telaconta = new Conta();
                telaconta.Show();

            }
            else
            {
                MessageBox.Show("Sua senha ou usuário estão incorretos!");
                // Abre tela erro
            }
        }
    }
}
