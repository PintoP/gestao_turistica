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
using System.Windows.Shapes;
using classe_hospede;
using classe_reserva;

namespace gestao_turistica
{
    /// <summary>
    /// Lógica interna para reservas_pag.xaml
    /// </summary>
    public partial class reservas_pag : Window
    {
        public reservas_pag()
        {
            InitializeComponent();
        }
        public reservas_pag(List<Reserva> lista)
        {
            InitializeComponent();
            reserva_datagrid.ItemsSource = lista;
        }

        private void voltar_bt_Click(object sender, RoutedEventArgs e)
        {
            MainWindow pagina = new MainWindow();
            pagina.Show();
            this.Close();
        }
    }
}
