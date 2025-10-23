using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;


namespace Trabalho1_ProgVis
{
    public class Credencial
    {
        public Int64 Id { get; set; }

        public const String SALT = "1FnM6_";

        private String _senha;

        [Required]
        [StringLength(64)]
        public String Senha
        {
            get
            {
                return _senha;
            }
            set
            {
                _senha = ComputeSHA256(value, SALT);
            }
        }

        public bool Administrador { get; set; }

      
    }
}
