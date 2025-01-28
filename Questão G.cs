using System;

class Program
{
    static void Main()
    {
        // Lê o nome do usuário
        Console.WriteLine("Digite o seu nome:");
        string nome = Console.ReadLine();

        // Lê a idade do usuário
        Console.WriteLine("Digite a sua idade:");
        int idade;

        // Tenta converter a entrada para inteiro
        if (int.TryParse(Console.ReadLine(), out idade))
        {
            //Lê e reporta os dados digitados(nome e idade)
        	Console.WriteLine("Oi " + nome + ", a sua idade é " + idade + " anos.");
        }
        else
        {
           //Caso a idade digitada seja uma letra o programa da erro
        	Console.WriteLine("Idade incorreta, por favor, digite um número válido.");
        }

        Console.WriteLine("Aperte qualquer botão para fechar...");
        Console.ReadKey(); // Aguarda que o usuário pressione uma tecla
    }
}
