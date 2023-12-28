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
    /// Lógica interna para quartos_pag.xaml
    /// </summary>
    public partial class quartos_pag : Window
    {
        Quartos quartos;
        public quartos_pag()
        {
            InitializeComponent();
        }
        public quartos_pag(Quartos lista)
        {
            InitializeComponent();
            quartos_datagrid.IsReadOnly = true;
            lista.Mostra_quartos(quartos_datagrid, lista.Quartos_lista);
            quartos = lista;
        }

        private void adicionar_quarto_bt_Click(object sender, RoutedEventArgs e)
        {
            paginas_quartos.adicionar_alterar_quarto pagina = new paginas_quartos.adicionar_alterar_quarto(1,quartos);
            pagina.Show();
        }

        private void alterar_bt_Click(object sender, RoutedEventArgs e)
        {
            paginas_quartos.adicionar_alterar_quarto pagina = new paginas_quartos.adicionar_alterar_quarto(2, quartos);
            pagina.Show();
        }

        private void eliminar_quarto_bt_Click(object sender, RoutedEventArgs e)
        {
            testelb.Content = quartos.EncontrarQuartoSelecionado(quartos_datagrid);
            quarto_regras.Eliminaquarto(quartos, quartos_datagrid);
            quartos_datagrid.ItemsSource = null;
            quartos.Mostra_quartos(quartos_datagrid, quartos.Quartos_lista);
        }
    }
}
