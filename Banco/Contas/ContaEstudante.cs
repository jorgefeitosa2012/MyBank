using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Contas
{
    internal class ContaEstudante : Conta
    {
        public override void Saca(double valor)
        {

            if (valor < 0.0)
            {
                throw new ArgumentException();
            }

            if (valor  > this.Saldo)
            {
                throw new SaldoInsuficienteException("Valor do saque maior que o saldo");
            }

            this.Saldo -= valor;
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
