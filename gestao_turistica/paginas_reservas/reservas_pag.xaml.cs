using System;
using System.Collections;
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
using System.Windows.Shapes;
using Entidades;
using Gestao.Dados;
using Gestao.Objetos;
using Gestao.Regras;

namespace gestao_turistica
{
    /// <summary>
    /// Lógica interna para reservas_pag.xaml
    /// </summary>
    public partial class reservas_pag : Window
    {
        Reservas reservas = new Reservas();
        public reservas_pag()
        {
            InitializeComponent();
        }
        public reservas_pag(Reservas lista)
        {
            InitializeComponent();
            reservas = lista;
            try
            {
                reservas.mostra_reservas(reserva_datagrid, lista.Reservas_lista);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao exibir reservas: {ex.Message}", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void voltar_bt_Click(object sender, RoutedEventArgs e)
        {
            MainWindow pagina = new MainWindow();
            pagina.Show();
            this.Close();
        }

        private void check_in_bt_Click(object sender, RoutedEventArgs e)
        {
            //reservas.AdicionaReserva()
            paginas_reservas.check_in pag = new  paginas_reservas.check_in();
            pag.Show();
            
            reservas.mostra_reservas(reserva_datagrid, reservas.Reservas_lista);

        }

        private void check_out_bt_Click(object sender, RoutedEventArgs e)
        {
            reservas.mostra_reservas(reserva_datagrid, reservas.Reservas_lista);
        }
    }
}
