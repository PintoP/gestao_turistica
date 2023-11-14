using classe_quarto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classe_reserva
{
    public class Reserva
    {
        #region atributos
        private int cod_reserva;
        private DateTime checkin;
        private DateTime checkout;
        private Quarto quarto;
        #endregion

        #region contrutor
        public Reserva(int cod_reserva, DateTime checkin,DateTime checkout,Quarto quarto)
        {
            this.cod_reserva = cod_reserva;
            this.checkin = checkin;
            this.checkout = checkout;
            this.quarto = quarto;
        }
        #endregion
        #region propriedades
        public int Cod_reserva
        {
            get { return cod_reserva; }
            set { cod_reserva = value; }
        }
        public DateTime Checkin
        {
            get { return checkin; }
            set { checkin = value; }
        }
        public DateTime Checkout
        {
            get { return checkout; }
            set { checkout = value; }
        }
        public Quarto Quarto
        {
            get { return quarto; }
            set { quarto = value; }
        }
        #endregion
        #region metodos
        public void realiza_checkout()
        {

        }
        #endregion
    }
}
