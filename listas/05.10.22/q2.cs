using System; 
using System.Linq;

public class Program {

  public static void Main(string[] args) {
    //Entradas
    int []v = Console.ReadLine().Split().Select(int.Parse).ToArray();
    
    //Formula
    int y = (((v[0]+v[1]) + Math.Abs(v[0]-v[1]))/2);
    int maior_final = (((y+v[2]) + Math.Abs(y-v[2]))/2);
    Console.WriteLine($"{maior_final} eh o maior");
  }
}