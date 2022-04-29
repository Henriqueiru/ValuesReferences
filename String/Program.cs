
using System;

namespace AtribuirValor2
{
  public class Program
  {

    static void TrocarNome(string nome, string nomeNovo)
    {
      nome = nomeNovo;
    }
    public static void Main()
    {
      string nome = "Henrique";

      TrocarNome(nome, "Jao");
      Console.WriteLine($"O novo nome é {nome}");

    }
  }
}