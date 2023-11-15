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
using Entidades;
using gestao;

namespace gestao_turistica
{
    /// <summary>
    /// Lógica interna para quartos_pag.xaml
    /// </summary>
    public partial class quartos_pag : Window
    {
        public quartos_pag()
        {
            InitializeComponent();
        }
        public quartos_pag(List<Quarto> lista)
        {
            InitializeComponent();
            quartos_datagrid.ItemsSource = lista;
        }
    }
}
