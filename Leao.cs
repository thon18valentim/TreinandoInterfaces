using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinandoInterfaces
{
  internal class Leao : Mamifero
  {
    public Leao(string nome, DateTime nascimento, char sexo, bool carnivoro, bool peconhento)
    {
      Nome = nome;
      DataNascimento = nascimento;
      Sexo = sexo;
      Carnivoro = carnivoro;
      Peconhento = peconhento;

      CalcularIdade(nascimento);
    }

    public override void Alimentar()
      => Console.WriteLine($"{Nome}, o leão, está se alimentando");

    public override void Amamentar()
    {
      if (Sexo == 'M')
      {
        Console.WriteLine($"{Nome}, o leão, é macho então não amamenta");
        return;
      }
      Console.WriteLine($"{Nome}, a leoa, está amamentando");
    }

    public override void Comunicar()
      => Console.WriteLine($"{Nome}, o leão, está rugindo");

    public override void Movimentar()
      => Console.WriteLine($"{Nome}, o leão, está andando");
  }
}
