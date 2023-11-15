using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using classe_pessoa;
using classe_hospede;
using classe_funcionario;
using classe_quarto;
using classe_reserva;
using System.Net.Security;

namespace gestao_turistica
{
    public partial class MainWindow : Window
    {
        //listas------------------------------------------
        List<Pessoa> lista_clientes = new List<Pessoa>();

        List<Hospede> lista_hospedes = new List<Hospede>();

        List<Funcionario> lista_funcionarios = new List<Funcionario>();

        List<Quarto> lista_quartos = new List<Quarto>();

        List<Reserva> lista_reservas = new List<Reserva>();

        //construtores-----------------------------------
        public MainWindow()//construtor inicial
        {
            InitializeComponent();
            lista_clientes.Add(new Pessoa(1,"Pedro",914247858,"pedro@gmail.com",123,"Portugal"));


            lista_funcionarios.Add(new Funcionario(1,"Rui",914247858,"rui@gmail.com",234234,"Espanhol","Recepcionista",890.20, new DateTime(2023, 1, 1)));
            lista_funcionarios.Add(new Funcionario(2,"Maria",912343333,"maria@gmail.com",123456, "Portugues", "Limpeza",880.40, new DateTime(2023, 1, 1)));
            lista_funcionarios.Add(new Funcionario(3,"Ana",914223423,"ana@gmail.com",665432,"Portugues","Cozinha",950.60, new DateTime(2023, 1, 1)));

            lista_quartos.Add(new Quarto(101, "Suite", "Ocupado", 150.0));
            lista_quartos.Add(new Quarto(102, "Suite", "Ocupado", 190.67));
            lista_quartos.Add(new Quarto(103, "Suite", "Disponivel", 260.5));
            
            lista_reservas.Add(new Reserva(1, DateTime.Now, DateTime.Now.AddDays(5), 101));
            lista_reservas.Add(new Reserva(2, DateTime.Now, DateTime.Now.AddDays(7), 102));


        }
        public MainWindow(string nome, int contacto, string email,int nif,string nacionalidade) //construtor para o cliente(classe_pessoa)
        {
            InitializeComponent();
            lista_clientes.Add(new Hospede(1, nome, contacto, email, nif, nacionalidade, 0));
        }


        //açoes dos butões--------------------------------
        private void comeca_cadastro_pessoa_Click(object sender, RoutedEventArgs e)
        {
            cadastro_pessoa pagina = new cadastro_pessoa(lista_clientes);
            pagina.Show();
            this.Close();
        }

        private void reserva_bt_Click(object sender, RoutedEventArgs e)
        {
            reservas_pag pagina = new reservas_pag(lista_reservas);
            pagina.Show();
            this.Close();
        }

        private void quarto_bt_Click(object sender, RoutedEventArgs e)
        {
            quartos_pag pagina = new quartos_pag(lista_quartos);
            pagina.Show();
            this.Close();
        }
    }
}
