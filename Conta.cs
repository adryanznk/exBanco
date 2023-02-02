using System;
using System.Collections.Generic;
using System.Text;

namespace AtividadeBancoAula12
{
    class Conta
    {
        public string Nome;
        public int NumConta;
        private double Saldo;


        public Conta (string nome, int numConta, double saldo0)
        {
            Nome = nome;
            NumConta = numConta;
            Saldo = saldo0;
        }


        public void Saque(double saque)
        {
            Saldo = Saldo - saque - 5;  //5 é taxa
        }

        public void Deposito(double deposito)
        {
            Saldo = Saldo + deposito;
        }

        public double GetSaldo()
        {
            return Saldo;
        }

        public string Dados()
        {
            return ("\nDADOS DA CONTA\nNúmero da conta: " + NumConta + "\nTitular: " + Nome + "\nSaldo atual: " + Saldo + "\n");
        }
    }
}
