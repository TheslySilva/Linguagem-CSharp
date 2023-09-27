using System;

namespace HelloWold;

public static class Program {
	public static void Main() {
//Variaveis
		int n1,
		n2,
		n3,
		resultado;
//Entrada
		Console.Write("Digite um numero : ");
		n1 = int.Parse(Console.ReadLine());
		Console.Write("Digite outro numero : ");
		n2 = int.Parse(Console.ReadLine());
		Console.Write("Digite outro numero : ");
		n3 = int.Parse(Console.ReadLine());
//Condicoes
		if (n1 < n2 && n1 < n3) {

			resultado = n1;
		} else if (n2 < n1 && n2 < n3) {

			resultado = n2;
		} else {

			resultado = n3;
		}
//Saida
		Console.WriteLine("\nO menor numero é : "+ resultado);
	}
}