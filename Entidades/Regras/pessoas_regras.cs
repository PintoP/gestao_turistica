using Entidades.Dados;
using Entidades.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Excecoes.hospedes_excecoes;
using static Entidades.Excecoes.pessoas_excecoes;

namespace Entidades.Regras
{
    public class pessoas_regras
    {
        public static bool AdicionaPessoa(Pessoa q, Pessoas qs)
        {

            try
            {
                qs.AdicionapessoasBD(q);
                return true;
            }
            catch (PessoasException e)
            {
                throw new PessoasException("Falha " + "-" + e.Message);
                //MessageBox.Show("Erro");
            }
        }
    }
}
