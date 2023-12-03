using System;
using System.Linq;
using LojaDeVeiculos;

namespace LojaDeVeiculos;

public static class Program {
	public static void Main() {	
	    
		Console.WriteLine("Dados da Compra\n");
		// ID
		Console.Write("Digite o ID: ");
		int id = Console.Read();
		// Modelo
		Console.Write("\nDigite o Modelo: ");
		string modelo = Console.ReadLine();
		// Preco
		Console.Write("Digite o preco: ");
		double preco = double.Parse(Console.ReadLine());
		
		Veiculos carro;
		Parcelas parcela = new Parcelas();
		
		Console.WriteLine("\nO pagamento vai ser: \n \n1 - A vista\n2 - Parcelado");

		//Opcao
		Console.Write("\nDigite a opcao: ");
		int opcao = int.Parse(Console.ReadLine());

		if (opcao == 1) {

			carro = new Veiculos(id, modelo, preco);
			
			Console.WriteLine();

			Console.WriteLine(carro.Tabela());

		} else if (opcao == 2) {	
		    Console.WriteLine("\n--------------------------\n");
			Console.WriteLine("\n  Tabela de Parcelas \n");
			Console.WriteLine(parcela.ExibirTabela());
			
			//parcelas
			Console.Write("\nDigite a quantidade de parcelas: ");
			int parcelas = int.Parse(Console.ReadLine());
			
			Console.WriteLine();
			
			carro = new Veiculos(id,modelo, preco, parcelas);
			
			Console.WriteLine("\n--------------------------\n");
			Console.WriteLine(carro.Tabela());

		} else {
			Console.WriteLine("\nOPCAO INVALIDA!");
		}
	}
}