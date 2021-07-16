using System.Globalization;

namespace Encapsulation
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string nome)
        {
            Numero = numero;
            Titular = nome;
        }

        public ContaBancaria(int numero, string nome, double saldo) :this (numero, nome)
        {
            Deposito(saldo);
        }

        public void Deposito(double valorDeposito)
        {
            Saldo += valorDeposito;
        }

        public void Saque(double valorSaque)
        {
            Saldo -= valorSaque;
        }

        public override string ToString()
        {
            return "Conta: " + Numero + ", Titular: " + Titular + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
