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
            VerificaFiltro();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VerificaFiltro()
        {
            if(rbTipoReceita.Checked)
            {
                dtpRecebimento.Enabled = false;
                dtpRecebimentoEsperado.Enabled = false;
                cbTipoReceita.Enabled = true;
            }
            else
            {                
                dtpRecebimento.Enabled = true;
                dtpRecebimentoEsperado.Enabled = true;
                cbTipoReceita.Enabled = false;
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
            if (rbTipoReceita.Checked)
                FiltroTipo();
            else
                FiltroPeriodo();
        }
    }
}
