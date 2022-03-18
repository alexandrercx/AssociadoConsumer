using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    [Table(name: "AssociadoPlano", Schema = "dbo")]
    public class AssociadoPlano
    {
        private readonly Plano plano;
        private readonly PlanoFaixaEtaria planoFaixaEtaria;
        public AssociadoPlano(Associado associado, Plano plano, PlanoFaixaEtaria planoFaixaEtaria)
        {
            this.plano = plano;
            this.planoFaixaEtaria = planoFaixaEtaria;
            this.AssociadoId = associado.Id;
            this.PlanoId = plano.Id;
            this.PlanoFaixaEtariaId = planoFaixaEtaria.Id;
            this.ValorContratado =  plano.ValorBase + planoFaixaEtaria.ValorAdicional;
            this.DataAtivacao = DateTime.Now;

        }
        public AssociadoPlano()
        {

        }

        
        public long Id { get; set; }

        [Required]
        public long AssociadoId { get; set; }

        [Required]
        public long PlanoId { get; set; }

        public long PlanoFaixaEtariaId { get; set; }

        [Required]
        public Decimal ValorContratado { get; set; }

        [Required]
        public DateTime DataAtivacao { get; set; }

        public DateTime? DataInativacao { get; set; }

    }
}
