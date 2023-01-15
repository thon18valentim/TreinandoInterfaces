using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinandoInterfaces
{
  internal class DragaoComodo : Reptil, IOviparo
  {
    public DragaoComodo(string nome, DateTime nascimento, char sexo, bool carnivoro, bool peconhento, bool temEscamas, bool temCasco)
    {
      Nome = nome;
      DataNascimento = nascimento;
      Sexo = sexo;
      Carnivoro = carnivoro;
      Peconhento = peconhento;

      TemEscamas = temEscamas;
      TemCasco = temCasco;

      CalcularIdade(nascimento);
    }

    public override void Alimentar()
      => Console.WriteLine($"{Nome}, o dragão de comôdo, está se alimentando de carníça");

    public void Botar()
    {
      if (Sexo == 'M')
      {
        Console.WriteLine($"{Nome}, o dragão de comôdo, é macho então não bota ovo");
        return;
      }
      Console.WriteLine($"{Nome}, o dragão de comôdo, está botando ovos");
    }

    public void Chocar()
      => Console.WriteLine($"{Nome}, o dragão de comôdo, está chocando ovos");

    public override void Comunicar()
     => Console.WriteLine($"{Nome}, o dragão de comôdo, está se comunicando");

    public override void Movimentar()
      => Console.WriteLine($"{Nome}, o dragão de comôdo, está andando");
  }
}
