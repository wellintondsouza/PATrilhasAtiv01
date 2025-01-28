using System;

class Program
{
    static void Main()
    {
        // Solicita as informações do endereço
        Console.WriteLine("Digite o número da casa:");
        string numeroCasa = Console.ReadLine();

        Console.WriteLine("Digite o nome da rua:");
        string rua = Console.ReadLine();

        Console.WriteLine("Digite o nome do bairro:");
        string bairro = Console.ReadLine();

        Console.WriteLine("Digite o nome da cidade:");
        string cidade = Console.ReadLine();

        Console.WriteLine("Digite o estado:");
        string estado = Console.ReadLine();

        // Exibe o endereço completo em uma única linha
        Console.WriteLine("Endereço completo:"+rua+", Nº "+numeroCasa+", "+bairro+" "+cidade+", "+estado);

        Console.WriteLine("Aperte qualquer tecla para fechar.");
        Console.ReadKey();
    }
}
