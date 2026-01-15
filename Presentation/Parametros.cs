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
        private ParametroRepository _parametroRepository;
        private IEnumerable<Parametro> _parametroCollection;
        private eOperacao _operacaoAtual = eOperacao.Nenhuma;
        private Parametro _parametroSelecionado = null;
        
        public Parametros()
        {
            InitializeComponent();
            _parametroRepository = new ParametroRepository(new InfraData.Context.DbSession());
        }
        private void Parametros_Load(object sender, EventArgs e)
        {
            CarregarComboBoxAmbiente();
            ExibirBotoesCRUD(true);
            Bind();
        }

        private void CarregarComboBoxAmbiente()
        {
            cboAmbiente.DataSource = Enum.GetValues(typeof(eTipoAmbiente));
        }

        private void Bind()
        {
            _parametroCollection = _parametroRepository.ObterTodos();

            if (dtgPrincipal.Rows.Count > 0)
                dtgPrincipal.Rows.Clear();
    
            dtgPrincipal.DataSource = _parametroCollection;
        }
        private void ExibirBotoesCRUD(bool visualizar)
        {
            btnSave.Visible = !visualizar;
            btnCancel.Visible = !visualizar;

            btnAdd.Visible = visualizar;
            btnEdit.Visible = visualizar;
            btnDelete.Visible = visualizar;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ExibirBotoesCRUD(false);
            _parametroSelecionado = null;
            _operacaoAtual = eOperacao.Adicionar;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dtgPrincipal.Rows.Count <= 0)
                return;

            if (dtgPrincipal.SelectedRows.Count <= 0)
                return;

            ExibirBotoesCRUD(false);
            _operacaoAtual = eOperacao.Alterar;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ExibirBotoesCRUD(false);
            _operacaoAtual = eOperacao.Deletar;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ExibirBotoesCRUD(true);

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
                    _parametroRepository.Excluir(_parametroSelecionado.PK_Parametro);
                    break;
                default:
                    break;
            }

            _operacaoAtual = eOperacao.Nenhuma;

            Bind();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ExibirBotoesCRUD(true);
        }

        private void dtgPrincipal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgPrincipal.Rows.Count <= 0)
                return;

            _parametroSelecionado = (Parametro)dtgPrincipal.SelectedRows[0].DataBoundItem;

            txtDescricao.Text = _parametroSelecionado.Descricao;
            txtString.Text = _parametroSelecionado.StringConexao;
            cboAmbiente.SelectedItem = (eTipoAmbiente)_parametroSelecionado.FK_Ambiente;
        }
    }
}
