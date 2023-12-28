using Entidades.Objetos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Entidades.Dados
{
    public class Hospedes
    {
        #region atributos
        private List<Hospede> hospedes;
        #endregion

        #region contrutor
        public Hospedes()
        {
            hospedes = new List<Hospede>();
        }
        #endregion

        #region propriedades
        public List<Hospede> Hospedes_lista
        {
            get { return hospedes; }
            set { hospedes = value; }
        }
        #endregion
        #region metodos
        public bool GravaHospedes(string fn)
        {
            Stream s = File.Open(fn, FileMode.Create);
            //testar se ficheiro...
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(s, hospedes);
            s.Close();
            return true;
        }

        public bool CarregaHospedes(string fn)
        {
            Stream s = File.Open(fn, FileMode.Open);
            //testar se ficheiro...
            BinaryFormatter b = new BinaryFormatter();
            hospedes = (List<Hospede>)b.Deserialize(s);
            s.Close();
            return true;
        }

        public bool Mostra_hospedes(DataGrid dg, List<Hospede> q)
        {
            dg.AutoGenerateColumns = true;
            dg.ItemsSource = q;
            return true;
        }

        public bool AdicionaQuartoBD(Hospede q)
        {
            hospedes.Add(q);
            return true;
        }
        /// <summary>
        /// /
        /// </summary>
        /// <param name="dg"></param>
        /// <returns></returns>
        public int EncontrarHospedeSelecionado(DataGrid dg)
        {
            // Verifica se há pelo menos uma linha selecionada
            if (dg.SelectedItem != null && dg.SelectedItem is Hospede hospedeSelecionado)
            {
                return hospedeSelecionado.Cod;
            }
            else
            {
                Console.WriteLine("Nenhum quarto selecionado.");
                return 0;
            }

        }

        public bool EliminarQuartoBD(DataGrid dg)
        {

            int nHospedeParaRemover = EncontrarHospedeSelecionado(dg);
            if (nHospedeParaRemover != null)
            {
                Hospede hospedeParaRemover = hospedes.FirstOrDefault(q => q.Cod == nHospedeParaRemover);

                if (hospedeParaRemover != null)
                {
                    hospedes.Remove(hospedeParaRemover);
                    MessageBox.Show($"Hospede {nHospedeParaRemover} removido com sucesso!");
                    return true;
                }
                else
                {
                    MessageBox.Show($"Hospede {nHospedeParaRemover} não encontrado na lista.");
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