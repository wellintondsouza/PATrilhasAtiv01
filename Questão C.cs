using System;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite um número de ponto flutuante:"); //Permite o usário digitar um numéro
        string input = Console.ReadLine();
        float numero;

        // Tenta converter a entrada para um número de ponto flutuante
        if (float.TryParse(input, out numero)) //Faz a conversão de uma variável string para uma variável do tipo float 
        {
            Console.WriteLine("O número digitado foi: " + numero);
        }
        else //Caso o número digitado não puder ser convertido, a seguinte mensagem aparecerá
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número de ponto flutuante.");
        }

        Console.WriteLine("Aperte qualquer botão para fechar...");
        Console.ReadKey();
    }
}
