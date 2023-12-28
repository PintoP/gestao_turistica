using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao.Excecoes
{
    public class QuartoException : ApplicationException
    {
        public QuartoException() : base("Erro em reservas")
        {

        }

        public QuartoException(string s) : base(s)
        {
        }

        public QuartoException(string s, Exception e)
        {
            throw new QuartoException(s + "-" + e.Message);
        }
    }
}
