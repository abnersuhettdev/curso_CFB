using System;

// usando Arrays em C#

class Aula17
{

    static void Main()
    {
        int[] n = new int[5];
        // int[] num = new int[3] { 55, 77, 22 };
        int[] num = { 55, 77, 22 }


        n[0] = 11;
        n[1] = 22;
        n[2] = 22;
        n[2] = 33;
        n[3] = 44;
        n[4] = 55;

        Console.WriteLine(num[2]);
    }

}


