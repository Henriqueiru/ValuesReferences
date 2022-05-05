using System;

namespace Algoritimo
{

  public class Program
  {

    public static void Demo1()
    {
      int[] numeros = new int[] { 0, 2, 4, 6, 8 };
      Console.WriteLine($"Digite o numero que gostaria de encontrar");
      var numero = int.Parse(Console.ReadLine());
      var idxEncontrado = EncontrarNumero(numeros, numero);

      if (idxEncontrado >= 0)
      {

        Console.WriteLine($"O numero digitado esta na posição {idxEncontrado}");
      }
      else
      {
        Console.WriteLine("O numero digitado nao foi encontrado");
      }
    }
    static int EncontrarNumero(int[] numeros, int numero)
    {
      for (int i = 0; i < numeros.Length; i++)
      {
        if (numeros[i] == numero)
          return i;
      }
      return -1;
    }

    static bool EncontrarPessoa(List<Pessoa> pessoas, Pessoa pessoa)
    {
      foreach (var item in pessoas)
      {
        if (item.Nome == pessoa.Nome)
        {
          return true;
        }
      }
      return false;
    }
    public static void Main()
    {
      List<Pessoa> pessoas = new List<Pessoa>()
      {
        new Pessoa(){Nome = "Ricardo"},
        new Pessoa(){Nome = "José"},
        new Pessoa(){Nome = "Maria"},
        new Pessoa(){Nome = "Fernando"},
        new Pessoa(){Nome = "Marcos"},
      };

      Console.WriteLine("Digite a pessoa que gostaria de localizar");
      var nome = Console.ReadLine();
      var pessoa = new Pessoa() { Nome = nome };
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