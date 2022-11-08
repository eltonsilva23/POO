using System; 
using System.Linq; 

public class Program {

  public static void Main(string[] args) {
    
    Console.Write("Digite o intervalo de tempo no formato “HH:MM:SS”\n");
    //Transformando o horario digitado para segundos
    string[] s =Console.ReadLine().Split(':');
    long[] segundos = s.Select(long.Parse).ToArray();
    long s1 = segundos[0]*3600;
    long s2 = segundos[1]*60;
    long t = s1+s2+segundos[2];
    //Calculo da Distancia
    long distancia = 300000*t;
    //Imprimindo resultado
    Console.WriteLine($"A luz percorreu {distancia} km nesse intervalo");
  }
}