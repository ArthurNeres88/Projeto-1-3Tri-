]using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho1_ProgVis
{
    public class UsuarioRepository
    {
        public void SaveOrUpdate(Usuario usuario)
        {
            using (Repository dbContext = new())
            {
                if (usuario.Id == 0)
                {

                }
        }
    }
}
