using System;

// Lendo valores do teclado

class Aula08
{
    static void Main()
    {
        int v1, v2, soma;
        string nome;

        // Console.Write("Digite seu nome: ");
        // nome = Console.ReadLine();
        // Console.Write("Nome digitado: nome ");

        Console.Write("Digite o primeiro valor: ");
        v1 = int.Parse(Console.ReadLine());  // CONVERTENDO STRING PARA INT
        Console.Write("Digite o segundo valor: ");
        v2 = Convert.ToInt32(Console.ReadLine()); //CONVERTENDO STRING PARA INT
        soma = v1 + v2;
        Console.Write("A soma de {0} mais {1} é igual a {2} ", v1, v2, soma);


    }

}
