using Entidades.Dados;
using Entidades.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Entidades.Dados;
using Entidades.Excecoes;
using Entidades.Objetos;
using static Entidades.Excecoes.hospedes_excecoes;

namespace Entidades.Regras
{
    public class hospedes_regras
    {
        public static bool AdicionaHospede(Hospede q, Hospedes qs)
        {

            try
            {
                qs.AdicionaQuartoBD(q);
                return true;
            }
            catch (HospedeException e)
            {
                throw new HospedeException("Falha " + "-" + e.Message);
                //MessageBox.Show("Erro");
            }
        }
    }
}
