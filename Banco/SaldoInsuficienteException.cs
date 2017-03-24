using System;

namespace Banco
{
    class SaldoInsuficienteException : Exception
    {

        public SaldoInsuficienteException(string message) : base(message)
        {
        }
    }
}
