using System;

class CalculaMedia
{
    
    public double CalcularMedia(List<int> numeros, out double media)
    {

        int soma = 0;
        foreach (var numero in numeros)
        {
            soma += numero;
        }

        media = soma / numeros.Count;
        return media;
    }

}