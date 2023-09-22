using System;
using System.Collections.Generic;

class MesclaLista
{
    public List<string> MesclarLista(List<string> lista1, List<string> lista2)
    {
        List<string> listaMesclada = new List<string>();

        listaMesclada.AddRange(lista1); // Adiciona elementos de lista1
        listaMesclada.AddRange(lista2); // Adiciona elementos de lista2

        listaMesclada.Sort(); // Ordena a listaMesclada

     
        return listaMesclada;
    }
}