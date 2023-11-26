using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
        public class Pessoa
        {
            #region atributos
            private int cod;
            private string nome;
            private int n_telemovel;
            private string email;
            private int nif;
            private string nacionalidade;
            #endregion

            #region construtor
            public Pessoa(int cod, string nome, int n_telemovel, string email, int nif, string nacionalidade)
            {
                this.cod = cod;
                this.nome = nome;
                this.n_telemovel = n_telemovel;
                this.email = email;
                this.nif = nif;
                this.nacionalidade = nacionalidade;
            }
            #endregion

            #region propriedades
            public int Cod
            {
                get { return cod; }
                set { cod = value; }
            }
            public string Nome
            {
                get { return nome; }
                set { nome = value; }
            }

            public int N_Telemovel
            {
                get { return n_telemovel; }
                set { n_telemovel = value; }
            }

            public string Email
            {
                get { return email; }
                set { email = value; }
            }

            public int Nif
            {
                get { return nif; }
                set { nif = value; }
            }

            public string Nacionalidade
            {
                get { return nacionalidade; }
                set { nacionalidade = value; }
            }
            #endregion

            #region metodos
            public static int ObterMaiorCodigoPessoa(List<Pessoa> lista)
            {
                int maiorCodigo;
                try
                {
                    maiorCodigo = lista.Max(pessoa => pessoa.Cod);
                }
                catch { maiorCodigo = 0; }

                return maiorCodigo;
            }

            public static void RemoverPessoaPorCodigo(int codigo, List<Pessoa> lista)
            {
                // Encontre a pessoa na lista com base no código
                Pessoa pessoaParaRemover = lista.FirstOrDefault(pessoa => pessoa.Cod == codigo);

                // Se a pessoa foi encontrada, remova-a da lista
                if (pessoaParaRemover != null)
                {
                    lista.Remove(pessoaParaRemover);
                }
                else
                {
                    //MessageBox.Show("Cliente não encontrada com o código especificado.");
                }
            }

            private void AtualizarPessoaPorCodigo(int codigo, string novoNome, int novoTelefone, string novoEmail, int novoNIF, string novaNacionalidade, List<Pessoa> lista)
            {
                // Encontre a pessoa na lista com base no código
                Pessoa pessoaParaAtualizar = lista.FirstOrDefault(pessoa => pessoa.Cod == codigo);

                // Se a pessoa foi encontrada, atualize suas propriedades
                if (pessoaParaAtualizar != null)
                {
                    pessoaParaAtualizar.Nome = novoNome;
                    pessoaParaAtualizar.N_Telemovel = novoTelefone;
                    pessoaParaAtualizar.Email = novoEmail;
                    pessoaParaAtualizar.Nif = novoNIF;
                    pessoaParaAtualizar.Nacionalidade = novaNacionalidade;
                }
                else
                {
                    //MessageBox.Show("Cliente não encontrada com o código especificado.");
                }
            }
            #endregion
        }

    }
