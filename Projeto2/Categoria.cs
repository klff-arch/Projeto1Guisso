using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    public class Categoria
    {
        private String _nome;
        public String Nome {
            get
            {
                return _nome;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("");
                }
                _nome = value;
            } 
        }
    }
}
