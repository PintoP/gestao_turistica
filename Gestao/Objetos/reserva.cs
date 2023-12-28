using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Gestao.Objetos
{
    [Serializable]
    public class Reserva
    {
        #region atributos
        private int cod_reserva;
        private DateTime checkin;
        private DateTime checkout;
        private int n_quarto;
        [NonSerialized] private int preco_total;
        int estado;//1-concluida 2-a ocurrer/por ocurrer
        #endregion

        #region contrutor
        public Reserva(int cod_reserva, DateTime checkin, DateTime checkout, int n_quarto)
        {
            this.cod_reserva = cod_reserva;
            this.checkin = checkin;
            this.checkout = checkout;
            this.n_quarto = n_quarto;
            estado = 2;
            preco_total = 0;
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
        public int Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        #endregion
        #region metodos
        public static int nDiasreserva(int codReserva, ArrayList listaReservas)
        {
            Reserva reserva = null;

            foreach (Reserva r in listaReservas)
            {
                if (r.cod_reserva == codReserva)
                {
                    reserva = r;
                    break;
                }
            }

            if (reserva == null)
            {
                // Tratar a situação em que a reserva não foi encontrada
                return -1;
            }

            DateTime dataCheckin = reserva.Checkin;
            DateTime dataCheckout = reserva.Checkout;

            TimeSpan diferenca = dataCheckout - dataCheckin;

            return Math.Abs((int)diferenca.TotalDays);
        }

        public static double valor_total(int codReserva, ArrayList listaReservas, ArrayList listaQuartos)
        {
            Reserva reserva = null;

            foreach (Reserva r in listaReservas)
            {
                if (r.cod_reserva == codReserva)
                {
                    reserva = r;
                    break;
                }
            }

            if (reserva == null)
            {
                // Tratar a situação em que a reserva não foi encontrada
                return -1;
            }

            int numeroDias = nDiasreserva(codReserva, listaReservas);

            // Encontrar o preço diário do quarto associado à reserva
            Quarto quarto = null;

            foreach (Quarto q in listaQuartos)
            {
                if (q.N_quarto == reserva.n_quarto)
                {
                    quarto = q;
                    break;
                }
            }

            if (quarto == null)
            {
                // Tratar a situação em que o quarto não foi encontrado
                return -1;
            }

            // Calcular o valor total a pagar
            double precoDiario = quarto.Preco_diario;
            double valorTotal = numeroDias * precoDiario;

            return valorTotal;
        }
        #endregion
    }
}