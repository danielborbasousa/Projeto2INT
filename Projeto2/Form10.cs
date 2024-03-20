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
    public partial class telainicial : Form
    {
        public telainicial()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void telInicial_Load(object sender, EventArgs e)
        {

        }

        private void telVendedor_Click(object sender, EventArgs e)
        {
            vendas Vendas = new vendas();
            Vendas.Show();
        }

        private void btnsairte_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void telCliente_Click(object sender, EventArgs e)
        {
            Produto produtos = new Produto();
            produtos.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pedidos pedidos = new Pedidos();
            pedidos.Show();
        }
    }
}
