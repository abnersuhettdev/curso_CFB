using System;

// ENUMS & CASTINGS

class Aula10
{

    enum DiasSemana
    {
        Domingo, Segunda, Terca, Quarta, Quinta, Sexta, Sabado
    };
    static void Main()
    {

        int ds = (int)DiasSemana.Sexta;

        Console.WriteLine(ds);
    }

}
