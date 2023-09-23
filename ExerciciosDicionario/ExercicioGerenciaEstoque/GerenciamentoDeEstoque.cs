using System;

class GerenciamentoDeEstoque
{
    
    public void GerenciarEstoque()
    {
        Dictionary<string, int> itens = AdicionarItens();
        Console.WriteLine("Obrigado por utilizar nossos servi�os!");
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

            Console.WriteLine("Deseja adicinaro mais itens ? (S/N) ");
            string opcao = Console.ReadLine();
            opcao = opcao.ToUpper();

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

				Console.WriteLine("Deseja adicinaro mais itens ? (S/N) ");
				opcao = Console.ReadLine();
				opcao = opcao.ToUpper();

				if (opcao == "N")
                {
                    return itens;
				}

			}
			else if (opcao != "S" && opcao != "N")
            {
                while (opcao != "S" && opcao != "N")
                {
					Console.WriteLine("Opc�o inv�lida.");
					Console.WriteLine("Deseja adicinaro mais itens ? (S/N) ");
					opcao = Console.ReadLine();
					opcao = opcao.ToUpper();

				}
                return itens;
            }



		}
		




	}

}