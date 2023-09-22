using System;

class Program
{
    
    public static void Main(string[] args)
    {
        RemovePares ex = new RemovePares();

        List<int> numeros = new List<int> {1,2,3,4,5,6,7,8,9};

        ex.RemoverElementosPares3(numeros);
    }

}