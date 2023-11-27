using System;

class Aula22
{

    static void Main()
    {

        int[] numArray = new int[3] { 11, 22, 33 };

        // for (int i = 0; i < numArray.Length; i++)
        // {
        //     Console.WriteLine(numArray[i]);
        // }

        foreach (int n in numArray)
        {
            Console.WriteLine(n);
        }
    }

}


