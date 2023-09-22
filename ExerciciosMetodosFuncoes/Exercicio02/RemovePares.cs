using System;

class RemovePares
{

    public void RemoverElementosPares(List<int> inteiros)
    {
        List<int> pares = inteiros.Where(inteiro => inteiro % 2 == 0).ToList();
        
        foreach (var par in pares)
        {
            Console.Write(par);
        }
    }
    
}