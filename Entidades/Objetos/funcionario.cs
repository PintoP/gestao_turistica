using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Objetos
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
        public DateTime Data_Contrato
        {
            get { return data_contrato; }
            set { data_contrato = value; }
        }
        #endregion

        #region metodos
        public void AlterarDados(int novoCod, string novoNome, int novoNTelemovel, string novoEmail, int novoNif, string novaNacionalidade, string novoCargo, double novoSalario, DateTime novaDataContrato)
        {
            // Chama o método da classe base para alterar os dados da pessoa
            Cod = novoCod;
            Nome = novoNome;
            N_Telemovel = novoNTelemovel;
            Email = novoEmail;
            Nif = novoNif;
            Nacionalidade = novaNacionalidade;

            // Agora altera os dados específicos do Funcionario
            Cargo = novoCargo;
            Salario = novoSalario;
            Data_Contrato = novaDataContrato;
        }

        public static void RemoverFuncionarioPorCodigo(List<Funcionario> listaFuncionarios, int codigoFuncionario)
        {
            Funcionario funcionarioRemover = listaFuncionarios.Find(f => f.Cod == codigoFuncionario);

            if (funcionarioRemover != null)
            {
                listaFuncionarios.Remove(funcionarioRemover);
                Console.WriteLine($"Funcionário com código {codigoFuncionario} removido com sucesso.");
            }
            else
            {
                Console.WriteLine($"Funcionário com código {codigoFuncionario} não encontrado.");
            }
        }

        #endregion
    }
}
