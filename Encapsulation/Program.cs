using System;
using System.Globalization;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string nome;
            char resposta;
            double depositoInicial, deposito, saque;

            ContaBancaria conta;
            

            Console.Write("Entre o número da conta:");
            numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta:");
            nome = Console.ReadLine();

            Console.Write("Haverá saldo inicial? (s/n)");
            resposta = char.Parse(Console.ReadLine());

            if (resposta == 's' || resposta == 'S' )
            {
                Console.Write("Entre o valor do depósito inicial:");
                depositoInicial = double.Parse(Console.ReadLine());
                conta = new ContaBancaria(numero, nome, depositoInicial);
            }
            else
                conta = new ContaBancaria(numero, nome);

            Console.WriteLine();
            Console.WriteLine("Dados da Conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre o valor do depósito:");
            deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito);

            Console.WriteLine();
            Console.WriteLine("Dados da Conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre o valor do saque:");
            saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);

            Console.WriteLine();
            Console.WriteLine("Dados da Conta atualizados:");
            Console.Write(conta);
        }
    }
}
