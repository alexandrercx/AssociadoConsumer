using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{

    [Table(name: "PlanoFaixaEtaria", Schema = "dbo")]
    public class PlanoFaixaEtaria
    {

        [Key]
        public long Id { get; set; }

        [Required]
        public long PlanoId { get; set; }

        [Required]
        public int IdadeInicial { get; set; }

        [Required]
        public int IdadeFinal { get; set; }

        [Required]
        public Decimal ValorAdicional { get; set; }



    }
}
