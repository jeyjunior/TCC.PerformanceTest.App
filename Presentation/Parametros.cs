using Domain.Entities;
using Domain.Enumerators;
using InfraData.Repositorys;
using System;
using System.Collections;
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
    public partial class Parametros : Form
    {
        #region Repositorios
        private ParametroRepository _parametroRepository;
        #endregion

        #region Propriedades
        private eOperacao _operacaoAtual = eOperacao.Nenhuma;
        private Parametro _parametroSelecionado = null;
        private IEnumerable<Parametro> _parametroCollection = null;
        #endregion

        #region Construtor
        public Parametros()
        {
            InitializeComponent();
            _parametroRepository = new ParametroRepository(new InfraData.Context.DbSession());
        }
        #endregion

        #region Eventos
        private void Parametros_Load(object sender, EventArgs e)
        {
            CarregarComboBoxAmbiente();
            ExibirBotoesCRUD(true, eOperacao.Nenhuma);
            Bind();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            _parametroSelecionado = null;
            ExibirBotoesCRUD(false, eOperacao.Adicionar);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dtgPrincipal.Rows.Count <= 0)
                return;

            if (dtgPrincipal.SelectedRows.Count <= 0)
                return;

            ExibirBotoesCRUD(false, eOperacao.Alterar);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            ExibirBotoesCRUD(false, eOperacao.Deletar);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (_operacaoAtual)
            {
                case eOperacao.Nenhuma:
                    break;
                case eOperacao.Adicionar:
                    _parametroSelecionado = new Parametro
                    {
                        PK_Parametro = 0,
                        Descricao = txtDescricao.Text,
                        StringConexao = txtString.Text,
                        FK_Ambiente = (int)((eTipoAmbiente)cboAmbiente.SelectedItem)
                    };

                    _parametroRepository.Adicionar(_parametroSelecionado);

                    break;
                case eOperacao.Alterar:

                    _parametroSelecionado.Descricao = txtDescricao.Text;
                    _parametroSelecionado.StringConexao = txtString.Text;
                    _parametroSelecionado.FK_Ambiente = (int)((eTipoAmbiente)cboAmbiente.SelectedIndex);

                    _parametroRepository.Atualizar(_parametroSelecionado);

                    break;
                case eOperacao.Deletar:
                    if (_parametroSelecionado == null || _parametroSelecionado.PK_Parametro <= 0)
                        return;

                    _parametroRepository.Excluir(_parametroSelecionado.PK_Parametro);
                    break;
                default:
                    break;
            }

            _operacaoAtual = eOperacao.Nenhuma;

            ExibirBotoesCRUD(true, eOperacao.Nenhuma);
            Bind();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ExibirBotoesCRUD(true, eOperacao.Nenhuma);
        }
        private void dtgPrincipal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgPrincipal.Rows.Count <= 0)
                return;

            var valor = dtgPrincipal.SelectedRows[0].Cells["colPK_Parametro"].Value;
            if (valor == null)
                return;

            _parametroSelecionado = _parametroCollection.FirstOrDefault(i => i.PK_Parametro == Convert.ToInt32(valor));
            if (_parametroSelecionado == null)
                return;

            txtDescricao.Text = _parametroSelecionado.Descricao;
            txtString.Text = _parametroSelecionado.StringConexao;
            cboAmbiente.SelectedItem = (eTipoAmbiente)_parametroSelecionado.FK_Ambiente;
        }
        #endregion

        #region Metodos
        private void CarregarComboBoxAmbiente()
        {
            cboAmbiente.DataSource = Enum.GetValues(typeof(eTipoAmbiente));
        }
        private void Bind()
        {
            LimparComponentes();
            _parametroCollection = _parametroRepository.ObterLista().ToList();

            var itens = _parametroCollection.Select(i => new 
            {
                PK_Parametro = i.PK_Parametro,
                Ambiente = ((eTipoAmbiente)i.FK_Ambiente).ToString(),
                Descricao = i.Descricao,
                Conexao = i.StringConexao,
            }).ToList();
            
            dtgPrincipal.DataSource = itens;

            dtgPrincipal_CellClick(null, null);
        }
        private void ExibirBotoesCRUD(bool visualizar, eOperacao operacao)
        {
            _operacaoAtual = operacao;

            btnSave.Visible = !visualizar;
            btnCancel.Visible = !visualizar;

            btnAdd.Visible = visualizar;
            btnEdit.Visible = visualizar;
            btnDelete.Visible = visualizar;

            bool habilitarComponentes = false;
            if (!visualizar && _operacaoAtual != eOperacao.Deletar)
                habilitarComponentes = true;
            
            txtDescricao.Enabled = habilitarComponentes;
            txtString.Enabled = habilitarComponentes;
            cboAmbiente.Enabled = habilitarComponentes;
        }
        private void LimparComponentes()
        {
            txtDescricao.Text = "";
            txtString.Text = "";
            cboAmbiente.SelectedIndex = 0;
            _parametroSelecionado = null;
        }
        #endregion
    }
}
