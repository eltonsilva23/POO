// 1035 - Teste de Seleção 1
using System; 

public class Program {

  public static void Main(string[] args) {
    string s = Console.ReadLine();
    string[] v = s.Split(' ');
    int a = int.Parse(v[0]);
    int b = int.Parse(v[1]);
    int c = int.Parse(v[2]);
    int d = int.Parse(v[3]);
    if ((b > c) && (d > a) && ((c + d) > (a + b)) && (c > 0) && (d > 0) && (a % 2 == 0))
      Console.WriteLine("Valores aceitos");
    else {
      Console.WriteLine("Valores nao aceitos");
    }
  }
}