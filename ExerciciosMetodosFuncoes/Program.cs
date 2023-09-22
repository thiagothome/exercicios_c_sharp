using System;

class Program
{
    
    public static void Main(string[] args)
    {
        CalculaMedia ex1 = new CalculaMedia();

        List<int> lista = new List<int> {1,2,3};
        double media;
        ex1.CalcularMedia(lista, out media);
        Console.WriteLine(media);
    }

}