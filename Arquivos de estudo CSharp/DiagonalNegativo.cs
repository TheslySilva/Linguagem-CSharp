using System;
using System.Linq;
using CSharpShellCore;

namespace MeusEstudos;

public static class Program {

       public static void Main() {

              int o, l, q, c;

              Console.Write("Digite a ordem da matriz: ");
              o = int.Parse(Console.ReadLine());

              int[,] matriz = new int[o, o];
              q = 0;

              for (l = 0; l < o; l++) {
                     for (c = 0; c < o; c++) {

                            Console.Write("Digite o elemento [" + l + "," + c + "]: ");
                            matriz[l, c] = int.Parse(Console.ReadLine());

                            if (matriz[l, c] < 0) {
                                   q++;
                            }
                     }
              }

              Console.WriteLine("\nDIAGONAL PRINCIPAL:");


              for (l = 0; l < o; l++) {

                     Console.Write(matriz[l, l]+" ");
              }
              Console.WriteLine("\nQuantidade de numeros negativos = "+q);
       }
}

