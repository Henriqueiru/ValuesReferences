using System.Collections.Generic;
using System;

namespace ValueTypes
{
  public class Program
  {
    static void AlterarNome(string[] nomes, string nome, string nomeNovo)
    {
      for (int i = 0; i < nomes.Length; i++)
      {
        if (nomes[i] == nome)
        {
          nomes[i] = nomeNovo;
        }
      }
    }

    static void Main()
    {
      var nomes = new string[] { "José", "Maria", "Ricardo", "Alice", "Pedro" };
      Console.WriteLine("Digite o nome a ser substituido");
      var nome = Console.ReadLine();
      Console.WriteLine("Digite o nome novo:");
      var nomeNovo = Console.ReadLine();

      AlterarNome(nomes, nome, nomeNovo);

      Console.WriteLine($@"A lista de nomes Alterada é:
      {string.Join(",\n", nomes)}");
    }
  }
}