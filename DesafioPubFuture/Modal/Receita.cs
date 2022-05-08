using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modal
{
    [Table("receitas")]
    public class Receita
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Column("valor")]
        public double Valor { get; set; }

        [Column("descricao")]
        public string Descricao { get; set; }

        [Column("data_recebimento")]
        public DateTime DataRecebimento { get; set; }

        [Column("data_recebimento_esperado")]
        public DateTime DataRecebimentoEsperado { get; set; }

        [Column("tipo_receita")]
        public string TipoReceita { get; set; }

        [Column("id_conta")]
        public int IdConta { get; set; }

        [ForeignKey("IdConta")]
        public Conta Conta { get; set; }
    }
}
