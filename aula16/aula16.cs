using System;
class Aula16calcgoto
{
    static void Main()
    {

        float n1 = 0;
        float n2 = 0;
        char op;
        char esc;

    inicio:
        Console.Clear();

        Console.Write("\nDigite o primeiro numero: ");
        n1 = int.Parse(Console.ReadLine());

        Console.Write("\nDigite o Segunto numero: ");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("=========Escolha a Operação==========");
        Console.WriteLine("D - Divisão");
        Console.WriteLine("M - Multiplicação");
        Console.WriteLine("S - Soma");
        Console.WriteLine("X - Subtração");
        Console.WriteLine("=====================================");
        op = char.Parse(Console.ReadLine());

        switch (op)
        {
            case 'd':
            case 'D':
                Console.Write("A divisão entre {0} por {1} será {2}", n1, n2, (n1 / n2));
                break;

            case 'm':
            case 'M':
                Console.Write("O produto entre {0} e {1} será {2}", n1, n2, (n1 * n2));
                break;

            case 's':
            case 'S':
                Console.Write("A soma entre {0} e {1} será {2}", n1, n2, (n1 + n2));
                break;

            case 'x':
            case 'X':
                Console.Write("A subtração entre {0} e {1} será {2}", n1, n2, (n1 - n2));
                break;

            default:
                Console.Write("Operação invalida, tente novamente!");
                break;
        }

        Console.Write("\nDeseja calcular novamente? [Sim/Não]: ");
        esc = char.Parse(Console.ReadLine());

        if (esc == 's' || esc == 'S')
        {
            Console.Clear();
            goto inicio;
        }
        else
        {
            Console.Clear();
            Console.Write("Programa finalizado");
        }

    }
}