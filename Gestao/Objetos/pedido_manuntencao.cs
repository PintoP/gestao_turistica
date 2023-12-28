using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao.Objetos
{
    public class Pedido_manuntencao
    {
        #region atributos
        private int n_pedido;
        private string descricao;
        private DateTime datapedido;
        private string status;
        private int n_quarto;
        #endregion

        #region contrutor
        public Pedido_manuntencao(int n_pedido, string descricao, DateTime datapedido, string status, int n_quarto)
        {
            this.n_pedido = n_pedido;
            this.descricao = descricao;
            this.datapedido = datapedido;
            this.status = status;
            this.n_quarto = n_quarto;
        }
        #endregion
        #region propriedades
        public int N_pedido
        {
            get { return n_pedido; }
            set { n_pedido = value; }
        }
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public DateTime Datapedido
        {
            get { return datapedido; }
            set { datapedido = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public int N_quarto
        {
            get { return n_quarto; }
            set { n_quarto = value; }
        }
        #endregion
        #region metodos
        public static void RemoverPedido(List<Pedido_manuntencao> listaPedidos, int numeroPedido)
        {
            Pedido_manuntencao pedidoRemover = listaPedidos.Find(p => p.N_pedido == numeroPedido);

            if (pedidoRemover != null)
            {
                listaPedidos.Remove(pedidoRemover);
                Console.WriteLine($"Pedido {numeroPedido} removido com sucesso.");
            }
            else
            {
                Console.WriteLine($"Pedido {numeroPedido} não encontrado.");
            }
        }

        public static void AlterarPedido(List<Pedido_manuntencao> listaPedidos, int numeroPedido, string novaDescricao, DateTime novaDataPedido, string novoStatus, int novoNumeroQuarto)
        {
            Pedido_manuntencao pedidoAlterar = listaPedidos.Find(p => p.N_pedido == numeroPedido);

            if (pedidoAlterar != null)
            {
                // Atualiza as informações do pedido
                pedidoAlterar.Descricao = novaDescricao;
                pedidoAlterar.Datapedido = novaDataPedido;
                pedidoAlterar.Status = novoStatus;
                pedidoAlterar.N_quarto = novoNumeroQuarto;

                Console.WriteLine($"Informações do Pedido {numeroPedido} alteradas com sucesso.");
            }
            else
            {
                Console.WriteLine($"Pedido {numeroPedido} não encontrado.");
            }
        }
        #endregion
    }
}