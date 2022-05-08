using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modal
{
    [Table("despesas")]
    public class Despesa
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Column("valor")]
        public double Valor { get; set; }

        [Column("data_pagamento")]
        public DateTime DataPagamento { get; set; }

        [Column("data_pagamento_esperado")]
        public DateTime DataPagamentoEsperado { get; set; }

        [Column("tipo_despesa")]
        public string TipoDespesa { get; set; }

        [Column("id_conta")]
        public int IdConta { get; set; }

        [ForeignKey("IdConta")]
        public Conta Conta { get; set; }
    }
}
