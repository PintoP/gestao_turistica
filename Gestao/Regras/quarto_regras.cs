using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;
using System.Windows.Documents;
using System.Windows.Media;

//externas
using Gestao.Dados;
using Gestao.Excecoes;
using Gestao.Objetos;

namespace Gestao.Regras
{
    public class quarto_regras
    {
        public static bool AdicionaQuarto(Quarto q,Quartos qs)
        {

            try
            {
                qs.AdicionaQuartoBD(q);
                return true;
            }
            catch (QuartoException e)
            {
                throw new QuartoException("Falha " + "-" + e.Message);
                //MessageBox.Show("Erro");
            }
        }

        public static bool Eliminaquarto(Quartos qs,DataGrid dg)
        {
            try
            {
                qs.EliminarQuartoBD(dg);
                return true;
            }
            catch (QuartoException e) 
            {
                throw new QuartoException("Falha " + "-" + e.Message);
                //MessageBox.Show("Erro");
            }
        }

        public static bool Alteraquarto(Quartos qs,int n,string tipo,double preco,DataGrid dg)
        {
            try
            {
                qs.AlteraQuartoBD(dg,n,tipo,preco);
                return true;
            }
            catch (QuartoException e)
            {
                throw new QuartoException("Falha " + "-" + e.Message);
            }

        }
    }
}
