using System;
using System.Globalization;


namespace SomaImpares;

public static class Program
{
	public static void Main() {
		int i,
		n1,
		n3,
		n2,
		soma;



		Console.Write("Digite um numero : ");
		n1 = int.Parse(Console.ReadLine());

		Console.Write("Digite um numero : ");
		n2 = int.Parse(Console.ReadLine());

		if (n1 > n2) {

			n3 = n1;
			n1 = n2;,
			n2 = n3;
		}

		soma = 0;

		for (i = n1 + 1; i <= n2 - 1; i++) {
			if (i%2 != 0) {
				soma = soma + i;
			}

		}
		Console.WriteLine("A SOMA: " + soma);


	}
}