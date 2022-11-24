using System;
//using System.Globalization;
//using System.Threading;

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

  public string Idade(){
    DateTime atual = DateTime.Now;
    int anos = atual.Year - nascimento.Year;
    int meses = atual.Month - nascimento.Month;
    if (meses<0){
      anos--;
      meses +=12;
    }
    return 
      anos.ToString() + " Ano(s) " +
      meses.ToString() + " Mês(es)";
  }

  public override string ToString(){
    return 
      $"Nome: {nome}\n"+
      $"CPF: {cpf}\n"+
      $"Telefone: {telefone}\n"+
      $"Data de Nascimento: {nascimento}";
  }
}

public class Program{
  public static void Main(){
    //Thread.CurrentThread.CurrentCulture = 
     // new CultureInfo("pt-BR");
    Console.WriteLine(
      "Digite Nome, CPF, telefone, Data (Formato:DD/MM/AAAA)"
    );
    Paciente p = new Paciente(
      Console.ReadLine(),
      Console.ReadLine(),
      Console.ReadLine(),
      DateTime.Parse(Console.ReadLine())
    );

    Console.WriteLine(p);
    Console.WriteLine(p.Idade());

    //DateTime hoje = DateTime.Now;

    //Console.WriteLine(hoje.DayOfWeek);
    
  }
}