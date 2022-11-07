using System;
using System.Linq;

public class Program{
  public static void Main() {
    int num = int.Parse(Console.ReadLine());
    int[] v = new int[num];
    v[0]=0;
    v[1]=1;
    if (num==0) Console.WriteLine("0");
    else if (num==1) Console.WriteLine("0,1");
    else if (num>1){
      for (int i = 2; i<=num; i++){
        v[i] = v[i-2] + v[i-1];
      }
      Console.WriteLine(v[num-2]);
    }
  }
}
