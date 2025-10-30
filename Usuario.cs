using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trabalho1_ProgVis
{
    [Table("Usuarios")]
    public class Usuario
    {
        [Key]
        public Int64  Id { get; set; }
        
        [Required]
        [StringLength(45)]
        public String? Nome { get; set; }
        
        [Required]
        [StringLength(15)]
        public String? Telefone { get; set; }
        
        [Required]
        [StringLength(35)]
        public String? Email { get; set; }

        public Int64 CredencialId { get; set; }

        [Required]
        [ForeignKey("CredencialId")]
        public Credencial Credencial { get; set; }

        public override string ToString()
        {
            return Id
                + " - " + Nome
                + " - " + Telefone
                + " - " + Email
                + " - " + Credencial;
        }
    }
}
