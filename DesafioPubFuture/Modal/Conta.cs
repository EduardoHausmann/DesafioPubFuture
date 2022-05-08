using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modal
{
    [Table("contas")]
    public class Conta
    {
        [Key, Column("id")]
        public int Id { get; set; }

        [Column("saldo")]
        public double Saldo { get; set; }

        [Column("tipo_conta")]
        public string TipoConta { get; set; }

        [Column("instituicao_financeira")]
        public string InstituicaoFinanceira { get; set; }
    }
}
