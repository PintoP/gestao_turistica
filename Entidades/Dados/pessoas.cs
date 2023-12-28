using Entidades.Objetos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;

namespace Entidades.Dados
{
    public class Pessoas
    {
        #region atributos
        private List<Pessoa> pessoas;
        #endregion

        #region contrutor
        public Pessoas()
        {
            pessoas = new List<Pessoa>();
        }
        #endregion

        #region propriedades
        public List<Pessoa> Pessoas_lista
        {
            get { return pessoas; }
            set { pessoas = value; }
        }
        #endregion
        #region metodos
        public bool GravaPessoas(string fn)
        {
            Stream s = File.Open(fn, FileMode.Create);
            //testar se ficheiro...
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(s, pessoas);
            s.Close();
            return true;
        }

        public bool CarregaPessoas(string fn)
        {
            Stream s = File.Open(fn, FileMode.Open);
            //testar se ficheiro...
            BinaryFormatter b = new BinaryFormatter();
            pessoas = (List<Pessoa>)b.Deserialize(s);
            s.Close();
            return true;
        }

        public bool Mostra_pessoas(DataGrid dg, List<Pessoa> q)
        {
            dg.AutoGenerateColumns = true;
            dg.ItemsSource = q;
            return true;
        }

        public bool AdicionapessoasBD(Pessoa q)
        {
            pessoas.Add(q);
            return true;
        }
        /// <summary>
        /// /
        /// </summary>
        /// <param name="dg"></param>
        /// <returns></returns>
        public int EncontrarPessoaSelecionado(DataGrid dg)
        {
            // Verifica se há pelo menos uma linha selecionada
            if (dg.SelectedItem != null && dg.SelectedItem is Pessoa pessoaSelecionado)
            {
                return pessoaSelecionado.Cod;
            }
            else
            {
                Console.WriteLine("Nenhuma pessoa selecionado.");
                return 0;
            }

        }

        public bool EliminarQuartoBD(DataGrid dg)
        {

            int nPessoaParaRemover = EncontrarPessoaSelecionado(dg);
            if (nPessoaParaRemover != null)
            {
                Pessoa pessoaParaRemover = pessoas.FirstOrDefault(q => q.Cod == nPessoaParaRemover);

                if (pessoaParaRemover != null)
                {
                    pessoas.Remove(pessoaParaRemover);
                    MessageBox.Show($"Hospede {nPessoaParaRemover} removido com sucesso!");
                    return true;
                }
                else
                {
                    MessageBox.Show($"Hospede {nPessoaParaRemover} não encontrado na lista.");
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
