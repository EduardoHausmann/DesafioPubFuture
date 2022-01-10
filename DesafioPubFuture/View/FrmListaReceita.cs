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
    public partial class FrmListaReceita : Form
    {
        ReceitaRepository repository;
        Receita receita;

        public FrmListaReceita()
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
            if (rbTipoReceita.Checked)
            {
                dtpRecebimento.Enabled = false;
                dtpRecebimentoEsperado.Enabled = false;
                cbTipoReceita.Enabled = true;
                SugereData();
            }
            else
            {
                dtpRecebimento.Enabled = true;
                dtpRecebimentoEsperado.Enabled = true;
                cbTipoReceita.Enabled = false;
                if (Convert.ToString(cbTipoReceita.SelectedItem) != "")
                    cbTipoReceita.SelectedIndex = -1;
            }
        }

        private void SugereData()
        {
            dtpRecebimento.Value = Convert.ToDateTime("01/01/" + DateTime.Now.Year);
            dtpRecebimentoEsperado.Value = DateTime.Today;
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

        private void FiltroTipo()
        {
            receita = new Receita();
            receita.Conta = new Conta();
            repository = new ReceitaRepository();
            string tipo = Convert.ToString(cbTipoReceita.SelectedItem);
            List<Receita> receitas = repository.ObterPeloTipo(tipo);

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

        private void FiltroPeriodo()
        {
            receita = new Receita();
            receita.Conta = new Conta();
            repository = new ReceitaRepository();
            DateTime inicio = Convert.ToDateTime(dtpRecebimento.Value.Date);
            DateTime fim = Convert.ToDateTime(dtpRecebimentoEsperado.Value.Date);
            List<Receita> receitas = repository.ObterPeloPeriodo(inicio, fim);

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

        private void rbTipoReceita_CheckedChanged(object sender, EventArgs e)
        {
            VerificaFiltro();
        }

        private void rbPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            VerificaFiltro();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(cbTipoReceita.SelectedItem) == "" && rbTipoReceita.Checked)
            {
                MessageBox.Show("Selecione o Tipo de Receita a ser Filtrado!");
                cbTipoReceita.Focus();
                return;
            }

            if (rbTipoReceita.Checked)
                FiltroTipo();
            else
            {
                FiltroPeriodo();
                SugereData();
            }
        }
    }
}
