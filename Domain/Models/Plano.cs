using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Models
{
    [Table(name: "Plano", Schema = "dbo")]
    public class Plano
    {

        [Key]
        public long Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        public Decimal ValorBase { get; set; }




    }
}
