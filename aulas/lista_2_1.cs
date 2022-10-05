using System; 

public class Program {

  public static void Main(string[] args) {
    Console.Write("Digite seu primeiro nome\n");
    string s =Console.ReadLine();
    s = s.remove(s.IndexOf(' '))
    Console.WriteLine("Bem-vindo ao C#, " + s);
  }
}