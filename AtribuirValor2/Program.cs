
using System;

namespace AtribuirValor2
{
  public class Program
  {
    static StructPessoa TrocarNome(StructPessoa p1, string nomeNovo)
    {
      p1.Nome = nomeNovo;
      return p1;
    }

    public static void Main()
    {
      StructPessoa p1 = new StructPessoa()
      {
        Documento = "1234",
        Idade = 22,
        Nome = "Henrique"
      };

      var p2 = p1;

      p2 = TrocarNome(p2, "Riquinho");

      Console.WriteLine($@"
      Nome do p1 {p1.Nome}
      Nome do p2 {p2.Nome}
      ");


    }
  }
}