//1151 - 
using System;
using System.Linq;

public class Program{
  public static void Main(){
    int a = int.Parse(Console.ReadLine());
    int[] b = new int[a];
    if (a>=1) b[0]=0;
    if (a>=2) {
      b[1]=1;
      for(int i = 2; i<a; i++){
        b[i] = b[i-2]+b[i-1];
      }
    }
    for(int i = 0; i<a; i++){
        Console.Write($"{b[i]}");
        if (i<a-1) Console.Write(' ');
      }
    Console.Write("\n");
  }
}