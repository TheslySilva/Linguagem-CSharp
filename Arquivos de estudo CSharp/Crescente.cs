using System;
using System.Globalization;
using CSharpShellCore;

namespace HelloWold;

public static class Program
{
       public static void Main()
       {
              int i, n1, n2;

              do{

                     Console.Write("Digite um numero : ");
                     n1 = int.Parse(Console.ReadLine());

                     Console.Write("Digite um numero : ");
                     n2 = int.Parse(Console.ReadLine());
                     
                     if(n1>n2){
                            Console.WriteLine("DECRESCENTE!");
                     }else if(n1<n2){
                            Console.WriteLine("CRESCENTE!");
                     }

              } while (n1!=n2);
              
       }
}