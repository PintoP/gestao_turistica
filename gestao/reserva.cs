using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestao
{
    public class Reserva
    {
        #region atributos
        private int cod_reserva;
        private DateTime checkin;
        private DateTime checkout;
        private int n_quarto;
        private int preco_total;
        #endregion

        #region contrutor
        public Reserva(int cod_reserva, DateTime checkin, DateTime checkout, int n_quarto)
        {
            this.cod_reserva = cod_reserva;
            this.checkin = checkin;
            this.checkout = checkout;
            this.n_quarto = n_quarto;
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
        public int N_quarto
        {
            get { return n_quarto; }
            set { n_quarto = value; }
        }
        #endregion
        #region metodos

        public static int nDiasreserva(int codReserva, List<Reserva> listaReservas)
        {
            Reserva reserva = listaReservas.Find(r => r.cod_reserva == codReserva);

            DateTime dataCheckin = reserva.Checkin;
            DateTime dataCheckout = reserva.Checkout;

            TimeSpan diferenca = dataCheckout - dataCheckin;

            return Math.Abs((int)diferenca.TotalDays);

        }
        public static double valor_total(int codReserva, List<Reserva> listaReservas, List<Quarto> listaQuartos)
        {
            Reserva reserva = listaReservas.Find(r => r.cod_reserva == codReserva);

            int numeroDias = nDiasreserva(codReserva, listaReservas);

            // Encontrar o preço diário do quarto associado à reserva
            double precoDiario = listaQuartos.Find(q => q.N_quarto == reserva.n_quarto).Preco_diario;

            // Calcular o valor total a pagar
            double valorTotal = numeroDias * precoDiario;

            return valorTotal;
        }

        public void confirma_checkout(int codReserva, List<Reserva> listaReservas)
        {
            Reserva reserva_Remove = listaReservas.Find(r => r.cod_reserva == codReserva);

            if (reserva_Remove != null)
            {
                listaReservas.Remove(reserva_Remove);
                Console.WriteLine($"Reserva com código {codReserva} removida com sucesso.");
            }
            else
            {
                Console.WriteLine($"Reserva com código {codReserva} não encontrada.");
            }
        }
        #endregion
    }
}


