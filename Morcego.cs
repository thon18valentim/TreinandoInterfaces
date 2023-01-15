using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinandoInterfaces
{
  internal class Morcego : Mamifero, IVoar
  {
    private int altitudeMaximaEmMetros;
    private double velocidadeDoVoo;

    public int AltitudeMaximaEmMetros { get => altitudeMaximaEmMetros; set => altitudeMaximaEmMetros = value; }
    public double VelocidadeDoVoo { get => velocidadeDoVoo; set => velocidadeDoVoo = value; }

    public Morcego(string nome, DateTime nascimento, char sexo, bool carnivoro, bool peconhento, int altitudeMaximaEmMetros, double velocidadeDoVoo)
    {
      Nome = nome;
      DataNascimento = nascimento;
      Sexo = sexo;
      Carnivoro = carnivoro;
      Peconhento = peconhento;

      AltitudeMaximaEmMetros = altitudeMaximaEmMetros;
      VelocidadeDoVoo = velocidadeDoVoo;

      CalcularIdade(nascimento);
    }

    public override void Alimentar()
      => Console.WriteLine($"{Nome}, o morcego, está se alimentando");

    public override void Amamentar()
    {
      if (Sexo == 'M')
      {
        Console.WriteLine($"{Nome}, o morcego, é macho então não amamenta");
        return;
      }
      Console.WriteLine($"{Nome}, a morcego, está amamentando");
    }

    public override void Comunicar()
      => Console.WriteLine($"{Nome}, o morcego, está rugindo");

    public override void Movimentar()
      => Console.WriteLine($"{Nome}, o morcego, está andando");

    public void Voar()
      => Console.WriteLine($"{Nome}, o morcego, está voando");
  }
}
