using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace gestao
{
    [Serializable]
    public class Reserva
    {
        #region atributos
        private int cod_reserva;
        private DateTime checkin;
        private DateTime checkout;
        private int n_quarto;
        [NonSerialized] private double preco_total;
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
    //função para saber o nº de dias que uma reserva tem
        public static int nDiasreserva(int codReserva, ArrayList listaReservas)
        {
            Reserva reservaEncontrada = null;

            foreach (var item in listaReservas)
            {
                if (((Reserva)item).cod_reserva == codReserva)
                {
                    reservaEncontrada = (Reserva)item;
                    break;
                }
            }

            if (reservaEncontrada != null)
            {
                DateTime dataCheckin = reservaEncontrada.Checkin;
                DateTime dataCheckout = reservaEncontrada.Checkout;

                TimeSpan diferenca = dataCheckout - dataCheckin;

                return Math.Abs((int)diferenca.TotalDays);
            }
            else
            {
                // Se a reserva não for encontrada, retorna um valor padrão ou lançar uma exceção, dependendo do seu caso.
                throw new ArgumentException($"A reserva com o código {codReserva} não foi encontrada na lista.");
            }
        }

        public static double valor_total(int codReserva, ArrayList listaReservas, ArrayList listaQuartos)
        {
            Reserva reserva = null;

            foreach (var item in listaReservas)
            {
                if (((Reserva)item).cod_reserva == codReserva)
                {
                    reserva = (Reserva)item;
                    break;
                }
            }

            if (reserva != null)
            {
                int numeroDias = nDiasreserva(codReserva, listaReservas);

                // Encontrar o preço diário do quarto associado à reserva
                double precoDiario = 0;

                foreach (var quarto in listaQuartos)
                {
                    if (((Quarto)quarto).N_quarto == reserva.n_quarto)
                    {
                        precoDiario = ((Quarto)quarto).Preco_diario;
                        break;
                    }
                }

                // Calcular o valor total a pagar
                double valorTotal = numeroDias * precoDiario;

                return valorTotal;
            }
            else
            {
                // Se a reserva não for encontrada, você pode retornar um valor padrão ou lançar uma exceção, dependendo do seu caso.
                throw new ArgumentException($"A reserva com o código {codReserva} não foi encontrada na lista.");
            }
        }
        #endregion
    }
}


