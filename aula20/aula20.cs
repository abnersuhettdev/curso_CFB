using System;

// usando Arrays em C#

class Aula20
{

    static void Main()
    {

        int[] num = new int[10];

        int i = 0;
        while (i < num.Length)
        {
            Console.WriteLine("Valor de num na posição {0} : {1}", i, num[i]);
            i++;

        }


    }

}


