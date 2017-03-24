using System;


namespace Banco.Contas
{
    internal class ContaCorrente : Conta, ITributavel
    {

        private static int totalDeContas = 0;

        public ContaCorrente()
        {
            ContaCorrente.totalDeContas++;

        }


        public override void Saca(double valor)
        {
            if (valor < 0.0)
            {
                throw new ArgumentException();
            }

            if (valor + 0.10 > this.Saldo)
            {
                throw new SaldoInsuficienteException("Valor do saque maior que o saldo");
            }

            this.Saldo -= (valor + 0.10);
        }

        public override void Deposita(double valor)
        {

            if (valor < 0.0)
            {
                throw new ArgumentException();
            }

            this.Saldo += valor;
        }

        public double CalculaTributos()
        {
            return this.Saldo * 0.05;
        }
    }
}