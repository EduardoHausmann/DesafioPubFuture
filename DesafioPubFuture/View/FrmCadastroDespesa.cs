using Modal;
using Repository;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace View
{
    public partial class FrmCadastroDespesa : Form
    {
        DespesaRepository repository;
        Despesa despesa;

        public FrmCadastroDespesa()
        {
            InitializeComponent();
            CarregaComboConta();
            AtualizarTabela();
            SugereData();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Limpar()
        {
            mbValor.Clear();
            lblId.Text = "0";
            cbTipoDespesa.SelectedIndex = -1;
            cbConta.SelectedIndex = 0;
            dtpPagamento.Value = DateTime.Now.Date;
            dtpPagamentoEsperado.Value = DateTime.Now.Date;
        }

        private void SugereData()
        {
            dtpPagamento.Value = Convert.ToDateTime("01/01/" + DateTime.Now.Year);
            dtpPagamentoEsperado.Value = DateTime.Today;
        }

        private void Inserir()
        {
            despesa = new Despesa();
            repository = new DespesaRepository();
            despesa.Valor = Convert.ToDouble(mbValor.Text.Replace(".", ","));
            despesa.TipoDespesa = Convert.ToString(cbTipoDespesa.SelectedItem);
            despesa.DataPagamento = Convert.ToDateTime(dtpPagamento.Value);
            despesa.DataPagamentoEsperado = Convert.ToDateTime(dtpPagamentoEsperado.Value);
            despesa.IdConta = Convert.ToInt32(cbConta.SelectedValue);

            repository.Inserir(despesa);
        }

        private void Alterar()
        {
            despesa = new Despesa();
            repository = new DespesaRepository();
            despesa.Id = Convert.ToInt32(lblId.Text);
            despesa.Valor = Convert.ToDouble(mbValor.Text.Replace(".", ","));
            despesa.TipoDespesa = Convert.ToString(cbTipoDespesa.SelectedItem);
            despesa.DataPagamento = Convert.ToDateTime(dtpPagamento.Value);
            despesa.DataPagamentoEsperado = Convert.ToDateTime(dtpPagamentoEsperado.Value);
            despesa.IdConta = Convert.ToInt32(cbConta.SelectedValue);

            repository.Alterar(despesa);
        }

        private void CarregaComboConta()
        {
            SqlCommand cmd = Conexao.Conecta();
            cmd.CommandText = "SELECT id, instituicao_financeira FROM contas";
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cbConta.DisplayMember = "instituicao_financeira";
            cbConta.ValueMember = "id";
            cbConta.DataSource = dt;
            cmd.Connection.Close();
        }

        private void AtualizarTabela()
        {
            despesa = new Despesa();
            despesa.Conta = new Conta();
            repository = new DespesaRepository();
            List<Despesa> despesas = repository.ObterTodos();

            dgvDespesa.RowCount = 0;
            for (int i = 0; i < despesas.Count; i++)
            {
                despesa = despesas[i];
                dgvDespesa.Rows.Add(new object[]
                {
                    despesa.Id, despesa.Conta.InstituicaoFinanceira, despesa.Valor, despesa.TipoDespesa.ToString(), despesa.DataPagamento, despesa.DataPagamentoEsperado
                });
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string tipo = Convert.ToString(cbTipoDespesa.SelectedItem);
            if (mbValor.Text != "" && tipo != "")
            {
                Inserir();
                Limpar();
                AtualizarTabela();
                SugereData();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string tipo = Convert.ToString(cbTipoDespesa.SelectedItem);
            if (mbValor.Text != "" && tipo != "")
            {
                Alterar();
                Limpar();
                AtualizarTabela();
                SugereData();

                btnSalvar.Enabled = true;
                btnEditar.Enabled = false;
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvDespesa.RowCount > 0)
            {
                if (MessageBox.Show("Deseja realmente Apagar?", "AVISO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvDespesa.CurrentRow.Cells[0].Value);
                    repository = new DespesaRepository();
                    repository.Apagar(id);
                }
                btnSalvar.Enabled = true;
                btnEditar.Enabled = false;
            }
            Limpar();
            AtualizarTabela();
            SugereData();
        }

        private void dgvDespesa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            despesa = new Despesa();
            repository = new DespesaRepository();

            int id = Convert.ToInt32(dgvDespesa.CurrentRow.Cells[0].Value);
            despesa = repository.ObterPeloId(id);
            if (lblId.Text != null)
            {
                lblId.Text = despesa.Id.ToString();
                mbValor.Text = despesa.Valor.ToString();
                cbTipoDespesa.SelectedItem = despesa.TipoDespesa;
                dtpPagamento.Value = Convert.ToDateTime(despesa.DataPagamento);
                dtpPagamentoEsperado.Value = Convert.ToDateTime(despesa.DataPagamentoEsperado);
                cbConta.SelectedValue = despesa.IdConta.ToString();
            }
            btnSalvar.Enabled = false;
            btnEditar.Enabled = true;
        }
    }
}
