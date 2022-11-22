using System;
using System.Linq;

//Variaveis = atributos
//objeto = conjjunto de caracteristicas
//metodo = funções dentro de classes
//Ex: Áreas, perímetros (fórmulas)

// vizibilidade - class - Nome (Identificador)

public class Triangulo{
  private double base1 = 1; //atributo
  private double altura = 1; // atributo
  //(base1 * altura) / 2

  public Triangulo(){}//Construtpr 1 
  
  //Construtor 2 (com parametros)
  public Triangulo(double base1, double altura){
    if (base1>0) this.base1 = base1;
    if (altura>0) this.altura = altura;    
  }
  
  public double CalcArea(){ //Metodo (Função)// OBRIGATÓRIO a {}
    return (base1 * altura) / 2;
  }

   public void SetBase1(double x){
    if (x>0) base1 = x;
  }
  public void SetAltura(double y){
    if (y>0) altura = y;
  }

   public double GetBase1(){
    return base1;
  }
  public double GetAltura(){
    return altura;
  }

  public override string ToString(){
    return $"Base = {base1}\nAltura = {altura}";
  }
  
}
public class Program{
  public static void Main(){
    // nome da classe - nome de variavel - new(instancia) - classe 
    Triangulo t = new Triangulo();
    Triangulo construtor = new Triangulo(15,18);
    
    t.SetBase1(double.Parse(Console.ReadLine()));
    t.SetAltura(double.Parse(Console.ReadLine()));
    //Sempre chamar a variavel(t.------)
    Console.WriteLine($"{t.CalcArea()}\n--------"); 
    
    Console.WriteLine($"{construtor.CalcArea()}\n---------");    
    
    Console.WriteLine(t.ToString());
    Console.WriteLine("----------------");
    Console.WriteLine(construtor.ToString());
  }
}