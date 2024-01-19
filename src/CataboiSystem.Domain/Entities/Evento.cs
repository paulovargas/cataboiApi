using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CataboiSystem.Domain.Entities
{
    [Table("eventos")]
    public class Evento
    {
        [Column("idevenR")]
        public int IdevenR { get; set; }
        
        [Column("rebanho_id")]
        public int RebanhoId { get; set; }
        
        [Column("animal_id")]
        public int? AnimalId { get; set; }
        
        [Column("evento_grupo")]
        public int EventoGrupo { get; set; }
        
        [Column("nome")]
        public string? Nome { get; set; }
        
        [Column("local")]
        public string? Local { get; set; }
        
        [Column("data_evento")]
        public DateOnly DataEvento { get; set; }
        
        [Column("descri")]
        public string? Descri { get; set; }
        
        [Column("obser")]
        public string? Obser { get; set; }
    }
}
