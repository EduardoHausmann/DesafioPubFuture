using Modal;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FrmCadastroConta : Form
    {
        Conta conta;
        ContaRepository repository;
        public FrmCadastroConta()
        {
            InitializeComponent();
            AtualizarTabela();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Limpar()
        {
            mbSaldo.Clear();
            lblId.Text = "0";
            txtInstituicao.Clear();
            cbTipoConta.SelectedIndex = -1;
        }

        private void Inserir() 
        {
            conta = new Conta();
            repository = new ContaRepository();
            conta.Saldo = Convert.ToDouble(mbSaldo.Text);
            conta.TipoConta = Convert.ToString(cbTipoConta.SelectedItem);
            conta.InstituicaoFinanceira = txtInstituicao.Text;

            repository.Inserir(conta);
        }

        private void Alterar() 
        {
            conta = new Conta();
            repository = new ContaRepository();
            conta.Id = Convert.ToInt32(lblId.Text);
            conta.Saldo = Convert.ToDouble(mbSaldo.Text);
            conta.TipoConta = Convert.ToString(cbTipoConta.SelectedItem);
            conta.InstituicaoFinanceira = txtInstituicao.Text;

            repository.Alterar(conta);
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string tipo = Convert.ToString(cbTipoConta.SelectedItem);
            if (mbSaldo.Text != "" && tipo != "" && txtInstituicao.Text != "")
            {
                Inserir();
                Limpar();
                AtualizarTabela();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string tipo = Convert.ToString(cbTipoConta.SelectedItem);
            if (mbSaldo.Text != "" && tipo != "" && txtInstituicao.Text != "")
            {
                Alterar();
                Limpar();
                AtualizarTabela();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
                Limpar();
            }

            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvConta.RowCount > 0)
            {
                if (MessageBox.Show("Deseja realmente Apagar?", "AVISO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvConta.CurrentRow.Cells[0].Value);
                    repository = new ContaRepository();
                    repository.Apagar(id);
                }
                btnSalvar.Enabled = true;
                btnEditar.Enabled = false;
            }
            Limpar();
            AtualizarTabela();
        }

        private void dgvConta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            conta = new Conta();
            repository = new ContaRepository();

            int id = Convert.ToInt32(dgvConta.CurrentRow.Cells[0].Value);
            conta = repository.ObterPeloId(id);
            if (lblId.Text != null)
            {
                lblId.Text = conta.Id.ToString();
                mbSaldo.Text = conta.Saldo.ToString();
                cbTipoConta.SelectedItem = conta.TipoConta;
                txtInstituicao.Text = conta.InstituicaoFinanceira;
            }
            btnSalvar.Enabled = false;
            btnEditar.Enabled = true;
        }
    }
}
