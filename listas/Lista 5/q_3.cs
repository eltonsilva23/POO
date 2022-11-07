//beecrowd | 1042 Sort Simples
using System;
using System.Linq;

public class Program {
  public static void Main(string[] args) {
    string[] s = Console.ReadLine().Split(' ');
    int[] num_1 = s.Select(int.Parse).ToArray();
    int[] num_2 = new int[num_1.Length];
    
    for (int i=0; i<num_2.Length; i++) {
      num_2[i] = num_1[i];
    }
    Array.Sort(num_1);
    for (int i=0; i<num_1.Length; i++) {
      Console.WriteLine(num_1[i]);
    }
    Console.WriteLine();
    for (int i=0; i<num_2.Length; i++) {
      Console.WriteLine(num_2[i]);
    }

  }
}