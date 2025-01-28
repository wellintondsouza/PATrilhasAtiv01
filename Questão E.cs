using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite um caractere (apenas letras):");
        string input = Console.ReadLine();

        // Verifica se a entrada é uma letra e tem exatamente um caractere
        if (input.Length == 1 && char.IsLetter(input[0]))
            Console.WriteLine("O caractere digitado foi: " + input[0]);
        else
            Console.WriteLine("Entrada inválida. Digite apenas uma letra.");

        Console.ReadKey(); // Aguarda que o usuário pressione uma tecla
    }
}
