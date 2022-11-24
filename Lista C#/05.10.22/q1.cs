using System; 

public class Program {

  public static void Main(string[] args) {
    //Entradas
    string s = Console.ReadLine();
    double salario = double.Parse(Console.ReadLine());
    double vendas = double.Parse(Console.ReadLine());
    //Calculos
    double comissao = 0.15*vendas;
    double total = salario+comissao;
    //Imprimir
    Console.WriteLine($"TOTAL = R$ {total:f2}");
  }
}