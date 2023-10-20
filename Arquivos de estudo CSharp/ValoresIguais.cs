using System;
using System.Linq;

namespace Exercicio01;

public static class Program {

       public static void Main() {

              char[] array1 = new char[] { 'a', 'z', 'F', 'o', 'R'};
              char[] array2 = new char[] { 'F', 'g', 'e', 'a' ,'k'};

              char[] arrayRetornada = verificar(array1,array2);
              
              //Mostrar no console
              foreach(char letra in arrayRetornada){ 
                     
                     Console.WriteLine(letra);//Saida
                     
              }
       }
       
       //Metodo/Funcao
       public static char[] verificar(char[] array1, char[] array2) {

       char[] verificar = new char[5];
       int posicao =0;

       for (int x = 0; x < array1.Length; x++) {
              
              for (int y = 0; y < array2.Length; y++) {
                     
                     if (array1[x] == array2[y]) {    
                               
                            verificar[posicao++] = array1[x];
                     }
              }
       }
       
       return verificar;//Retorno
       }
}