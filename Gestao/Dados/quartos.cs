using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;


using Gestao.Objetos;
using Microsoft.Windows.Themes;

namespace Gestao.Dados
{
    public class Quartos
    {
        #region atributos
        private List<Quarto> quartos;
        #endregion

        #region contrutor
        public Quartos()
        {
            quartos = new List<Quarto>();
        }
        #endregion

        #region propriedades
        public List<Quarto> Quartos_lista
        {
            get { return quartos; }
            set { quartos =value; }
        }
        #endregion
        #region metodos
        public bool GravaQuartos(string fn)
        {
            Stream s = File.Open(fn, FileMode.Create);
            //testar se ficheiro...
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(s, quartos);
            s.Close();
            return true;
        }

        public bool CarregaQuartos(string fn)
        {
            Stream s = File.Open(fn, FileMode.Open);
            //testar se ficheiro...
            BinaryFormatter b = new BinaryFormatter();
            quartos = (List<Quarto>)b.Deserialize(s);
            s.Close();
            return true;
        }

        public bool Mostra_quartos(DataGrid dg, List<Quarto> q)
        {
            dg.AutoGenerateColumns = true;
            dg.ItemsSource = q;
            return true;
        }



        public bool AdicionaQuartoBD(Quarto q)
        {
            quartos.Add(q);
            return true;
        }

        public int EncontrarQuartoSelecionado(DataGrid dg)
        {
            // Verifica se há pelo menos uma linha selecionada
            if (dg.SelectedItem != null && dg.SelectedItem is Quarto quartoSelecionado)
            {
                return quartoSelecionado.N_quarto;
            }
            else
            {
                Console.WriteLine("Nenhum quarto selecionado.");
                return 0;
            }
            
        }

        public bool EliminarQuartoBD(DataGrid dg)
        {
            
            int nQuartoParaRemover = EncontrarQuartoSelecionado(dg);
            if (nQuartoParaRemover != null)
            {
                Quarto quartoParaRemover = quartos.FirstOrDefault(q => q.N_quarto == nQuartoParaRemover);

                if (quartoParaRemover != null)
                {
                    quartos.Remove(quartoParaRemover);
                    MessageBox.Show($"Quarto {nQuartoParaRemover} removido com sucesso!");
                    return true;
                }
                else
                {
                    MessageBox.Show($"Quarto {nQuartoParaRemover} não encontrado na lista.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Nenhum número de quarto fornecido para remoção.");
                return false;
            }
        }


        public bool AlteraQuartoBD(DataGrid dg,int n,string tipo,double preco)
        {
            n = EncontrarQuartoSelecionado(dg);
            if(n!=null)
            {
                Quarto quartoparaalterar = quartos.FirstOrDefault(q =>q.N_quarto == n);

                if(quartoparaalterar != null)
                {
                    quartoparaalterar.Tipo = tipo;
                    quartoparaalterar.Preco_diario = preco;
                    quartoparaalterar.N_quarto = n;
                    return true;
                }
                else
                {
                    MessageBox.Show($"Quarto {n} não encontrado na lista.");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Nenhum número de quarto fornecido para remoção.");
                return false;
            }
        }
        
        #endregion
    }
}