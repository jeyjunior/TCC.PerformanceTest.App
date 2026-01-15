using BenchmarkDotNet.Running;
using InfraData.Repositorys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Principal : Form
    {

        public Principal()
        {
            InitializeComponent();
        }

        private void btnCadastroString_Click(object sender, EventArgs e)
        {
            var parametros = new Parametros();
            parametros.FormClosed += Parametros_FormClosed;
            parametros.ShowDialog();
        }

        private void Parametros_FormClosed(object sender, FormClosedEventArgs e)
        {
            // ATUALIZAR GRID
            MessageBox.Show("Teste");
        }
    }
}
