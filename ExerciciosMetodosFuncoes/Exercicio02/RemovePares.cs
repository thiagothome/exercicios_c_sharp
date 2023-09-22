using System;

class RemovePares
{

    public void RemoverElementosPares(List<int> inteiros)
    {
        //Com LINQ
        List<int> impares = inteiros.Where(inteiro => inteiro % 2 != 0).ToList();
        
        foreach (var impar in impares)
        {
            Console.Write(impar+"\r\n");
        }
    }


    public void RemoverElementosPares2(List<int> inteiros)
    {
        //Com RemoveAll. Usado como ForEach do JS
        //Aqui a lista de inteiros ficará apenas com os números 
        inteiros.RemoveAll(numero => numero % 2 == 0);




        //Mostra a lista com os números ímpares
        foreach (var item in inteiros)
        {
            Console.WriteLine(item);
        }

        
    }

    public void RemoverElementosPares3(List<int> inteiros)
    {
        for (int i = 0; i < inteiros.Count; i++)
        {
            if (inteiros[i] % 2 == 0)
            {
                inteiros.RemoveAt(i);
            }
        }

        foreach (var item in inteiros)
        {
            Console.WriteLine(item);
        }
    }
    
}