using System;

class Pais {
  private string nome;
  private int populacao;
  //construtor
  public Pais(string nome, int populacao) {
    // this = usa-se pata referenciar elementos da claase 
    // this . atributo da classe = parametro
    this.SetNome(nome);
    this.SetPopulacao(populacao);
  }
  public void SetNome(string nome){
    if (nome.Length>0)
      this.nome = nome;
  }
  public void SetPopulacao(int populacao){
    if (populacao>=0) this.populacao = populacao;
  }
  public string GetNome() {
    //Get = Retorma valor
    return this.nome;
  }
  public int GetPopulacao() {
    return this.populacao;
  }
  public override /* Sobreescrever o método da clase pai (Object) */ string ToString() {
    string s_nome = "Nome: " + this.nome;
    string s_populacao = "Populacao: " + this.populacao;
    return s_nome + "\n" + s_populacao;
  }
} 

class Program {
  public static void Main(string[] args) {
    Pais maior = new Pais("MAIOR", 0);
    for (int i=0; i<2; i++){
      Pais p = new Pais(Console.ReadLine(), int.Parse(Console.ReadLine()));
      if(p.GetPopulacao() > maior.GetPopulacao()) maior = p;
      Console.WriteLine((i+1) + "ª Vez: " + p.ToString());
    }
    Console.WriteLine("\n\n"+maior.GetNome());
  }
}