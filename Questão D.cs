using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite 'sim' ou 'não':");
        string input = Console.ReadLine().ToLower(); // Lê a entrada e converte para minúsculas

        // Declara uma variável booleana
        bool resposta;

        // Verifica a entrada e atribui o valor correspondente à variável booleana
        if (input == "sim")
        {
            resposta = true;
        }
        else if (input == "não")
        {
            resposta = false;
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, digite 'sim' ou 'não'.");
            return; // Encerra o programa se a entrada for inválida
        }

        // Exibe o valor da variável booleana
        Console.WriteLine("A resposta digitada foi: " + resposta);
        Console.WriteLine("Aperte qualquer botão para fechar...");
        Console.ReadKey(); // Aguarda que o usuário pressione uma tecla
    }
}
