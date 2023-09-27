using System;
using System.Globalization;

namespace HelloWold;

public static class Program
{
       public static void Main()
       {

              CultureInfo CI = CultureInfo.InvariantCulture;
              
              string nome1,nome2;
              int idade1,idade2;
              
              Console.Write("Digite o nome da 1° pessoa: ");
              nome1= Console.ReadLine();
              Console.Write("Digite a idade da 1° pessoa: ");
              idade1= int.Parse(Console.ReadLine());
              
              Console.WriteLine();
              
              Console.Write("Digite o nome da 2° pessoa: ");
              nome2= Console.ReadLine();
              Console.Write("Digite a idade da 2° pessoa: ");
              idade2= int.Parse(Console.ReadLine());
              
              double media= (double)(idade1+idade2)/2;
              
              Console.WriteLine();
              Console.WriteLine("A media de "+ nome1+" e "+ nome2+" é de = "+ media.ToString("F1",CI)+ " anos");

       }
}