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
        private Item AmbienteSelecionado;

        public Principal()
        {
            InitializeComponent();
        }

        #region Eventos
        private void Principal_Load(object sender, EventArgs e)
        {
            CarregarAmbiente();
        }
        private void cboAmbiente_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboAmbiente.SelectedValue == null)
                return;

            AmbienteSelecionado = (Item)cboAmbiente.SelectedItem;

            if (AmbienteSelecionado.ID == (int)eTipoAmbiente.OnPremise)
            {
                txtStringConexao.Text = "Server=JUNIOR\\JJ;Database=JJ;Integrated Security=True;TrustServerCertificate=True;";
            }
            else if (AmbienteSelecionado.ID == (int)eTipoAmbiente.Cloud)
            {
                txtStringConexao.Text = "Cloud";
            }
            else
            {
                txtStringConexao.Text = "";
            }
        }
        #endregion
        #region Metodos
        private void CarregarAmbiente()
        {
            var itens = new List<Item>()
            {
                new Item { ID = (int)eTipoAmbiente.OnPremise, Descricao = eTipoAmbiente.OnPremise.ToString()},
                new Item { ID = (int)eTipoAmbiente.Cloud, Descricao = eTipoAmbiente.Cloud.ToString()},
            };

            cboAmbiente.DataSource = itens;
            cboAmbiente.DisplayMember = "Descricao";
            cboAmbiente.ValueMember = "ID";
            cboAmbiente.SelectedItem = itens.FirstOrDefault();
        }
        #endregion

        private async void btnTestar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validação básica
                if (string.IsNullOrEmpty(txtStringConexao.Text))
                {
                    MessageBox.Show("Preencha a String de Conexão!");
                    return;
                }

                // 1. Salva os inputs
                BenchmarkConfig.ConnectionStringAtual = txtStringConexao.Text;
                BenchmarkConfig.QuantidadeRegistros = int.Parse(txtQtdRegistro.Text);
                BenchmarkConfig.TipoAmbiente = (eTipoAmbiente)AmbienteSelecionado.ID;

                lblStatus.Text = "Status: Rodando Benchmark... Aguarde!";
                btnTestar.Enabled = false;

                // 2. Roda o Benchmark
                await Task.Run(() =>
                {
                    // O BenchmarkRunner lança logs no Console. 
                    // Como é WinForms, você não verá, mas o arquivo será gerado.
                    var summary = BenchmarkDotNet.Running.BenchmarkRunner.Run<TesteCRUD>();
                });

                lblStatus.Text = "Concluído!";

                // 3. Abre pasta
                string path = System.IO.Directory.GetCurrentDirectory() + "\\BenchmarkDotNet.Artifacts\\results";
                if (System.IO.Directory.Exists(path))
                    System.Diagnostics.Process.Start(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao rodar teste: {ex.Message}");
                lblStatus.Text = "Erro!";
            }
            finally
            {
                btnTestar.Enabled = true;
            }
        }
    }
}
