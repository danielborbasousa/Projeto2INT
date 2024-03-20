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
    public partial class Produto : Form
    {
        public Produto()
        {
            InitializeComponent();
        }

        private void Retornar_Click(object sender, EventArgs e)
        {
            telainicial TelaInicial = new telainicial();
            TelaInicial.Show();
        }
    }
}
