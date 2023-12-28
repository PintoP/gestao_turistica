using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excecoes
{
    public class pessoas_excecoes
    {
        public class PessoasException : ApplicationException
        {
            public PessoasException() : base("Erro em hospedes")
            {

            }

            public PessoasException(string s) : base(s)
            {
            }

            public PessoasException(string s, Exception e)
            {
                throw new PessoasException(s + "-" + e.Message);
            }
        }
    }
}