//1221 - Primo Fácil
using System;
using System.Linq;

public class Program{
  public static void Main(){
    int qtd = int.Parse(Console.ReadLine());
    int c = 0;
    for (int i = 0; i<qtd; i++){
      int n = int.Parse(Console.ReadLine());
      c = 0;
      int raiz = (int) Math.Sqrt(n) + 1;
      for (int j = 2; j<raiz; j++){
          if (n%j==0) {
            c += 1;
            break;
          }
      }
          if (c==0)
            Console.WriteLine("Prime");
          else
            Console.WriteLine("Not Prime");
    }  
  }
}