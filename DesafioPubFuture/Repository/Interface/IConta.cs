using Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IConta
    {
        int Inserir(Conta conta);

        bool Alterar(Conta conta);

        void TransferirSaldo(int idOrigem, int idDestino, double saldoOrigem, double saldoDestino);

        bool Apagar(int id);

        Conta ObterPeloId(int id);

        List<Conta> ObterTodos();

        List<Conta> ObterSaldoTotal();
    }
}
