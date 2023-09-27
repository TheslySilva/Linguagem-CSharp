using System;
using System.Globalization;
using CSharpShellCore;

namespace HelloWold;

public static class Program{
       public static void Main(){
              
              int n1,n2,n3,resultado;
              
              Console.Write("Digite um numero : ");
              n1= int.Parse(Console.ReadLine());
              Console.Write("Digite outro numero : ");
              n2= int.Parse(Console.ReadLine());
              Console.Write("Digite outro numero : ");
              n3= int.Parse(Console.ReadLine());
              
              if(n1<n2 && n1<n3){
                   
                  resultado= n1; 
              }else if(n2<n1 && n2<n3){
                    
                    resultado=n2;
              }else{
                     
                   resultado= n3;
              }
              
              Console.WriteLine("\nO menor numero é : "+ resultado);
       }
}