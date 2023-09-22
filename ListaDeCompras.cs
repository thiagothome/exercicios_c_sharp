using System;

class ListaDeCompras
{
    

    public void MinhaListaDeCompras()
    {
        List<string> itensLista = new List<string>();

        Console.WriteLine(new string('-', 10)+" Lista de compras "+new string('-', 10));

        string produto = "";
        while (true)
        {
            Console.WriteLine(@"Escolha uma opção:
Adicionar item: 1
Remover item: 2
Listar itens: 3
Sair do menu: 0"+"\n");
            string opcao = Console.ReadLine();
            if (opcao == "1")
            {   
                Console.WriteLine("\nQual produto gostaria de adicionar na lista ?\n");
                produto = Console.ReadLine();
                itensLista.Add(produto);
                Console.WriteLine("\nProduto adicionado com sucesso!\n");

            }else if (opcao == "2")
            {
                if (itensLista.Count > 0)
                {
                    foreach (var item in itensLista)
                    {
                        Console.WriteLine(item);
                    }
                }
                Console.WriteLine("\nEscreva o nome produto gostaria de remover ?\n");
                produto = Console.ReadLine();
                if (itensLista.Contains(produto))
                {
                    itensLista.Remove(produto);
                    Console.WriteLine("\nProduto removido com sucesso\n");

                }else
                {
                    Console.WriteLine("\nProduto inexistente.\n");
                }
            }else if (opcao == "3")
            {
                Console.WriteLine("\nItens da lista:");
               if (itensLista.Count > 0)
                {
                    foreach (var item in itensLista)
                    {
                        Console.WriteLine(item);
                    }
                }else
                {
                    Console.WriteLine("A lista ainda não tem produtos\n");
                }
            }else
            {
                return;
            }

        }
    }

}
