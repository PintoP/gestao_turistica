using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
        public class Hospede : Pessoa
        {
            #region atributos
            private int n_reserva;
            #endregion

            #region construtor
            public Hospede(int cod, string nome, int n_telemovel, string email, int nif, string nacionalidade, int n_reserva) : base(cod, nome, n_telemovel, email, nif, nacionalidade)
            {
                this.n_reserva = n_reserva;
            }

            #endregion

            #region propriedades
            public int N_reserva
            {
                get { return n_reserva; }
                set { n_reserva = value; }
            }
            #endregion
            #region metodos
            //função usada para remover um hospede da lista de hospedes
            public void Remover_hospede(int cod_hospede, List<Hospede> lista)
            {
                Hospede hospedeRemover = lista.FirstOrDefault(h => h.Cod == cod_hospede);
                if (hospedeRemover != null)
                {
                    lista.Remove(hospedeRemover);
                    Console.WriteLine($"Hóspede com código {cod_hospede} removido com sucesso.");
                }
                else
                {
                    Console.WriteLine($"Hóspede com código {cod_hospede} não encontrado.");
                }
            }
            public void Atualiza_info(string nome, int n_telemovel, string email, int nif, string nacionalidade)
            {
                this.Nome = nome;
                this.Email = email;
                this.Nif = nif;
                this.Nacionalidade = nacionalidade;
                this.N_Telemovel = n_telemovel;

            }

            #endregion
        }

    }
