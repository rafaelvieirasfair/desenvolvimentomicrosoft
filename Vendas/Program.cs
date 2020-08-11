using System;

namespace Vendas
{
	class Program
	{
		static void Main(string[] args)
		{

			int escolha;
			do
			{
				// Opcoes do menu
				Console.WriteLine("Escolha uma das Opcoes abaixo:\n");
				Console.WriteLine("1 – Cadastrar de Cliente");
				Console.WriteLine("2 – Listar de Clientes");
				Console.WriteLine("3 – Cadastrar de Vendedor");
				Console.WriteLine("4 – Listar de Vendedores");
				Console.WriteLine("5 – Cadastrar de Produto");
				Console.WriteLine("6 – Listar de Produtos");
				Console.WriteLine("7 – Registrar Venda ");
				Console.WriteLine("8 – Listar Vendas ");
				Console.WriteLine("9 – Listar Vendas por Cliente");
				Console.WriteLine("0 – Sair\n");

				// recebe a opcao escolhida
				escolha = Convert.ToInt32(Console.ReadLine());
				Cliente c = new Cliente();
				//criar lista 

				switch (escolha)
				{
					
					case 1:
						
						Console.WriteLine("-----LISTAR CLIENTES-----");
						Console.WriteLine("Digite o Nome:");
						c.Nome = Console.ReadLine();
						Console.WriteLine("Digite o Cpf:");
						c.Cpf = Console.ReadLine();

						//mensagem de sucesso
						Console.WriteLine(c.Nome);
						Console.WriteLine(c.Cpf);
						break;
					case 2:
						// laco mostra todos os clientes
					break;

					case 3:

					break;
					case 4:

					break;
					case 5:

					break;
					case 6:

					break;
					case 7:

					break;
					case 8:

					break;
					case 9:

					break;
					
					default:
						if (escolha != 0)
                        {
							Console.WriteLine("Numero {0} Invalido\n", escolha);
						}
					break;
				}
			} while (escolha != 0); // botao para sair
		}
	}
}
