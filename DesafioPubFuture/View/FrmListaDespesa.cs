using Modal;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace View
{
    public partial class FrmListaDespesa : Form
    {
        DespesaRepository repository;
        Despesa despesa;

        public FrmListaDespesa()
        {
            InitializeComponent();
            AtualizarTabela();
            VerificaFiltro();
            SugereData();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VerificaFiltro()
        {
            if (rbTipoDespesa.Checked)
            {
                dtpPagamento.Enabled = false;
                dtpPagamentoEsperado.Enabled = false;
                cbTipoDespesa.Enabled = true;
                SugereData();
            }
            else
            {
                dtpPagamento.Enabled = true;
                dtpPagamentoEsperado.Enabled = true;
                cbTipoDespesa.Enabled = false;
                if (Convert.ToString(cbTipoDespesa.SelectedItem) != "")
                    cbTipoDespesa.SelectedIndex = -1;
            }
        }

        private void SugereData()
        {
            dtpPagamento.Value = Convert.ToDateTime("01/01/" + DateTime.Now.Year);
            dtpPagamentoEsperado.Value = DateTime.Today;
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

        private void FiltroTipo()
        {
            despesa = new Despesa();
            despesa.Conta = new Conta();
            repository = new DespesaRepository();
            string tipo = Convert.ToString(cbTipoDespesa.SelectedItem);
            List<Despesa> despesas = repository.ObterPeloTipo(tipo);

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

        private void FiltroPeriodo()
        {
            despesa = new Despesa();
            despesa.Conta = new Conta();
            repository = new DespesaRepository();
            DateTime inicio = Convert.ToDateTime(dtpPagamento.Value.Date);
            DateTime fim = Convert.ToDateTime(dtpPagamentoEsperado.Value.Date);
            List<Despesa> despesas = repository.ObterPeloPeriodo(inicio, fim);

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

        private void rbTipoDespesa_CheckedChanged(object sender, EventArgs e)
        {
            VerificaFiltro();
        }

        private void rbPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            VerificaFiltro();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(cbTipoDespesa.SelectedItem) == "" && rbTipoDespesa.Checked)
            {
                AtualizarTabela();
            }

            if (rbTipoDespesa.Checked)
            {
                FiltroTipo();
                cbTipoDespesa.SelectedIndex = -1;
            }
            else
            {
                FiltroPeriodo();
                SugereData();
            }
        }
    }
}
