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
    public class DespesaRepository : IDespesa
    {
        SqlCommand cmd = Conexao.Conecta();
        public bool Alterar(Despesa despesa)
        {
            cmd.CommandText = @"UPDATE despesas SET valor = @VALOR, data_pagamento = @PAGAMENTO, data_pagamento_esperado = @PAGAMENTO_ESPERADO, tipo_despesa = @TIPO_DESPESA, id_conta = @CONTA  WHERE id = @ID";
            cmd.Parameters.AddWithValue("@ID", despesa.Id);
            cmd.Parameters.AddWithValue("@VALOR", despesa.Valor);
            cmd.Parameters.AddWithValue("@PAGAMENTO", despesa.DataPagamento);
            cmd.Parameters.AddWithValue("@PAGAMENTO_ESPERADO", despesa.DataPagamentoEsperado);
            cmd.Parameters.AddWithValue("@TIPO_DESPESA", despesa.TipoDespesa);
            cmd.Parameters.AddWithValue("@CONTA", despesa.IdConta);

            int qtdAfetada = Convert.ToInt32(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            return qtdAfetada == 1;
        }

        public bool Apagar(int id)
        {
            cmd.CommandText = @"DELETE FROM despesas WHERE id = @ID";
            cmd.Parameters.AddWithValue("@ID", id);

            int qtdAfetada = Convert.ToInt32(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            return qtdAfetada == 1;
        }

        public int Inserir(Despesa despesa)
        {
            cmd.CommandText = @"INSERT INTO despesas (valor, data_pagamento, data_pagamento_esperado, tipo_despesa, id_conta)  OUTPUT INSERTED.ID VALUES (@VALOR, @PAGAMENTO, @PAGAMENTO_ESPERADO, @TIPO_DESPESA, @CONTA)";
            cmd.Parameters.AddWithValue("@VALOR", despesa.Valor);
            cmd.Parameters.AddWithValue("@PAGAMENTO", despesa.DataPagamento);
            cmd.Parameters.AddWithValue("@PAGAMENTO_ESPERADO", despesa.DataPagamentoEsperado);
            cmd.Parameters.AddWithValue("@TIPO_DESPESA", despesa.TipoDespesa);
            cmd.Parameters.AddWithValue("@CONTA", despesa.IdConta);

            int id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
            return id;
        }

        public Despesa ObterPeloId(int id)
        {
            cmd.CommandText = @"SELECT despesas.id AS 'DespesaId',
            despesas.valor AS 'DespesaValor',
            despesas.data_pagamento AS 'DespesaPagamento',
            despesas.data_pagamento_esperado AS 'DespesaPagamentoEsperado',
            despesas.tipo_despesa AS 'DespesaTipo',
            despesas.id_conta AS 'DespesaIdConta',
            contas.instituicao_financeira as 'ContaFinanceira'
            FROM despesas 
            INNER JOIN contas ON (despesas.id_conta = contas.id)
            WHERE despesas.id = @Id";
            cmd.Parameters.AddWithValue("@ID", id);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            cmd.Connection.Close();
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            DataRow dr = dt.Rows[0];
            Despesa despesa = new Despesa();
            despesa.Id = Convert.ToInt32(dr["DespesaId"]);
            despesa.IdConta = Convert.ToInt32(dr["DespesaIdConta"]);
            despesa.Valor = Convert.ToDouble(dr["DespesaValor"]);
            despesa.TipoDespesa = dr["DespesaTipo"].ToString();
            despesa.DataPagamento = Convert.ToDateTime(dr["DespesaPagamento"]);
            despesa.DataPagamentoEsperado = Convert.ToDateTime(dr["DespesaPagamentoEsperado"]);
            despesa.Conta = new Conta();
            despesa.Conta.InstituicaoFinanceira = dr["ContaFinanceira"].ToString();
            return despesa;
        }

        public List<Despesa> ObterPeloPeriodo(DateTime inicio, DateTime fim)
        {
            cmd.CommandText = @"SELECT despesas.id AS 'DespesaId',
            despesas.valor AS 'DespesaValor',
            despesas.data_pagamento AS 'DespesaPagamento',
            despesas.data_pagamento_esperado AS 'DespesaPagamentoEsperado',
            despesas.tipo_despesa AS 'DespesaTipo',
            despesas.id_conta AS 'DespesaIdConta',
            contas.instituicao_financeira as 'ContaFinanceira'
            FROM despesas 
            INNER JOIN contas ON (despesas.id_conta = contas.id)
            WHERE despesas.data_pagamento BETWEEN @PAGAMENTO AND @PAGAMENTO_ESPERADO AND despesas.data_pagamento_esperado BETWEEN @PAGAMENTO AND @PAGAMENTO_ESPERADO";
            cmd.Parameters.AddWithValue("@PAGAMENTO", inicio);
            cmd.Parameters.AddWithValue("@PAGAMENTO_ESPERADO", fim);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            List<Despesa> despesas = new List<Despesa>();

            foreach (DataRow dr in dt.Rows)
            {
                Despesa despesa = new Despesa();
                despesa.Id = Convert.ToInt32(dr["DespesaId"]);
                despesa.IdConta = Convert.ToInt32(dr["DespesaIdConta"]);
                despesa.Valor = Convert.ToDouble(dr["DespesaValor"]);
                despesa.TipoDespesa = dr["DespesaTipo"].ToString();
                despesa.DataPagamento = Convert.ToDateTime(dr["DespesaPagamento"]);
                despesa.DataPagamentoEsperado = Convert.ToDateTime(dr["DespesaPagamentoEsperado"]);
                despesa.Conta = new Conta();
                despesa.Conta.InstituicaoFinanceira = dr["ContaFinanceira"].ToString();
                despesas.Add(despesa);
            }
            cmd.Connection.Close();
            return despesas;
        }

        public List<Despesa> ObterPeloTipo(string tipo)
        {
            cmd.CommandText = @"SELECT despesas.id AS 'DespesaId',
            despesas.valor AS 'DespesaValor',
            despesas.data_pagamento AS 'DespesaPagamento',
            despesas.data_pagamento_esperado AS 'DespesaPagamentoEsperado',
            despesas.tipo_despesa AS 'DespesaTipo',
            despesas.id_conta AS 'DespesaIdConta',
            contas.instituicao_financeira as 'ContaFinanceira'
            FROM despesas 
            INNER JOIN contas ON (despesas.id_conta = contas.id)
            WHERE despesas.tipo_despesa LIKE @TIPO";
            tipo = $"%{tipo}%";
            cmd.Parameters.AddWithValue("@TIPO", tipo);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            List<Despesa> despesas = new List<Despesa>();

            foreach (DataRow dr in dt.Rows)
            {
                Despesa despesa = new Despesa();
                despesa.Id = Convert.ToInt32(dr["DespesaId"]);
                despesa.IdConta = Convert.ToInt32(dr["DespesaIdConta"]);
                despesa.Valor = Convert.ToDouble(dr["DespesaValor"]);
                despesa.TipoDespesa = dr["DespesaTipo"].ToString();
                despesa.DataPagamento = Convert.ToDateTime(dr["DespesaPagamento"]);
                despesa.DataPagamentoEsperado = Convert.ToDateTime(dr["DespesaPagamentoEsperado"]);
                despesa.Conta = new Conta();
                despesa.Conta.InstituicaoFinanceira = dr["ContaFinanceira"].ToString();
                despesas.Add(despesa);
            }
            cmd.Connection.Close();
            return despesas;
        }

        public List<Despesa> ObterTodos()
        {
            cmd.CommandText = @"SELECT despesas.id AS 'DespesaId',
            despesas.valor AS 'DespesaValor',
            despesas.data_pagamento AS 'DespesaPagamento',
            despesas.data_pagamento_esperado AS 'DespesaPagamentoEsperado',
            despesas.tipo_despesa AS 'DespesaTipo',
            despesas.id_conta AS 'DespesaIdConta',
            contas.instituicao_financeira as 'ContaFinanceira'
            FROM despesas 
            INNER JOIN contas ON (despesas.id_conta = contas.id)";
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            List<Despesa> despesas = new List<Despesa>();

            foreach (DataRow dr in dt.Rows)
            {
                Despesa despesa = new Despesa();
                despesa.Id = Convert.ToInt32(dr["DespesaId"]);
                despesa.IdConta = Convert.ToInt32(dr["DespesaIdConta"]);
                despesa.Valor = Convert.ToDouble(dr["DespesaValor"]);
                despesa.TipoDespesa = dr["DespesaTipo"].ToString();
                despesa.DataPagamento = Convert.ToDateTime(dr["DespesaPagamento"]);
                despesa.DataPagamentoEsperado = Convert.ToDateTime(dr["DespesaPagamentoEsperado"]);
                despesa.Conta = new Conta();
                despesa.Conta.InstituicaoFinanceira = dr["ContaFinanceira"].ToString();
                despesas.Add(despesa);
            }
            cmd.Connection.Close();
            return despesas;
        }

        public List<Despesa> ObterTotalDespesa()
        {
            throw new NotImplementedException();
        }
    }
}
