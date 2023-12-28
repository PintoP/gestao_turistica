using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao.Excecoes
{
    public class ReservasException : ApplicationException
    {
        public ReservasException() : base("Erro em reservas")
        {

        }

        public ReservasException(string s) : base(s) 
        {
        }

        public ReservasException(string s, Exception e)
        {
            throw new ReservasException(s + "-" + e.Message);
        }
    }
}
