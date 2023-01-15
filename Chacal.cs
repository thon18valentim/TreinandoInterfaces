using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinandoInterfaces
{
  internal class Chacal : Mamifero
  {
    public Chacal(string nome, DateTime nascimento, char sexo, bool carnivoro, bool peconhento)
    {
      Nome = nome;
      DataNascimento = nascimento;
      Sexo = sexo;
      Carnivoro = carnivoro;
      Peconhento = peconhento;

      CalcularIdade(nascimento);
    }

    public override void Alimentar()
      => Console.WriteLine($"{Nome}, o chacal, está se alimentando");

    public override void Amamentar()
    {
      if (Sexo == 'M')
      {
        Console.WriteLine($"{Nome}, o chacal, é macho então não amamenta");
        return;
      }
      Console.WriteLine($"{Nome}, a chacal, está amamentando");
    }

    public override void Comunicar()
      => Console.WriteLine($"{Nome}, o chacal, está uivando");

    public override void Movimentar()
      => Console.WriteLine($"{Nome}, o chacal, está andando");
  }
}
