using Modal;
using System;
using System.Collections.Generic;

namespace Repository.Interface
{
    public interface IDespesa
    {
        int Inserir(Despesa despesa);

        bool Alterar(Despesa despesa);

        bool Apagar(int id);

        Despesa ObterPeloId(int id);

        List<Despesa> ObterTodos();

        List<Despesa> ObterTotalDespesa();

        List<Despesa> ObterPeloTipo(string tipo);

        List<Despesa> ObterPeloPeriodo(DateTime inicio, DateTime fim);
    }
}
