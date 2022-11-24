//2456 - Cartas
using System;
using System.Linq;

public class Program {
  public static void Main () {
    string[] s = Console.ReadLine().Split(' ');
    int[] c = s.Select(int.Parse).ToArray();
    if (c[0]<c[1] && c[1]<c[2] && c[2]<c[3] && c[3]<c[4]) Console.WriteLine("C");
    else if (c[0]>c[1] && c[1]>c[2] && c[2]>c[3] && c[3]>c[4]) Console.WriteLine("D");
    else
      Console.WriteLine("N");
  }
}