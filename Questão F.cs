using System;

class Program
{
    static void Main()
    {
        // Lê e exibe o número digitado
        Console.WriteLine("Digite um número decimal:");
 			    decimal numero = decimal.Parse(Console.ReadLine()); //Armazena o número como uma variável decimal       
       		 Console.WriteLine("O número digitado foi:" + numero); //Exibe a mensagem de qual numero digitado
       			 Console.WriteLine(Console.ReadLine());
    }
}
