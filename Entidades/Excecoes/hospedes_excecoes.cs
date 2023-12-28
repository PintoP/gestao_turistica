using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Excecoes
{
    public class hospedes_excecoes
    {
        public class HospedeException : ApplicationException
        {
            public HospedeException() : base("Erro em hospedes")
            {

            }

            public HospedeException(string s) : base(s)
            {
            }

            public HospedeException(string s, Exception e)
            {
                throw new HospedeException(s + "-" + e.Message);
            }
        }
    }
}
