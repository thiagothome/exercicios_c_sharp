using System;

class GerenciamentoDeEstoque
{
    
    public void GerenciarEstoque()
    {
        Dictionary<string, int> itens = AdicionarItens();
        Console.WriteLine("Obrigado por utilizar nossos serviços!");
		foreach (var item in itens)
		{
			Console.WriteLine($"{item.Key}:{item.Value}");
		}


	}


    public Dictionary<string, int> AdicionarItens()
    {
        Dictionary<string, int> itens = new Dictionary<string, int>();

        
        while (true)
        {

			Console.WriteLine("Adicione um produto a lista.");
			string produto = Console.ReadLine();

			Console.WriteLine("Adicione a quantidade do produto.");
			int quantidade = int.Parse(Console.ReadLine());
			
            itens.Add(produto, quantidade);

			string opcao = Opcao();

			if (opcao == "N")
            {
                return itens;
            }else if (opcao == "S")
            {
				Console.WriteLine("Adicione um produto a lista.");
				produto = Console.ReadLine();

				Console.WriteLine("Adicione a quantidade do produto.");
				quantidade = int.Parse(Console.ReadLine());

				itens.Add(produto, quantidade);

				opcao = Opcao();

				if (opcao == "N")
                {
                    return itens;
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
						return itens;
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

}