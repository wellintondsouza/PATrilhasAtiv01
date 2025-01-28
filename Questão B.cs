using System;

class Program
{
    static void Main()
    {
        // Lê e exibe o número digitado
        Console.WriteLine("Digite um número Real:");
 			double numero = double.Parse(Console.ReadLine()); //Armazena o número como uma variável Real       
       		 Console.WriteLine("O número digitado foi:" + numero); //Exibe a mensagem de qual numero foi digitado
       			 Console.WriteLine("Aperte qualquer botão para fechar...");
       			 Console.ReadKey();
       			
    }
}
