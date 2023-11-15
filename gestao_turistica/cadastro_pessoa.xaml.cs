using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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
using classe_pessoa;

namespace gestao_turistica
{
    /// <summary>
    /// Lógica interna para cadastro_pessoa.xaml
    /// </summary>
    public partial class cadastro_pessoa : Window
    {
        List<Pessoa> pess_lista;
        public cadastro_pessoa(List<Pessoa> lista)
        {
            InitializeComponent();
            pess_lista = lista;
            clientes_datagrid.ItemsSource = lista;
        }
        private void add_bt_Click(object sender, RoutedEventArgs e)
        {
            int maiorCodigo = (Pessoa.ObterMaiorCodigoPessoa(pess_lista))+1;
            pess_lista.Add(new Pessoa(maiorCodigo, nome_tb.Text, int.Parse(ntelemovel_tb.Text), email_tb.Text, int.Parse(nif_tb.Text), nacionalidade_tb.Text));

            clientes_datagrid.ItemsSource = null;
            clientes_datagrid.ItemsSource = pess_lista;
        }

        private void elimina_bt_Click(object sender, RoutedEventArgs e)
        {
            Pessoa.RemoverPessoaPorCodigo(int.Parse(ntelemovel_tb.Text), pess_lista);


           clientes_datagrid.ItemsSource = null;
            clientes_datagrid.ItemsSource = pess_lista;
        }
    }
}
