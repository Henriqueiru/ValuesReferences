
using System;

namespace ReferenceTypes
{
  public class Program
  {
    static void TrocarNome(Pessoa p1, string nomeNovo)
    {
      p1.Nome = nomeNovo;
    }
    public static void Main()
    {
      Pessoa p1 = new Pessoa();
      p1.Nome = "Henrique";
      p1.Idade = 22;
      p1.Documento = "370.021.978-43";

      TrocarNome(p1, "Joao");

      Console.WriteLine($"O novo nome é : {p1.Nome}");
    }
  }
}