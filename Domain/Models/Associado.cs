using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    [Table(name: "Associado", Schema = "dbo")]
    public class Associado
    {

        public long Id { get; set; }

        [Required]
        public long CPF { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }

        [Required]
        public string NomeMae { get; set; }

        public long? CNS { get; set; }

        public long? PisPasep { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Senha { get; set; }

        public long? TitularId { get; set; }

        [NotMapped]
        public List<Associado> dependentes { get; set; }

        [NotMapped]
        public List<Endereco> enderecos { get; set; }

        [NotMapped]
        public List<Telefone> telefones { get; set; }

        [NotMapped]
        public ContaBanco contaBanco { get; set; }

        [NotMapped]
        public List<AssociadoPlano> associadoPlanos { get; set; }

        public void AdicionarPlano(AssociadoPlano associadoPlano)
        {
            associadoPlanos = associadoPlanos == null ? new List<AssociadoPlano>() : associadoPlanos;
            associadoPlanos.Add(associadoPlano);
        }

    }
}
