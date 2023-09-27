using System;
using System.Globalization;

namespace HelloWold;

public static class Program {
	   public static void Main() {

CultureInfo CI= CultureInfo.InvariantCulture;
			  double Base,Raiz, Altura, Area, Diagonal, Perimetro;

			  Console.Write("Base do Retangulo: ");
			  Base = double.Parse(Console.ReadLine(),CI);

			  Console.Write("Altura do Retangulo: ");
			  Altura = double.Parse(Console.ReadLine(),CI);
                       
                       Area =  Base * Altura;
                       Perimetro = 2 * (Base + Altura);
                       Raiz = Math.Pow(Base,2)+Math.Pow(Altura,2);
                       Diagonal= Math.Sqrt(Raiz);
                       
                       Console.WriteLine();
                       
                       Console.WriteLine("AREA = "+ Area.ToString("F4",CI));
                       Console.WriteLine("PERIMETRO = "+ Perimetro.ToString("F4",CI));
                       Console.WriteLine("Diagonal = "+ Diagonal.ToString("F4",CI));
                       

	   }
}