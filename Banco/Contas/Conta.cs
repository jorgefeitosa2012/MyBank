using System;

namespace Banco.Contas
{
    public abstract class Conta
    {
        private static int numeroDeContas;
        public int Numero { get; set; }
        public double Saldo { get; protected set; }
        public Cliente Titular { get; set; }

        public Conta()
        {
            Conta.numeroDeContas++;
            this.Numero = Conta.numeroDeContas;
        }

        public enum Tipo
        {
            Corrente,
            Estudante,
            Poupanca
        };


        public abstract void Saca(double valor);

        public abstract void Deposita(double valor);

        public static int ProximaConta()
        {
            return ContaCorrente.numeroDeContas + 1;
        }

        public override string ToString()
        {
            return "titular: " + this.Titular.Nome;
        }

    }
}