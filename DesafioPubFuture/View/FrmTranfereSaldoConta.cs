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
    public partial class FrmTranfereSaldoConta : Form
    {
        Conta contaOrigem;
        Conta contaDestino;
        ContaRepository repository;
        public FrmTranfereSaldoConta()
        {
            InitializeComponent();
            CarregaComboContaOrigem();
            CarregaComboContaDestino();
        }

        private void Limpa()
        {
            int idOrigem = Convert.ToInt32(cbContaOrigem.SelectedValue);
            int idDestino = Convert.ToInt32(cbContaDestino.SelectedValue);
            mbValor.Text = "0";
            CarregaCampoSaldoOrigem(idOrigem);
            CarregaCampoSaldoDestino(idDestino);
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            repository = new ContaRepository();
            int idOrigem = Convert.ToInt32(cbContaOrigem.SelectedValue);
            int idDestino = Convert.ToInt32(cbContaDestino.SelectedValue);
            double origem = Convert.ToDouble(mbSaldoOrigem.Text.Replace(".", ","));
            double destino = Convert.ToDouble(mbSaldoDestino.Text.Replace(".", ","));
            double valor = Convert.ToDouble(mbValor.Text);

            if (valor > 0)
                if ((valor < origem) && (idDestino != idOrigem))
                {
                    origem -= Convert.ToDouble(mbValor.Text.Replace(".", ","));
                    destino += Convert.ToDouble(mbValor.Text.Replace(".", ","));

                    repository.TransferirSaldo(idOrigem, idDestino, origem, destino);
                    Limpa();
                }
        }

        private void CarregaComboContaOrigem()
        {
            SqlCommand cmd = Conexao.Conecta();
            cmd.CommandText = "SELECT id, instituicao_financeira FROM contas";
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cbContaOrigem.DisplayMember = "instituicao_financeira";
            cbContaOrigem.ValueMember = "id";
            cbContaOrigem.DataSource = dt;
            cmd.Connection.Close();
        }

        private void CarregaComboContaDestino()
        {
            SqlCommand cmd = Conexao.Conecta();
            cmd.CommandText = "SELECT id, instituicao_financeira FROM contas";
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            cbContaDestino.DisplayMember = "instituicao_financeira";
            cbContaDestino.ValueMember = "id";
            cbContaDestino.DataSource = dt;
            cmd.Connection.Close();
        }

        private void CarregaCampoSaldoOrigem(int idOrigem)
        {
            contaOrigem = new Conta();
            SqlCommand cmd = Conexao.Conecta();
            cmd.CommandText = "SELECT saldo FROM contas WHERE id = @ID";
            cmd.Parameters.AddWithValue("@ID", idOrigem);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            cmd.Connection.Close();
            if (dt.Rows.Count == 0)
            {
                return;
            }

            DataRow dr = dt.Rows[0];
            contaOrigem.Saldo = Convert.ToDouble(dr["saldo"]);
            mbSaldoOrigem.Text = contaOrigem.Saldo.ToString();
        }

        private void CarregaCampoSaldoDestino(int idDestino)
        {
            contaDestino = new Conta();
            SqlCommand cmd = Conexao.Conecta();
            cmd.CommandText = "SELECT saldo FROM contas WHERE id = @ID";
            cmd.Parameters.AddWithValue("@ID", idDestino);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            cmd.Connection.Close();
            if (dt.Rows.Count == 0)
            {
                return;
            }

            DataRow dr = dt.Rows[0];
            contaDestino.Saldo = Convert.ToDouble(dr["saldo"]);
            mbSaldoDestino.Text = contaDestino.Saldo.ToString();
        }

        private void cbContaOrigem_SelectedValueChanged(object sender, EventArgs e)
        {
            int idOrigem = Convert.ToInt32(cbContaOrigem.SelectedValue);
            CarregaCampoSaldoOrigem(idOrigem);
        }

        private void cbContaDestino_SelectedValueChanged(object sender, EventArgs e)
        {
            int idDestino = Convert.ToInt32(cbContaDestino.SelectedValue);
            CarregaCampoSaldoDestino(idDestino);
        }
    }
}
