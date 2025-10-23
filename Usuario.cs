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
        public Int64  Id        { get; set; }
        [Required]
        [StringLength(45)]
        public String? Nome     { get; set; }
        public String? Telefone { get; set; }
        public String? Email    { get; set; }
    }
}
