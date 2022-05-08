using Modal;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace View
{
    public partial class FrmTotalDespesa : Form
    {
        DespesaRepository repository;
        Despesa despesa;

        public FrmTotalDespesa()
        {
            InitializeComponent();
            AtualizarTabela();
            CalculaTotal();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void CalculaTotal()
        {
            double valor = 0;
            despesa = new Despesa();
            repository = new DespesaRepository();
            List<Despesa> despesas = repository.ObterTotalDespesa();

            for (int i = 0; i < despesas.Count; i++)
            {
                despesa = despesas[i];
                valor = valor + despesa.Valor;
            }

            lblValor.Text = Convert.ToString(valor);
        }
    }
}
