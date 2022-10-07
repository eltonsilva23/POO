using System; 

public class Program {

  public static void Main(string[] args) {
    Console.Write("Digite a base e a altura do retangulo\n");
    double b = double.Parse(Console.ReadLine());
    double h = double.Parse(Console.ReadLine());
    //Calculos
    double area= b*h;
    double perimetro = 2*b + 2*h;
    double diagonal = Math.Pow((b*b)+(h*h),0.5);
    Console.WriteLine($"Area = {area:f2} - Perimetro = {perimetro:f2} - Diagonal = {diagonal:f2}");
  }
}