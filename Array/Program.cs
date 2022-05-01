

using System;

namespace Array
{
  public class Program
  {
    static void TrocarNome(string nome, string nomeNovo)
    {
      nome = nomeNovo;
    }

    static void MudarParaImpar(int[] pares)
    {
      for (int i = 0; i < pares.Length; i++)
      {
        pares[i] = pares[i] + 1;
      }
    }
    public static void Main()
    {
      int[] pares = new int[] { 0, 2, 4, 6, 8 };

      MudarParaImpar(pares);
      Console.WriteLine($"Os impares {string.Join(",", pares)}");


    }
  }
}