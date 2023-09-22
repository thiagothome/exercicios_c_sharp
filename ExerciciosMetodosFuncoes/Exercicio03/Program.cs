using System;

class Program
{
    public static void Main(string[] args)
    {
        MesclaLista ex = new MesclaLista();

        List<string> nomes = new List<string> { "thiago", "João" };
        List<string> nomes2 = new List<string> { "Adriana", "Maria" };

        List<string> lista = ex.MesclarLista(nomes, nomes2);

        foreach (string item in lista)
        {
            Console.WriteLine(item);
        }
    }
}
