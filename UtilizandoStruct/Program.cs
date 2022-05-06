
using System;

namespace AtribuirValor
{
  public class Program
  {
    static bool EncontrarPessoa(List<StructPessoa> pessoas, StructPessoa pessoa)
    {
      foreach (var item in pessoas)
      {
        if (item.Equals(pessoa))
        {
          return true;
        }
      }
      return false;
    }
    public static void Main()
    {
      List<StructPessoa> pessoas = new List<StructPessoa>()
      {
        new StructPessoa(){Nome = "Ricardo"},
        new StructPessoa(){Nome = "José"},
        new StructPessoa(){Nome = "Maria"},
        new StructPessoa(){Nome = "Fernando"},
        new StructPessoa(){Nome = "Marcos"},
      };

      Console.WriteLine("Digite a pessoa que gostaria de localizar");
      var nome = Console.ReadLine();
      var pessoa = new StructPessoa() { Nome = nome };
      var encontrado = EncontrarPessoa(pessoas, pessoa);
      if (encontrado)
      {
        Console.WriteLine("Pessoa localizada!");
      }
      else
      {
        Console.WriteLine("Pessoa nao localizada");
      }
    }
  }
}