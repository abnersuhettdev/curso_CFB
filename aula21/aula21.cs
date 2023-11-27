using System;

// usando Arrays em C#

class Aula20
{

    static void Main()
    {

        string senha = "123";
        string senhaTeste;
        int tentativas = 0;


        do
        {

            Console.WriteLine("Digite uma senha:");
            senhaTeste = Console.ReadLine();
            tentativas++;


            if (senhaTeste == senha)
            {
                Console.WriteLine("Senha correta!");
                Console.WriteLine("Numero de tentaivas = {0}", tentativas);
                break;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");

            }


        } while (senha != senhaTeste);


    }

}


