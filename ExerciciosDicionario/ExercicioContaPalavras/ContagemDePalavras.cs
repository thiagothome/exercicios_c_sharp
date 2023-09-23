using System;

class ContagemDePalavras
{

    public void ContadorDePalavras(string frase)
    {
        string[] fraseFatiada = frase.Split(' ');

        Dictionary<string, int> contadorPalavras = new Dictionary<string, int>();


        for (int i = 0; i < fraseFatiada.Length; i++)
        {

            if (contadorPalavras.ContainsKey(fraseFatiada[i]))
            {
                contadorPalavras[fraseFatiada[i]] += 1;
            }
            else
            {
                contadorPalavras[fraseFatiada[i]] = 1;
            }
        }

        foreach (var par in contadorPalavras)
        {
            Console.WriteLine($"A palavra {par.Key} aparece {par.Value} vezes.");
        }

    }

}