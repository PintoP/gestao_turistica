using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestao
{
    public class Quarto
    {
        #region atributos
        private int n_quarto;
        private string tipo;
        private string status;
        private double preco_diario;
        #endregion

        #region contrutor
        public Quarto(int n_quarto, string tipo, string status, double preco_diario)
        {
            this.n_quarto = n_quarto;
            this.tipo = tipo;
            this.status = status;
            this.preco_diario = preco_diario;
        }
        #endregion

        #region propriedades
        public int N_quarto
        {
            get { return n_quarto; }
            set { n_quarto = value; }
        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public double Preco_diario
        {
            get { return preco_diario; }
            set { preco_diario = value; }
        }
        #endregion

        #region metodos
        public void Alterar_info(int novoNQuarto, string novoTipo, string novoStatus, double novoPrecoDiario)
        {
            // Aqui, você pode definir novos valores para os atributos
            N_quarto = novoNQuarto;
            Tipo = novoTipo;
            Status = novoStatus;
            Preco_diario = novoPrecoDiario;
        }

        public void elimina_quarto(int n_quarto, List<Quarto> lista)
        {
            Quarto quartoParaExcluir = lista.Find(q => q.N_quarto == n_quarto);

            if (quartoParaExcluir != null)
            {
                // Remover o quarto da lista
                lista.Remove(quartoParaExcluir);
                Console.WriteLine($"Quarto {this.N_quarto} removido com sucesso.");
            }
            else
            {
                Console.WriteLine($"Quarto {this.N_quarto} não encontrado.");
            }
        }
        #endregion
    }
}
