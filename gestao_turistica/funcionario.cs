using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using classe_pessoa;

namespace classe_funcionario
{
    public class Funcionario : Pessoa
    {
        #region atributos
        private string cargo;
        private double salario;
        private DateTime data_contrato;
        #endregion

        #region contrutor
        public Funcionario(int cod, string nome, int n_telemovel, string email, int nif, string nacionalidade, string cargo, double salario, DateTime data_contrato) : base(cod, nome, n_telemovel, email, nif, nacionalidade)
        {
            this.cargo = cargo;
            this.salario = salario;
            this.data_contrato = data_contrato;
        }
        #endregion
        #region propriedades
        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public DateTime Checkout_data
        {
            get { return data_contrato; }
            set { data_contrato = value; }
        }
        #endregion

        #region metodos
        #endregion
    }
}
