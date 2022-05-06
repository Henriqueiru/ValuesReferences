using System;

namespace ValueTypes
{
  public class Program
  {
    static void Adicionar20(ref int a)
    {
      a += 20;
    }
    static void Main()
    {
      int a = 2;
      Adicionar20(ref a);
      Console.WriteLine($"O valor da variavel a é: {a} ");
    }
  }
}