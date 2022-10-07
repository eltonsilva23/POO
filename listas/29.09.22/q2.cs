using System; 

public class Program {

  public static void Main(string[] args) {
    Console.Write("Digite seu nome completo\n");
    string[] s =Console.ReadLine().Split();
    Console.WriteLine("Bem-vindo ao C#, " + s[0]);
  }
}