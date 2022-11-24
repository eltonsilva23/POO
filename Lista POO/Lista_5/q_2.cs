using system;

public class Premio{
  private string cliente;
  private DateTime data;
  private object premio;

  public Premio() {}

  public Premio(string c, DateTime d) {
    cliente = c;
    data = d;
  }

  public void SetPremio(object p){
    premio = p;
  }

  public object GetPremio(){
    return premio;
  }

  public override string ToString(){
    return 
      $"{cliente}\n" +
      $"{data}\n" +
      $"{premio}";
  }
}

public class ValeCompras{
  private DateTime dataValidade;
  private decimal valor;
  
  public ValeCompras() {}

  public ValeCompras(DateTime d, decimal v){
    data = d;
    if (v>0) valor = v;
  }

  public override string ToString(){
    return 
      $"{dataValidade:dd/MM/yyyy}\n" +
      $"{valor}";
  }
  
}