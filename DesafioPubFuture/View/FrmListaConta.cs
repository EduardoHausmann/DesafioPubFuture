using Modal;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace View
{
    public partial class FrmListaConta : Form
    {
        Conta conta;
        ContaRepository repository;
        public FrmListaConta()
        {
            InitializeComponent();
            AtualizarTabela();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AtualizarTabela()
        {
            conta = new Conta();
            repository = new ContaRepository();
            List<Conta> contas = repository.ObterTodos();

            dgvConta.RowCount = 0;
            for (int i = 0; i < contas.Count; i++)
            {
                conta = contas[i];
                dgvConta.Rows.Add(new object[]
                {
                    conta.Id, conta.Saldo, conta.TipoConta.ToString(), conta.InstituicaoFinanceira.ToString()
                });
            }
        }
    }
}
