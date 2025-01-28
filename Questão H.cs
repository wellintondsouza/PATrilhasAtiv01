using System;

class Program
{
    static void Main()
    {
        // Lê o preço do produto
        Console.WriteLine("Digite o preço do produto:");
        double preco = double.Parse(Console.ReadLine());

        // Lê o desconto em porcentagem
        Console.WriteLine("Digite o desconto em porcentagem:");
        double desconto = double.Parse(Console.ReadLine());

        // Calcula o preço final
        double precoFinal = preco - (preco * (desconto / 100));

        // Exibe o preço final
        Console.WriteLine("O preço final com desconto é: " + precoFinal.ToString("F2"));

        Console.WriteLine("Aperte qualquer botão para fechar...");
        Console.ReadKey(); // Aguarda que o usuário pressione uma tecla
    }
}
