namespace Academico.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Aluno")]
    public partial class Aluno
    {
        public int ID { get; set; }

        [Required]
        [StringLength(80)]
        public string Nome { get; set; }

        [Required]
        [StringLength(11)]
        public string CPF { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(11)]
        public string Telefone { get; set; }

        [StringLength(1024)]
        public string Observacao { get; set; }
    }
}
