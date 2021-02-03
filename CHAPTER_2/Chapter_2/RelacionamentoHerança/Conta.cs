using System;
using System.Collections.Generic;
using System.Text;

namespace RelacionamentoHerança
{
    class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public double Saque(double valorSaque)
        {
            return Saldo - valorSaque;
        }
        public double Deposito(double valorDeposito)
        {
            return Saldo + valorDeposito;
        }
    }
}
