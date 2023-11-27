using System;

// usando Arrays em C#

class Aula19
{

    static void Main()
    {

        int[] num = new int[10];

        for (int i = 0; i < num.Length; i++)
        {
            num[i] = 0;


        }

        for (int i = 0; i < num.Length; i++)
        {
            Console.WriteLine("Valor de num na posição {0} : {1}", i, num[i]);
        }
    }

}


