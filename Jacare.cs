using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinandoInterfaces
{
  internal class Jacare : Reptil, IOviparo, IAquatico
  {
    private bool viveEmTerra;
    private bool mergulho;
    private bool aguaDoce;

    public bool ViveEmTerra { get => viveEmTerra; init => viveEmTerra = value; }
    public bool Mergulho { get => mergulho; init => mergulho = value; }
    public bool AguaDoce { get => aguaDoce; init => aguaDoce = value; }

    public Jacare(string nome, DateTime nascimento, char sexo, bool carnivoro, bool peconhento, bool temEscamas, bool temCasco, bool viveEmTerra, bool mergulho, bool aguaDoce)
    {
      Nome = nome;
      DataNascimento = nascimento;
      Sexo = sexo;
      Carnivoro = carnivoro;
      Peconhento = peconhento;

      TemEscamas = temEscamas;
      TemCasco = temCasco;

      AguaDoce = aguaDoce;
      Mergulho = mergulho;
      ViveEmTerra = viveEmTerra;

      CalcularIdade(nascimento);
    }

    public override void Alimentar()
      => Console.WriteLine($"{Nome}, o jacaré, está se alimentando de carníça");

    public void Botar()
    {
      if (Sexo == 'M')
      {
        Console.WriteLine($"{Nome}, o jacaré, é macho então não bota ovo");
        return;
      }
      Console.WriteLine($"{Nome}, a jacaré, está botando ovos");
    }

    public void Chocar()
      => Console.WriteLine($"{Nome}, o jacaré, está chocando ovos");

    public override void Comunicar()
     => Console.WriteLine($"{Nome}, o jacaré, está se comunicando");

    public override void Movimentar()
      => Console.WriteLine($"{Nome}, o jacaré, está andando");
  }
}
