using System;
using System.Linq;

public class Pais{
  
  private string nome = "Invalido";
  private int populacao = 1;
  private double area = 1;

  public Pais(){}
  
  public Pais(string n, int p, double area){
    if (n != " ") this.nome = n;
    if (p>0) this.populacao = p;
    if (area>0) this.area = area;    
  }
  
  public void SetNome(string nome){
   if (nome != " ") this.nome = nome;
  }
  public void SetPopulacao(int populacao){
   if (populacao>0) this.populacao = populacao;
  }
  public void SetArea(double area){
   if (area>0) this.area = area;
  }

  public string GetNome(){
    return nome;
  }
  public int GetPopulacao(){
    return populacao;
  }
  public double GetArea(){
    return area;
  }

  public double Densidade(){
    return (populacao / area);
  }

  public override string ToString(){
    string s_nome = "Nome do Pais = " + this.nome;
    string s_populacao = "Populacao = " + this.populacao;
    string s_area = "Area = " + this.area;
    return s_nome + "\n" + s_populacao + "\n" + s_area;
  }
}
public class Program  {
  public static void Main(){
    
    Pais p = new Pais();
    
    for (int i=0; i<10; i++){
      p.SetNome(Console.ReadLine());
      p.SetPopulacao(int.Parse(Console.ReadLine()));
      p.SetArea(double.Parse(Console.ReadLine()));
      
      Console.WriteLine(p.ToString());
      Console.WriteLine("----------------");
      Console.WriteLine($"Densidade = {p.Densidade()}\n-----");
    }
  }
}