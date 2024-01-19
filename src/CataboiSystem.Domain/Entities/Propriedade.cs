using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CataboiSystem.Domain.Entities
{
    [Table("propriedade")]
    public class Propriedade
    {
        
        [Column("id")]
        public int Id { get; set; }
        
        [Column("cliente_id")]
        public int ClienteId { get; set; }
        
        [Column("nomePropriedade")]
        public string? NomePropriedade { get; set; }
        
        [Column("localidade")]
        public string? Localidade { get; set; }
        
    }
}