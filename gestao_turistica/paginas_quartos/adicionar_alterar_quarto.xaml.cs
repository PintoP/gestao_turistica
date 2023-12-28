using Gestao.Objetos;
using Gestao.Regras;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


using Gestao.Dados;
using Gestao.Objetos;
using Gestao.Regras;

namespace gestao_turistica.paginas_quartos
{
    /// <summary>
    /// Lógica interna para adicionar_alterar_quarto.xaml
    /// </summary>
    public partial class adicionar_alterar_quarto : Window
    {
        Quartos qs;
        int n;
        public adicionar_alterar_quarto(int n,Quartos qs)
        {
            InitializeComponent();
            if(n==1)
            {
                titulo_lb.Content = "Adicionar quarto";
                main_bt.Content = "Adicionar";
            }
            else if(n==2)
            {
                titulo_lb.Content = "Alterar quarto";
                main_bt.Content = "Alterar";
            }
            this.n= n;
            this.qs = qs;
            tipo_cb.Items.Add("Suite");
            tipo_cb.Items.Add("Standard");
            tipo_cb.Items.Add("Deluxe");
        }

        private void main_bt_Click(object sender, RoutedEventArgs e)
        {
            if(n==1)
            {
                Quarto q = new Quarto(int.Parse(n_tb.Text), tipo_cb.Text, 0, Double.Parse(preco_tb.Text));
                quarto_regras.AdicionaQuarto(q,qs);
                this.Close();
            }
            else if(n==2)
            {
               //quarto_regras.Alteraquarto(qs, int.Parse(n_tb.Text), tipo_cb.Text, double.Parse(preco_tb.Text),);
            }
        }
    }
}
