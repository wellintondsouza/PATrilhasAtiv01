using System;

class Program
{
    static void Main()
    {
        //Lê a palavra digitada
        Console.WriteLine("Digite uma palavra:");
        string palavra = Console.ReadLine();

Console.WriteLine("A quantidade de lestras na palavra é: " + palavra.Length + "letras");

	Console.WriteLine("Aperte qualquer tecla para fechar o programa...");
	Console.ReadLine();
   
    }
}
