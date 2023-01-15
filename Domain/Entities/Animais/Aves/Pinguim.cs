using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinandoInterfaces
{
  internal class Pinguim : Ave, IOviparo, IAquatico
  {
    private bool viveEmTerra;
    private bool mergulho;
    private bool aguaDoce;

    public bool ViveEmTerra { get => viveEmTerra; init => viveEmTerra = value; }
    public bool Mergulho { get => mergulho; init => mergulho = value; }
    public bool AguaDoce { get => aguaDoce; init => aguaDoce = value; }

    public Pinguim(string nome, DateTime nascimento, char sexo, bool carnivoro, bool peconhento, bool mergulho, bool aguaDoce)
    {
      Nome = nome;
      DataNascimento = nascimento;
      Sexo = sexo;
      Carnivoro = carnivoro;
      Peconhento = peconhento;

      AguaDoce = aguaDoce;
      Mergulho = mergulho;
      ViveEmTerra = viveEmTerra;

      CalcularIdade(nascimento);
    }

    public override void Alimentar()
      => Console.WriteLine($"{Nome}, o pinguim, está se alimentando");

    public void Botar()
    {
      if (Sexo == 'M')
      {
        Console.WriteLine($"{Nome}, o pinguim, é macho então não bota ovo");
        return;
      }
      Console.WriteLine($"{Nome}, a pinguim, está botando ovos");
    }

    public void Chocar()
      => Console.WriteLine($"{Nome}, o pinguim, está chocando ovos");

    public override void Comunicar()
    => Console.WriteLine($"{Nome}, o pinguim, está se comunicando");

    public override void Movimentar()
      => Console.WriteLine($"{Nome}, o pinguim, está andando");
  }
}
