﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

//externas
using Gestao.Objetos;
using Gestao.Excecoes;

namespace Gestao.Dados
{
    public class Reservas
    {
        #region atributos
        private List<Reserva> reservas;
        #endregion

        #region contrutor
        public Reservas()
        {
            reservas = new List<Reserva>();
        }
        #endregion

        #region propriedades
        public List<Reserva> Reservas_lista
        {
            get { return reservas; }
            set { reservas = value; }
        }
        #endregion
        #region metodos
        public bool GravaProdutos(string fn)
        {
            Stream s = File.Open(fn, FileMode.Create);
            //testar se ficheiro...
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(s, reservas);
            s.Close();
            return true;
        }

        public bool carregaProdutos(string fn)
        {
            Stream s = File.Open(fn, FileMode.Open);
            //testar se ficheiro...
            BinaryFormatter b = new BinaryFormatter();
            reservas = (List<Reserva>)b.Deserialize(s);
            s.Close();
            return true;
        }

        public bool mostra_reservas(DataGrid dg, List<Reserva> r)
        {
            dg.AutoGenerateColumns = true;
            dg.ItemsSource = r;
            return true;
        }
        public Reserva EncontraReservaPorId(ArrayList reservas, int idReserva)
        {
            try
            {
                foreach (Reserva r in reservas)
                {
                    if (r.Cod_reserva == idReserva)
                    {
                        return r;
                    }
                }

                // Se não encontrar, retorna null
                return null;
            }
            catch (Exception ex)
            {
                // Lidar com exceções (registre, exiba uma mensagem de erro, etc.)
                MessageBox.Show($"Erro ao encontrar reserva por ID: {ex.Message}", "Erro", MessageBoxButton.OK, MessageBoxImage.Warning);
                return null;
            }
        }

        public ArrayList EliminaReserva(ArrayList reservas, int idReserva)
        {
            try
            {
                Reserva reservaParaRemover = EncontraReservaPorId(reservas, idReserva);

                if (reservaParaRemover != null)
                {
                    reservas.Remove(reservaParaRemover);
                    MessageBox.Show("Reserva removida com sucesso.", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Reserva não encontrada.", "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                }

                return reservas;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao eliminar reserva por ID: {ex.Message}", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                return null;
            }
        }

        public bool AdicionaReservaBD(Reserva r)
        {
            reservas.Add(r);
            return true;
        }

        #endregion
    }
}