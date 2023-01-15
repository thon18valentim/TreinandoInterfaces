using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinandoInterfaces
{
  internal class Lontra : Mamifero, IAquatico
  {
    private bool viveEmTerra;
    private bool mergulho;
    private bool aguaDoce;

    public bool ViveEmTerra { get => viveEmTerra; init => viveEmTerra = value; }
    public bool Mergulho { get => mergulho; init => mergulho = value; }
    public bool AguaDoce { get => aguaDoce; init => aguaDoce = value; }

    public Lontra(string nome, DateTime nascimento, char sexo, bool carnivoro, bool peconhento, bool viveEmTerra, bool mergulho, bool aguaDoce)
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
      => Console.WriteLine($"{Nome}, a lontra, está se alimentando");

    public override void Amamentar()
    {
      if (Sexo == 'M')
      {
        Console.WriteLine($"{Nome}, a lontra, é macho então não amamenta");
        return;
      }
      Console.WriteLine($"{Nome}, a lontra, está amamentando");
    }

    public override void Comunicar()
      => Console.WriteLine($"{Nome}, a lontra, está fazendo sonzinhos");

    public override void Movimentar()
      => Console.WriteLine($"{Nome}, a lontra, está nadando");
  }
}
