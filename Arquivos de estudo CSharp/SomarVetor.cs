using System;
using System.Linq;
using CSharpShellCore;

namespace MeusEstudos;

public static class Program {

       public static void Main() {

              int n, i, soma;
              double media;


              Console.Write("Quantos numeros voce vai digitar? ");
              n = int.Parse(Console.ReadLine());

              int[] vetor = new int[n];//Vetor (Array)
              soma = 0;
              
              for (i = 0; i < n; i++) {
                     Console.Write("Digite o elemento [" + i + "] : ");
                     vetor[i] = int.Parse(Console.ReadLine());
                     soma = soma + vetor[i];
              }
              
              Console.WriteLine("VALORES= ");
              
              for (i = 0; i < n; i++) {

                     Console.Write(vetor[i] + " ");
              }
              
              Console.WriteLine();//Quebra de Linha
              
              Console.WriteLine("SOMA = " + soma);
              media = soma / n;

              Console.WriteLine("MEDIA = " + media);
       }


}
