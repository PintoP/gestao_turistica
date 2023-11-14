using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using classe_quarto;

namespace cleasse_pedido_manuntencao
{
    public class Pedido_manuntencao
    {
        #region atributos
        private int n_pedido;
        private string descricao;
        private DateTime datapedido;
        private string status;
        private Quarto quarto;
        #endregion

        #region contrutor
        public Pedido_manuntencao(int n_pedido, string descricao,DateTime datapedido,string status,Quarto quarto)
        {
            this.n_pedido = n_pedido;
            this.descricao = descricao;
            this.datapedido = datapedido;
            this.status = status;
            this.quarto = quarto;
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
        public Quarto Quarto
        {
            get { return quarto; }
            set { quarto = value; }
        }
        #endregion
        #region metodos

        #endregion
    }
}
