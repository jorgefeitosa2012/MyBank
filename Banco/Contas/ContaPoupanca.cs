using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Contas
{
    public class ContaPoupanca : Conta, ITributavel
    {
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

            this.Saldo -= valor + 0.10;

        }

        public void CalculaRendimento()
        {
            // ...
        }

        public double CalculaTributos()
        {
            return this.Saldo * 0.02;
        }


        public override void Deposita(double valor)
        {

            if (valor < 0.0)
            {
                throw new ArgumentException();
            }

            this.Saldo += valor;
        }

    }
}
