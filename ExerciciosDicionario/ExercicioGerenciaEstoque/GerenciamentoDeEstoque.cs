using System;

class GerenciamentoDeEstoque
{
    Dictionary<string, int> itens = new Dictionary<string, int>();

    public void GerenciarEstoque()
    {
		Console.WriteLine($"{new string('-', 10)} Sistema de gerenciamento de estoque {new string('-', 10)}\t\n");

		Console.WriteLine("Ainda não há produtos cadastrados.\n");
		
        string opcao = Menu();

        while (opcao != "0")
        {
            switch (opcao)
            {
                case "0":
                    return;
                    break;
                case "1":
                    AdicionarItens();
                    opcao = Menu();
                    break;
                case "2":
                    foreach (var item in itens)
                    {
                        Console.WriteLine($"\n{item}");
                    }
                    opcao = Menu();
                    break;
                case "3":
                    Console.WriteLine("Qual produto deseja vender ?");
                    string produtoVenda = Console.ReadLine();
                    itens.Remove( produtoVenda );
                    if (itens.TryGetValue(produtoVenda, out int valor))
                    {
                        itens.Remove(produtoVenda);
                    }
                    opcao = Menu();
                    break;
                case "4":
                    Console.WriteLine("Digite o produto que está procurando:");
                    string procura = Console.ReadLine();
                    foreach (var item in itens)
                    {
                        if (itens.ContainsKey(procura))
                        {
                            Console.WriteLine("Produto encontrado");
                            Console.WriteLine(procura);
                        }
                        else
                        {
                            Console.WriteLine("Produto inexistente");
                        }
                    }
                    opcao = Menu();
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    opcao = Menu();
                    break;
            }
        }

    }


    public void AdicionarItens()
    {

        while (true)
        {

			string produto;
			int quantidade;

			DefineProdutos(out produto, out quantidade);

            itens.Add(produto, quantidade);

            string opcao = Opcao();

			if (opcao == "N")
            {
                return;
            }else if (opcao == "S")
            {
                DefineProdutos(out produto, out quantidade);

                itens.Add(produto, quantidade);

                opcao = Opcao();

				if (opcao == "N")
                {
                    return;
				}
                else
                {
                    continue;
                }

            }
			else if (opcao != "S" && opcao != "N")
            {
                while (opcao != "S" && opcao != "N")
                {
					Console.WriteLine("Opcão inválida.");
					opcao = Opcao();
					if (opcao == "N")
					{
						return;
					}

				}
            }
		}
	}

	public string Opcao()
	{
		Console.WriteLine("Deseja adicinar mais itens ? (S/N) ");
		string opcao = Console.ReadLine();
		opcao = opcao.ToUpper();

		return opcao;
	}

	public void DefineProdutos(out string produtoP, out int quantidadeQ)
	{
        Console.WriteLine("Adicione um produto a lista.\t\n");
        produtoP = Console.ReadLine();

        Console.WriteLine("Adicione a quantidade do produto.");
        quantidadeQ = int.Parse(Console.ReadLine());

    }

    public string Menu()
    {
        Console.WriteLine("\n"+@$"Escolha uma das opções:

Cadastrar produtos: 1
Listar produtos: 2
Vender um produto: 3
Encontrar produto: 4
Sair: 0" + "\n");

        string opcao = Console.ReadLine();
        return opcao;
    }


}