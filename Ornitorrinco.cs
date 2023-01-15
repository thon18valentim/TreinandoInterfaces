using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinandoInterfaces
{
  internal class Ornitorrinco : Mamifero, IOviparo, IAquatico
  {
    private bool viveEmTerra;
    private bool mergulho;
    private bool aguaDoce;

    public bool ViveEmTerra { get => viveEmTerra; init => viveEmTerra = value; }
    public bool Mergulho { get => mergulho; init => mergulho = value; }
    public bool AguaDoce { get => aguaDoce; init => aguaDoce = value; }

    public Ornitorrinco(string nome, DateTime nascimento, char sexo, bool carnivoro, bool viveEmTerra, bool mergulho, bool aguaDoce)
    {
      Nome = nome;
      DataNascimento = nascimento;
      Sexo = sexo;
      Carnivoro = carnivoro;

      if (sexo == 'M')
        Peconhento = true;
      else
        Peconhento = false;

      AguaDoce = aguaDoce;
      Mergulho = mergulho;
      ViveEmTerra = viveEmTerra;

      CalcularIdade(nascimento);
    }

    public override void Alimentar()
      => Console.WriteLine($"{Nome}, o ornitorrinco, está se alimentando");

    public override void Amamentar()
    {
      if (Sexo == 'M')
      {
        Console.WriteLine($"{Nome}, o ornitorrinco, é macho então não amamenta");
        return;
      }
      Console.WriteLine($"{Nome}, a ornitorrinco, está amamentando");
    }

    public override void Comunicar()
      => Console.WriteLine($"{Nome}, o ornitorrinco, está se comunicando");

    public override void Movimentar()
      => Console.WriteLine($"{Nome}, o ornitorrinco, está nadando");

    public void Botar()
    {
      if (Sexo == 'M')
      {
        Console.WriteLine($"{Nome}, o ornitorrinco, é macho então não bota ovo");
        return;
      }
      Console.WriteLine($"{Nome}, o ornitorrinco, está botando ovos");
    }

    public void Chocar()
      => Console.WriteLine($"{Nome}, o ornitorrinco, está chocando ovos");
  }
}
