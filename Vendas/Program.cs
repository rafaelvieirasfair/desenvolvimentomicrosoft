using System;
using System.Collections.Generic;

namespace Vendas
{
	class Program
	{
		static void Main(string[] args)
		{

			int escolha;
			Cliente c = new Cliente();
			List<Cliente> clientes = new List<Cliente>();

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
			
				switch (escolha)
				{
					
					case 1:
						
						Console.WriteLine("-----LISTAR CLIENTES-----");
						Console.WriteLine("Digite o Nome:");
						c.Nome = Console.ReadLine();
						Console.WriteLine("Digite o Cpf:");
						c.Cpf = Console.ReadLine();

						clientes.Add(c);

						//mensagem de sucesso
						Console.WriteLine($"Cliente {c.Nome} de CPF: {c.Cpf} adicionado com sucesso.");
						
						break;
					case 2:
						// laco mostra todos os clientes
						foreach (Cliente cli in clientes )
                        {
							Console.WriteLine($"Cliente {c.Nome} de CPF: {c.Cpf}\n");
						}

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
