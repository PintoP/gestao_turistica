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

namespace gestao_turistica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        List<Pessoa> clientes = new List<Pessoa>()
        {
            
        };

        List<Hospede> hospedes = new List<Hospede>()
        {

        };

        List<Funcionario> funcionarios = new List<Funcionario>()
        {

        };

        private void comeca_cadastro_pessoa_Click(object sender, RoutedEventArgs e)
        {
            cadastro_pessoa pagina = new cadastro_pessoa();
            pagina.Show();
            this.Close();
        }
    }
}
