using Modal;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Repository.Repositories
{
    public class ReceitaRepository : IReceita
    {
        SqlCommand cmd = Conexao.Conecta();
        public bool Alterar(Receita receita)
        {
            cmd.CommandText = @"UPDATE receitas SET valor = @VALOR, descricao = @DESCRICAO, data_recebimento = @RECEBIMENTO, data_recebimento_esperado = @RECEBIMENTO_ESPERADO, tipo_receita = @TIPO_RECEITA, id_conta = @CONTA  WHERE id = @ID";
            cmd.Parameters.AddWithValue("@ID", receita.Id);
            cmd.Parameters.AddWithValue("@VALOR", receita.Valor);
            cmd.Parameters.AddWithValue("@DESCRICAO", receita.Descricao);
            cmd.Parameters.AddWithValue("@RECEBIMENTO", receita.DataRecebimento);
            cmd.Parameters.AddWithValue("@RECEBIMENTO_ESPERADO", receita.DataRecebimentoEsperado);
            cmd.Parameters.AddWithValue("@TIPO_RECEITA", receita.TipoReceita);
            cmd.Parameters.AddWithValue("@CONTA", receita.IdConta);

            int qtdAfetada = Convert.ToInt32(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            return qtdAfetada == 1;
        }

        public bool Apagar(int id)
        {
            cmd.CommandText = @"DELETE FROM receitas WHERE id = @ID";
            cmd.Parameters.AddWithValue("@ID", id);

            int qtdAfetada = Convert.ToInt32(cmd.ExecuteNonQuery());
            cmd.Connection.Close();
            return qtdAfetada == 1;
        }

        public int Inserir(Receita receita)
        {
            cmd.CommandText = @"INSERT INTO receitas (valor, descricao, data_recebimento, data_recebimento_esperado, tipo_receita, id_conta)  OUTPUT INSERTED.ID VALUES (@VALOR, @DESCRICAO, @RECEBIMENTO, @RECEBIMENTO_ESPERADO, @TIPO_RECEITA, @CONTA)";
            cmd.Parameters.AddWithValue("@VALOR", receita.Valor);
            cmd.Parameters.AddWithValue("@DESCRICAO", receita.Descricao);
            cmd.Parameters.AddWithValue("@RECEBIMENTO", receita.DataRecebimento);
            cmd.Parameters.AddWithValue("@RECEBIMENTO_ESPERADO", receita.DataRecebimentoEsperado);
            cmd.Parameters.AddWithValue("@TIPO_RECEITA", receita.TipoReceita);
            cmd.Parameters.AddWithValue("@CONTA", receita.IdConta);

            int id = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection.Close();
            return id;
        }

        public Receita ObterPeloId(int id)
        {
            cmd.CommandText = @"SELECT receitas.id AS 'ReceitaId',
            receitas.valor AS 'ReceitaValor',
            receitas.descricao AS 'ReceitaDescricao',
            receitas.data_recebimento AS 'ReceitaRecebimento',
            receitas.data_recebimento_esperado AS 'ReceitaRecebimentoEsperado',
            receitas.tipo_receita AS 'ReceitaTipo',
            receitas.id_conta AS 'ReceitaIdConta',
            contas.instituicao_financeira as 'ContaFinanceira'
            FROM receitas 
            INNER JOIN contas ON (receitas.id_conta = contas.id)
            WHERE receitas.id = @Id";
            cmd.Parameters.AddWithValue("@ID", id);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            cmd.Connection.Close();
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            DataRow dr = dt.Rows[0];
            Receita receita = new Receita();
            receita.Id = Convert.ToInt32(dr["ReceitaId"]);
            receita.IdConta = Convert.ToInt32(dr["ReceitaIdConta"]);
            receita.Valor = Convert.ToDouble(dr["ReceitaValor"]);
            receita.Descricao = dr["ReceitaDescricao"].ToString();
            receita.TipoReceita = dr["ReceitaTipo"].ToString();
            receita.DataRecebimento = Convert.ToDateTime(dr["ReceitaRecebimento"]);
            receita.DataRecebimentoEsperado = Convert.ToDateTime(dr["ReceitaRecebimentoEsperado"]);
            receita.Conta = new Conta();
            receita.Conta.InstituicaoFinanceira = dr["ContaFinanceira"].ToString();
            return receita;
        }

        public List<Receita> ObterPeloPeriodo(DateTime inicio, DateTime fim)
        {
            cmd.CommandText = @"SELECT receitas.id AS 'ReceitaId',
            receitas.valor AS 'ReceitaValor',
            receitas.descricao AS 'ReceitaDescricao',
            receitas.data_recebimento AS 'ReceitaRecebimento',
            receitas.data_recebimento_esperado AS 'ReceitaRecebimentoEsperado',
            receitas.tipo_receita AS 'ReceitaTipo',
            receitas.id_conta AS 'ReceitaIdConta',
            contas.instituicao_financeira as 'ContaFinanceira'
            FROM receitas 
            INNER JOIN contas ON (receitas.id_conta = contas.id)
            WHERE receitas.data_recebimento BETWEEN @RECEBIMENTO AND @RECEBIMENTO_ESPERADO AND receitas.data_recebimento_esperado BETWEEN @RECEBIMENTO AND @RECEBIMENTO_ESPERADO";
            cmd.Parameters.AddWithValue("@RECEBIMENTO", inicio);
            cmd.Parameters.AddWithValue("@RECEBIMENTO_ESPERADO", fim);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            List<Receita> receitas = new List<Receita>();

            foreach (DataRow dr in dt.Rows)
            {
                Receita receita = new Receita();
                receita.Id = Convert.ToInt32(dr["ReceitaId"]);
                receita.Valor = Convert.ToDouble(dr["ReceitaValor"]);
                receita.Descricao = dr["ReceitaDescricao"].ToString();
                receita.TipoReceita = dr["ReceitaTipo"].ToString();
                receita.DataRecebimento = Convert.ToDateTime(dr["ReceitaRecebimento"]);
                receita.DataRecebimentoEsperado = Convert.ToDateTime(dr["ReceitaRecebimentoEsperado"]);
                receita.Conta = new Conta();
                receita.Conta.InstituicaoFinanceira = dr["ContaFinanceira"].ToString();
                receitas.Add(receita);
            }
            cmd.Connection.Close();
            return receitas;
        }

        public List<Receita> ObterPeloTipo(string tipo)
        {
            cmd.CommandText = @"SELECT receitas.id AS 'ReceitaId',
            receitas.valor AS 'ReceitaValor',
            receitas.descricao AS 'ReceitaDescricao',
            receitas.data_recebimento AS 'ReceitaRecebimento',
            receitas.data_recebimento_esperado AS 'ReceitaRecebimentoEsperado',
            receitas.tipo_receita AS 'ReceitaTipo',
            receitas.id_conta AS 'ReceitaIdConta',
            contas.instituicao_financeira as 'ContaFinanceira'
            FROM receitas 
            INNER JOIN contas ON (receitas.id_conta = contas.id)
            WHERE receitas.tipo_receita LIKE @TIPO";
            tipo = $"%{tipo}%";
            cmd.Parameters.AddWithValue("@TIPO", tipo);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            List<Receita> receitas = new List<Receita>();

            foreach (DataRow dr in dt.Rows)
            {
                Receita receita = new Receita();
                receita.Id = Convert.ToInt32(dr["ReceitaId"]);
                receita.Valor = Convert.ToDouble(dr["ReceitaValor"]);
                receita.Descricao = dr["ReceitaDescricao"].ToString();
                receita.TipoReceita = dr["ReceitaTipo"].ToString();
                receita.DataRecebimento = Convert.ToDateTime(dr["ReceitaRecebimento"]);
                receita.DataRecebimentoEsperado = Convert.ToDateTime(dr["ReceitaRecebimentoEsperado"]);
                receita.Conta = new Conta();
                receita.Conta.InstituicaoFinanceira = dr["ContaFinanceira"].ToString();
                receitas.Add(receita);
            }
            cmd.Connection.Close();
            return receitas;
        }

        public List<Receita> ObterTodos()
        {
            cmd.CommandText = @"SELECT receitas.id AS 'ReceitaId',
            receitas.valor AS 'ReceitaValor',
            receitas.descricao AS 'ReceitaDescricao',
            receitas.data_recebimento AS 'ReceitaRecebimento',
            receitas.data_recebimento_esperado AS 'ReceitaRecebimentoEsperado',
            receitas.tipo_receita AS 'ReceitaTipo',
            receitas.id_conta AS 'ReceitaIdConta',
            contas.instituicao_financeira as 'ContaFinanceira'
            FROM receitas 
            INNER JOIN contas ON (receitas.id_conta = contas.id)";
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            List<Receita> receitas = new List<Receita>();

            foreach (DataRow dr in dt.Rows)
            {
                Receita receita = new Receita();
                receita.Id = Convert.ToInt32(dr["ReceitaId"]);
                receita.Valor = Convert.ToDouble(dr["ReceitaValor"]);
                receita.Descricao = dr["ReceitaDescricao"].ToString();
                receita.TipoReceita = dr["ReceitaTipo"].ToString();
                receita.DataRecebimento = Convert.ToDateTime(dr["ReceitaRecebimento"]);
                receita.DataRecebimentoEsperado = Convert.ToDateTime(dr["ReceitaRecebimentoEsperado"]);
                receita.Conta = new Conta();
                receita.Conta.InstituicaoFinanceira = dr["ContaFinanceira"].ToString();
                receitas.Add(receita);
            }
            cmd.Connection.Close();
            return receitas;
        }

        public List<Receita> ObterTotalReceita()
        {
            cmd.CommandText = @"SELECT SUM(valor) AS 'Total' FROM receitas";
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            List<Receita> receitas = new List<Receita>();

            foreach (DataRow dr in dt.Rows)
            {
                Receita receita = new Receita();
                receita.Valor += Convert.ToDouble(dr["Total"]);
                receitas.Add(receita);
            }
            cmd.Connection.Close();
            return receitas;
        }
    }
}
