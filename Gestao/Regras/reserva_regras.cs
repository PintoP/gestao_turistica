using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

//externas
using Gestao.Dados;
using Gestao.Excecoes;
using Gestao.Objetos;

namespace Gestao.Regras
{
    public class reserva_regras
    {
        public static bool AdicionaReserva(Reserva r,Reservas rs)
        {

            try
            {
                // Verificar se há conflito de datas para o mesmo quarto
                foreach (Reserva reservaExistente in rs.Reservas_lista)
                {
                    if (reservaExistente.N_quarto == r.N_quarto &&
                        (r.Checkin >= reservaExistente.Checkin && r.Checkin < reservaExistente.Checkout ||
                         r.Checkout > reservaExistente.Checkin && r.Checkout <= reservaExistente.Checkout))
                    {
                        throw new ReservasException("Conflito de datas para o mesmo quarto. Não é possível adicionar a reserva.");
                    }
                }

                // Adicionar a reserva se não houver conflito
                rs.AdicionaReservaBD(r);
                MessageBox.Show("Reserva adicionada com sucesso.", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
                return true;
            }
            catch (ReservasException e)
            {
                throw new ReservasException("Falha " + "-" + e.Message);
                MessageBox.Show("Erro");
            }
        }
    }
}
