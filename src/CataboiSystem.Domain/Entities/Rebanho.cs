using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CataboiSystem.Domain.Entities
{
    [Table("rebanho")]
    public class Rebanho
    {
        public Rebanho()
        {
            Eventos = new HashSet<Evento>();
        }

        [Column("id")]
        public int Id { get; set; }
        
        [Column("cliente_id")]
        public int ClienteId { get; set; }
        
        [Column("nomeRebanho")]
        public string NomeRebanho { get; set; }
        
        [Column("descriRebanho")]
        public string DescriRebanho { get; set; }

        //public virtual Cliente Cliente { get; set; }
        public virtual ICollection<Evento> Eventos { get; set; }
    }
}
