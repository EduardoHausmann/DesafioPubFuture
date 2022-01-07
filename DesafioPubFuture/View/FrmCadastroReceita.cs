using Modal;
using Repository;
using Repository.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FrmCadastroReceita : Form
    {
        ReceitaRepository repository;
        Receita receita;

        public FrmCadastroReceita()
        {
            InitializeComponent();
            CarregaComboConta();
            AtualizarTabela();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Limpar()
        {
            mbValor.Clear();
            lblId.Text = "0";
            txtDescricao.Clear();
            cbTipoReceita.SelectedIndex = -1;
            cbConta.SelectedIndex = -1;
            dtpRecebimento.Value = DateTime.Now.Date;
            dtpRecebimentoEsperado.Value = DateTime.Now.Date;
        }

        private void Inserir()
        {
            receita = new Receita();
            repository = new ReceitaRepository();
            receita.Valor = Convert.ToDouble(mbValor.Text);
            receita.TipoReceita = Convert.ToString(cbTipoReceita.SelectedItem);
            receita.Descricao = mbValor.Text;
            receita.DataRecebimento = Convert.ToDateTime(dtpRecebimento.Value);
            receita.DataRecebimentoEsperado = Convert.ToDateTime(dtpRecebimentoEsperado.Value);
            receita.IdConta = Convert.ToInt32(cbConta.SelectedValue);

            repository.Inserir(receita);
        }

        private void Alterar()
        {
            receita = new Receita();
            repository = new ReceitaRepository();
            receita.Id = Convert.ToInt32(lblId.Text);
            receita.Valor = Convert.ToDouble(mbValor.Text);
            receita.TipoReceita = Convert.ToString(cbTipoReceita.SelectedItem);
            receita.Descricao = mbValor.Text;
            receita.DataRecebimento = Convert.ToDateTime(dtpRecebimento.Value);
            receita.DataRecebimentoEsperado = Convert.ToDateTime(dtpRecebimentoEsperado.Value);
            receita.IdConta = Convert.ToInt32(cbConta.SelectedValue);

            repository.Alterar(receita);
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
            receita = new Receita();
            receita.Conta = new Conta();
            repository = new ReceitaRepository();
            List<Receita> receitas = repository.ObterTodos();

            dgvReceita.RowCount = 0;
            for (int i = 0; i < receitas.Count; i++)
            {
                receita = receitas[i];
                dgvReceita.Rows.Add(new object[]
                {
                    receita.Id, receita.Conta.InstituicaoFinanceira, receita.Valor, receita.Descricao.ToString(), receita.TipoReceita.ToString(), receita.DataRecebimento, receita.DataRecebimentoEsperado
                });
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string tipo = Convert.ToString(cbTipoReceita.SelectedItem);
            if (mbValor.Text != "" && tipo != "" && txtDescricao.Text != "")
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
            string tipo = Convert.ToString(cbTipoReceita.SelectedItem);
            string conta = Convert.ToString(cbTipoReceita.SelectedItem);
            if (mbValor.Text != "" && tipo != "" && txtDescricao.Text != "" && conta != "")
            {
                Alterar();
                Limpar();
                AtualizarTabela();
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvReceita.RowCount > 0)
            {
                if (MessageBox.Show("Deseja realmente Apagar?", "AVISO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvReceita.CurrentRow.Cells[0].Value);
                    repository = new ReceitaRepository();
                    repository.Apagar(id);
                }
            }
            Limpar();
            AtualizarTabela();
        }

        private void dgvReceita_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            receita = new Receita();
            repository = new ReceitaRepository();

            int id = Convert.ToInt32(dgvReceita.CurrentRow.Cells[0].Value);
            receita = repository.ObterPeloId(id);
            if (lblId.Text != null)
            {
                lblId.Text = receita.Id.ToString();
                mbValor.Text = receita.Valor.ToString();
                cbTipoReceita.SelectedItem = receita.TipoReceita;
                txtDescricao.Text = receita.Descricao;
                dtpRecebimento.Value = Convert.ToDateTime(receita.DataRecebimento);
                dtpRecebimentoEsperado.Value = Convert.ToDateTime(receita.DataRecebimentoEsperado);
                cbConta.SelectedValue = receita.IdConta.ToString();
            }
            btnSalvar.Enabled = false;
            btnEditar.Enabled = true;

        }
    }
}
