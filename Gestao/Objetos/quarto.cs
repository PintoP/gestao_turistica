﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao.Objetos
{
    [Serializable]
    public class Quarto
    {
        #region atributos
        private int n_quarto;
        private string tipo;
        private int status;//1-disponivel 2-indisponivel
        private double preco_diario;
        #endregion

        #region contrutor
        public Quarto(int n_quarto, string tipo, int status, double preco_diario)
        {
            this.n_quarto = n_quarto;
            this.tipo = tipo;
            this.status = status;
            this.preco_diario = preco_diario;
        }
        #endregion

        #region propriedades
        public int N_quarto
        {
            get { return n_quarto; }
            set { n_quarto = value; }
        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public int Status
        {
            get { return status; }
            set { status = value; }
        }
        public double Preco_diario
        {
            get { return preco_diario; }
            set { preco_diario = value; }
        }
        #endregion

        #region metodos
        #endregion
    }
}