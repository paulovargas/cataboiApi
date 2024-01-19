using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CataboiSystem.Domain.Entities
{
    [Table("usuario")]
    public class Usuario
    {
        [Column("idusu")]
        public int Idusu { get; set; }
        
        [Column("cliente_id")]
        public int ClienteId { get; set; }
        
        [Column("nome")]
        public string? Nome { get; set; }
        
        /* [Column("email")]
        public string? Email { get; set; }
        
        [Column("senha")]
        public string? Senha { get; set; } */

        //public virtual Cliente? Cliente { get; set; }
    }
}
