using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace classe_pessoa
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

        #endregion
    }
}
