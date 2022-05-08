using System;
using System.Windows.Forms;

namespace View
{
    public partial class FrmHome : Form
    {
        private Form ativarForm = null;

        public FrmHome()
        {
            InitializeComponent();
        }

        private void AbrirTelaFilha(Form telaFilha)
        {
            if (ativarForm != null)
                ativarForm.Close();
            ativarForm = telaFilha;
            telaFilha.TopLevel = false;
            telaFilha.FormBorderStyle = FormBorderStyle.None;
            telaFilha.Dock = DockStyle.Fill;
            pnlTelaFilha.Controls.Add(telaFilha);
            pnlTelaFilha.Tag = telaFilha;
            telaFilha.BringToFront();
            telaFilha.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Receita
        private void btnReceitaCadastro_Click(object sender, EventArgs e)
        {
            //lblTitulo.Text = "Cadastro de Receitas";
            FrmCadastroReceita cadastroReceita = new FrmCadastroReceita();
            AbrirTelaFilha(cadastroReceita);
        }

        private void btnReceitaLista_Click(object sender, EventArgs e)
        {
            //lblTitulo.Text = "Lista de Receitas";
            FrmListaReceita listaReceita = new FrmListaReceita();
            AbrirTelaFilha(listaReceita);
        }

        private void btnReceitaListaTotal_Click(object sender, EventArgs e)
        {
            //lblTitulo.Text = "Total de Receitas";
            FrmTotalReceita totalReceita = new FrmTotalReceita();
            AbrirTelaFilha(totalReceita);
        }
        #endregion

        #region Despesa
        private void btnDespesaCadastro_Click(object sender, EventArgs e)
        {
            //lblTitulo.Text = "Cadastro de Despesas";
            FrmCadastroDespesa cadastroDespesa = new FrmCadastroDespesa();
            AbrirTelaFilha(cadastroDespesa);
        }

        private void btnDespesaLista_Click(object sender, EventArgs e)
        {
            //lblTitulo.Text = "Lista de Despesas";
            FrmListaDespesa listaDespesa = new FrmListaDespesa();
            AbrirTelaFilha(listaDespesa);
        }

        private void btnDespesaListaTotal_Click(object sender, EventArgs e)
        {
            //lblTitulo.Text = "Total de Despesas"; 
            FrmTotalDespesa totalDespesa = new FrmTotalDespesa();
            AbrirTelaFilha(totalDespesa);
        }
        #endregion

        #region Conta
        private void btnContaCadastro_Click(object sender, EventArgs e)
        {
            //lblTitulo.Text = "Cadastro de Contas";
            FrmCadastroConta cadastroConta = new FrmCadastroConta();
            AbrirTelaFilha(cadastroConta);
        }

        private void btnContaLista_Click(object sender, EventArgs e)
        {
            //lblTitulo.Text = "Lista de Contas";
            FrmListaConta listaConta = new FrmListaConta();
            AbrirTelaFilha(listaConta);
        }

        private void btnContaListaSaldoTotal_Click(object sender, EventArgs e)
        {
            //lblTitulo.Text = "Saldo Total das Contas";
            FrmSaldoTotalConta saldoTotalConta = new FrmSaldoTotalConta();
            AbrirTelaFilha(saldoTotalConta);
        }

        private void btnContaTransferiSaldo_Click(object sender, EventArgs e)
        {
            //lblTitulo.Text = "Transferencia de Saldo entre Contas";
            FrmTranfereSaldoConta tranfereSaldoConta = new FrmTranfereSaldoConta();
            tranfereSaldoConta.ShowDialog();
        }
        #endregion
    }
}
