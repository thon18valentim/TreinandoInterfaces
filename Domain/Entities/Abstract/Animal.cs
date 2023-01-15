using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinandoInterfaces
{
  internal abstract class Animal
  {
    public string Nome { get; init; }
    public DateTime DataNascimento { get; init; }
    public char Sexo { get; init; }
    public int Idade { get; private set; }
    public bool Carnivoro { get; init; }
    public bool Peconhento { get; init; }

    public abstract void Movimentar();
    public abstract void Comunicar();
    public abstract void Alimentar();
    protected void CalcularIdade(DateTime dataNascimento)
    {
      var dateNow = DateTime.Now;
      Idade = Convert.ToInt32(dateNow.Subtract(dataNascimento).TotalDays / 365);
    }
  }
}
