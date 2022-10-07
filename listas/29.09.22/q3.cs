using System; 

public class Program {

  public static void Main(string[] args) {
    Console.Write("Digite a primeira nota da disciplina\n");
    int n1=int.Parse(Console.ReadLine());
    Console.Write("Digite a segunda nota da disciplina\n");
    int n2=int.Parse(Console.ReadLine());
    int p1=n1*2;
    int p2=n2*3;
    int soma=p1+p2;
    int media=soma/5;
    Console.WriteLine($"Media Parcial = {media}");
  }
}