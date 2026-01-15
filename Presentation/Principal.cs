using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BenchmarkDotNet.Running;
using Domain.Entities;
using Domain.Enumerators;
using Domain.Extension;
using InfraData.Repositorys;

namespace Presentation
{
    public partial class Principal : Form
    {
        #region Repositorios
        private ParametroRepository _parametroRepository;
        #endregion

        #region Propriedades
        private List<int> _iDsSelecionado = new List<int>();
        private IEnumerable<Parametro> _parametroCollection = null;
        #endregion

        #region Construtor
        public Principal()
        {
            InitializeComponent();

            _parametroRepository = new ParametroRepository(new InfraData.Context.DbSession());
        }
        #endregion

        #region Eventos
        private void Principal_Load(object sender, EventArgs e)
        {
            BindParametrosConexao(); 
        }
        private void btnCadastroString_Click(object sender, EventArgs e)
        {
            var parametros = new Parametros();
            parametros.FormClosed += Parametros_FormClosed;
            parametros.ShowDialog();
        }
        private void Parametros_FormClosed(object sender, FormClosedEventArgs e)
        {
            BindParametrosConexao();
        }
        private void dtgPrincipal_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            for (int i = 0; i < dtgPrincipal.Rows.Count; i++)
            {
                dtgPrincipal.Rows[i].Cells["colCheck"].Value = 0;
            }
        }
        private void dtgPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewRow linha = dtgPrincipal.Rows[e.RowIndex];
                    DataGridViewCell cell = linha.Cells[e.ColumnIndex];

                    bool check = linha.Cells["colCheck"].Value.ToString().ToBoolean();

                    switch (dtgPrincipal.Columns[e.ColumnIndex].Name)
                    {
                        case "colCheck":

                            int pK_Parametro = 0;
                            Int32.TryParse(linha.Cells["colPK_Parametro"].Value.ToString(), out pK_Parametro);

                            if (check)
                            {
                                linha.Cells["colCheck"].Value = 0;
                                _iDsSelecionado.Remove(pK_Parametro);
                            }
                            else
                            {
                                linha.Cells["colCheck"].Value = 1;
                                _iDsSelecionado.Add(pK_Parametro);
                            }
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private void btnBenchmark_Click(object sender, EventArgs e)
        {
            if (_iDsSelecionado.Count <= 0)
            {
                MessageBox.Show("É preciso marcar pelo menos uma conexão para teste.");
                return;
            }
        }
        #endregion

        #region Metodos
        private void BindParametrosConexao()
        {
            _iDsSelecionado.Clear();
            _parametroCollection = _parametroRepository.ObterLista().Where(i => i.FK_Ambiente != 1).ToList();

            var itens = _parametroCollection.Select(i => new
            {
                PK_Parametro = i.PK_Parametro,
                Descricao = i.Descricao,
                Conexao = i.StringConexao,
            }).ToList();

            dtgPrincipal.DataSource = itens;
        }
        #endregion
    }
}
