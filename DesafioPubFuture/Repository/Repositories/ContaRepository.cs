using Modal;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class ContaRepository : IConta
    {
        SqlCommand cmd = Conexao.Conecta();
        public bool Alterar(Conta conta)
        {
            cmd.CommandText = @"UPDATE contas SET saldo = @SALDO, tipo_conta = @TIPO_CONTA, instituicao_financeira = @INSTITUICAO WHERE id = @ID";
            cmd.Parameters.AddWithValue("@ID", conta.Id);
            cmd.Parameters.AddWithValue("@SALDO", conta.Saldo);
            cmd.Parameters.AddWithValue("@TIPO_CONTA", conta.TipoConta);
            cmd.Parameters.AddWithValue("@INSTITUICAO", conta.InstituicaoFinanceira);

            int qtdAfetada = Convert.ToInt32(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            return qtdAfetada == 1;
        }

        public bool Apagar(int id)
        {
            cmd.CommandText = @"DELETE FROM contas WHERE id = @ID";
            cmd.Parameters.AddWithValue("@ID", id);

            int qtdAfetada = Convert.ToInt32(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            return qtdAfetada == 1;
        }

        public int Inserir(Conta conta)
        {
            cmd.CommandText = @"INSERT INTO contas (saldo, tipo_conta, instituicao_financeira) OUTPUT INSERTED.ID VALUES(@SALDO, @TIPO_CONTA, @INSTITUICAO)";
            cmd.Parameters.AddWithValue("@SALDO", conta.Saldo);
            cmd.Parameters.AddWithValue("@TIPO_CONTA", conta.TipoConta);
            cmd.Parameters.AddWithValue("@INSTITUICAO", conta.InstituicaoFinanceira);

            int id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
            return id;
        }

        public Conta ObterPeloId(int id)
        {
            cmd.CommandText = @"SELECT * FROM contas WHERE id = @Id";
            cmd.Parameters.AddWithValue("@ID", id);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            cmd.Connection.Close();
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            DataRow dr = dt.Rows[0];
            Conta conta = new Conta();
            conta.Id = Convert.ToInt32(dr["id"]);
            conta.Saldo = Convert.ToDouble(dr["saldo"]);
            conta.TipoConta = dr["tipo_conta"].ToString();
            conta.InstituicaoFinanceira = dr["instituicao_financeira"].ToString();
            return conta;
        }

        public List<Conta> ObterSaldoTotal()
        {
            throw new NotImplementedException();
        }

        public List<Conta> ObterTodos()
        {
            cmd.CommandText = @"SELECT * FROM contas";
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            List<Conta> contas = new List<Conta>();

            foreach (DataRow dr in dt.Rows)
            {
                Conta conta = new Conta();
                conta.Id = Convert.ToInt32(dr["id"]);
                conta.Saldo = Convert.ToDouble(dr["saldo"]);
                conta.TipoConta = dr["tipo_conta"].ToString();
                conta.InstituicaoFinanceira = dr["instituicao_financeira"].ToString();
                contas.Add(conta);
            }
            cmd.Connection.Close();
            return contas;
        }

        public bool TransferirSaldo(Conta contaOrigem, Conta contaDestino)
        {
            throw new NotImplementedException();
        }
    }
}
