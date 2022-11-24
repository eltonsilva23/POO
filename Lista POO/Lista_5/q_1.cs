using System;

public class Paciente{
  private string nome;
  private string cpf;
  private string telefone;
  private DateTime nascimento;

  public Paciente() {}

  //Construtor
  public Paciente(string n, string c, string t, DateTime nasc) {
    this.nome = n;
    this.cpf = c;
    this.telefone = t;
    this.nascimento = nasc;
  }  
  
}

public class Program{
  public static void Main(){
    Paciente p = new Paciente(
      Console.ReadLine(),
      Console.ReadLine(),
      Console.ReadLine(),
      DateTime.Parse(Console.ReadLine())
      // Ano - Mes - Dia
    );
    
    // p -> objeto
  }
}