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
    public partial class FrmTotalReceita : Form
    {
        ReceitaRepository repository;
        Receita receita;

        public FrmTotalReceita()
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

        private void CalculaTotal()
        {
            double valor = 0;
            receita = new Receita();
            repository = new ReceitaRepository();
            List<Receita> receitas = repository.ObterTotalReceita();

            for (int i = 0; i < receitas.Count; i++)
            {
                receita = receitas[i];
                valor = valor + receita.Valor;
            }

            lblValor.Text = Convert.ToString(valor);
        }
    }
}
