using System;
using System.Linq;

public class Program {
  public static void Main() {
    Disciplina poo = new Disciplina();
    poo.n1 = 5;
    poo.n2 = 6;
    poo.n3 = 7;
    double x = poo.CalcMedia();
    Console.WriteLine(x);

  }
}

class Disciplina {
  public int n1, n2, n3;
  private int media;
  public double CalcMedia() {
    media = (n1 + n2 + n3)/3;
    return media;
  }
}