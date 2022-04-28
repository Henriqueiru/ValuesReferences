using System;

namespace ValueTypes
{
  public class Program
  {
    static int Adicionar20(int x)
    {
      return x + 20;
    }
    static void Main()
    {
      int a = 2;
      a = Adicionar20(a);
      Console.WriteLine($"O valor da variavel a é: {a} ");
    }
  }
}