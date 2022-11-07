using System;
using System.Linq;

public class Program {
  public static void Main(){
    string[] s1 = Console.ReadLine().Split();
    int[] n1 = s1.Select(int.Parse).ToArray();
    string[] s2 = Console.ReadLine().Split(' ');
    int[] n2 = s2.Select(int.Parse).ToArray();
    int acertos = 0;
    string[] r = {"azar","azar","azar","terno","quadra","quina","sena"};
    
    for (int i = 0; i<6; i++){
      for (int j = 0; j<6; j++){
        if (n1[i]==n2[j]){
          acertos+=1;
          break;
        }
      }
    }
    string resultado = r[acertos];
    Console.WriteLine(resultado);
  }
}