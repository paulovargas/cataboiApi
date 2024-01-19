using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CataboiSystem.Domain.Entities
{
    [Table("cliente")]
    public class Cliente
    {
        public Cliente()
        {
            Propriedades = new HashSet<Propriedade>();
            Rebanhos = new HashSet<Rebanho>();
            Usuarios = new HashSet<Usuario>();
        }

        [Column("id")]
        public int ClienteId { get; set; }
        
        [Column("nome_cliente")]
        public string NomeCliente { get; set; }
        
        [Column("endereco")]
        public string Endereco { get; set; }
        
        [Column("cidade")]
        public string Cidade { get; set; }
        
        [Column("estado")]
        public string Estado { get; set; }
        
        [Column("telefone")]
        public string Telefone { get; set; }
        
        [Column("email")]
        public string Email { get; set; }
        
        [Column("cpf_cnpj")]
        public string CpfCnpj { get; set; }
        
        [Column("inscricao_est")]
        public string InscricaoEst { get; set; }
        
        [Column("num_usuarios")]
        public int? NumUsuarios { get; set; }
        
        [Column("dta_inclu")]
        public DateTime? DtaInclu { get; set; }
        
        public virtual ICollection<Propriedade> Propriedades { get; set; }
        public virtual ICollection<Rebanho> Rebanhos { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
