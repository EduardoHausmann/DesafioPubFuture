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
    public partial class FrmHome : Form
    {
        private Form ativarForm = null;

        public FrmHome()
        {
            InitializeComponent();
        }

        private void AbrirTelaFilha(Form telaFilha)
        {
            if (ativarForm != null) ativarForm.Close();
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

        }

        private void btnReceitaLista_Click(object sender, EventArgs e)
        {

        }

        private void btnReceitaListaTotal_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Despesa
        private void btnDespesaCadastro_Click(object sender, EventArgs e)
        {

        }

        private void btnDespesaLista_Click(object sender, EventArgs e)
        {

        }

        private void btnDespesaListaTotal_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Conta
        private void btnContaCadastro_Click(object sender, EventArgs e)
        {

        }

        private void btnContaLista_Click(object sender, EventArgs e)
        {

        }

        private void btnContaListaSaldoTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnContaTransferiSaldo_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void lblMenu_Click(object sender, EventArgs e)
        {
            if (pnlMenuLateral.Visible == false)
            {
                pnlMenuLateral.Visible = true;
                lblMenu.Location = new System.Drawing.Point(256, 4); 
                this.lblTitulo.Location = new System.Drawing.Point(549, 14);
            }
            else
            {
                pnlMenuLateral.Visible = false;
                lblMenu.Location = new System.Drawing.Point(8, 4);
                this.lblTitulo.Location = new System.Drawing.Point(425, 14);
            }
        }
    }
}
