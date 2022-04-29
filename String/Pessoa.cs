using System;

namespace AtribuirValor2
{
  public class Pessoa
  {
    public int Idade { get; set; }
    public string Nome { get; set; }
    public string Documento { get; set; }

    public Pessoa Clone()
    {
      return new Pessoa()
      {
        Documento = this.Documento,
        Nome = this.Nome,
        Idade = this.Idade
      };
    }
  }
}