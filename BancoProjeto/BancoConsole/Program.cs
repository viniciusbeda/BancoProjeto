using System;
using BankLibrary.Models;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bem-vindo ao Banco .NET!");

        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite seu CPF: ");
        string cpf = Console.ReadLine();

        Cliente cliente = new Cliente(nome, cpf);
        ContaCorrente conta = new ContaCorrente(123456, 1000);

        Console.WriteLine("\nConta criada com sucesso!");
        cliente.ExibirDados();
        conta.ExibirSaldo();

        Console.Write("\nDigite o valor do saque(Não use o R$, digite apenas o valor desejado para o saque): ");
        decimal valorSaque = Convert.ToDecimal(Console.ReadLine());
        conta.Sacar(valorSaque);
        conta.ExibirSaldo();
    }
}
