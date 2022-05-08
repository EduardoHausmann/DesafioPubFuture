using Modal;
using System;
using System.Collections.Generic;

namespace Repository.Interface
{
    public interface IReceita
    {
        int Inserir(Receita receita);

        bool Alterar(Receita receita);

        bool Apagar(int id);

        Receita ObterPeloId(int id);

        List<Receita> ObterTodos();

        List<Receita> ObterTotalReceita();

        List<Receita> ObterPeloTipo(string tipo);

        List<Receita> ObterPeloPeriodo(DateTime inicio, DateTime fim);
    }
}
