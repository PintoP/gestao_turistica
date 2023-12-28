using Gestao.Objetos;
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

namespace gestao_turistica.paginas_reservas
{
    /// <summary>
    /// Lógica interna para check_in.xaml
    /// </summary>
    public partial class check_in : Window
    {
        public check_in()
        {
            InitializeComponent();
           /* foreach (Quarto quarto in listaQuartos)
            {
                minhaComboBox.Items.Add(quarto.N_quarto);
            }*/
        }

        private void add_bt_Click(object sender, RoutedEventArgs e)
        {
            //checkin_dp checkout_dp quartos
            this.Close();

        }
    }
}
