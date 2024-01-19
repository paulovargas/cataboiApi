using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CataboiSystem.Domain.Entities
{
    [Table("admin")]
    public class Admin
    {
        [Column("id")]
        public int AdminId { get; set; }
        [Column("nome")]
        public string? Nome { get; set; }
        [Column("cpf")]
        public string? Cpf { get; set; }
        [Column("cargo")]
        public string? Cargo { get; set; }
        [Column("email")]
        public string? Email { get; set; }
        [Column("senha")]
        public string? Senha { get; set; }
    }
}
