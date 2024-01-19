using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CataboiSystem.Domain.Entities
{
    [Table("animais")]
    public class Animal
    {
        
        [Column("idanimal")]
        public int Idanimal { get; set; }

        [Column("rebanho_id")]
        public int RebanhoId { get; set; }
        
        [Column("propriedade_id")]
        public string? Propriedade { get; set; }
        
        [Column("especie")]
        public string? Especie { get; set; }
        
        [Column("numero_brincos")]
        public string? NumeroBrincos { get; set; }
        
        [Column("data_nascimento")]
        public DateTime? DataNascimento { get; set; }
        
        [Column("status")]
        public string? Status { get; set; }
        
        [Column("raca")]
        public string? Raca { get; set; }
        
        [Column("pelagem")]
        public string? Pelagem { get; set; }
        
        [Column("sexo")]
        public string? Sexo { get; set; }
        
        [Column("prenhez")]
        public string? Prenhez { get; set; }
        
        [Column("peso")]
        public float? Peso { get; set; }
        
        [Column("foto")]
        public byte[]? Foto { get; set; }
        
        [Column("descricao")]
        public string? Descricao { get; set; }
    }
}
