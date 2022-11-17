using System;
using System.Linq;

//Variaveis = atributos
//objeto = conjjunto de caracteristicas
//metodo = funções dentro de classes
//Ex: Áreas, perímetros (fórmulas)

// vizibilidade - class - Nome (Identificador)

public class Triangulo{
  double base1; //atributo
  double altura; // atributo
  //(base1 * altura) / 2
  
  double CalcArea(){ //Metodo// OBRIGATÓRIO a {}
    return (base1 * altura) / 2;
  }
  
}
public class Program{
  public static void Main(){
    // nome da classe - nome de variavel - new(instancia) - classe 
    Triangulo t = new Triangulo();
    t.base1 = double.Parse(Console.ReadLine("Digite a base:\n"));
    t.altura = double.Parse(Console.ReadLine("Digite a altura:\n"));
    
    Console.WriteLine(t.base1);
    Console.WriteLine(t.altura);
    
  }
}