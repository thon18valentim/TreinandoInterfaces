using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinandoInterfaces
{
  internal class Cisne : Ave, IOviparo, IVoar
  {
    private int altitudeMaximaEmMetros;
    private double velocidadeDoVoo;

    public int AltitudeMaximaEmMetros { get => altitudeMaximaEmMetros; set => altitudeMaximaEmMetros = value; }
    public double VelocidadeDoVoo { get => velocidadeDoVoo; set => velocidadeDoVoo = value; }

    public Cisne(string nome, DateTime nascimento, char sexo, bool carnivoro, bool peconhento, bool rapina, bool comPena, int altitudeMaximaEmMetros, double velocidadeDoVoo)
    {
      Nome = nome;
      DataNascimento = nascimento;
      Sexo = sexo;
      Carnivoro = carnivoro;
      Peconhento = peconhento;

      Rapina = rapina;
      ComPena = comPena;

      AltitudeMaximaEmMetros = altitudeMaximaEmMetros;
      VelocidadeDoVoo = velocidadeDoVoo;

      CalcularIdade(nascimento);
    }

    public void Botar()
    {
      if (Sexo == 'M')
      {
        Console.WriteLine($"{Nome}, o cisne, é macho então não bota ovo");
        return;
      }
      Console.WriteLine($"{Nome}, a cisne, está botando ovos");
    }

    public void Chocar()
      => Console.WriteLine($"{Nome}, o cisne, está chocando ovos");

    public void Voar()
      => Console.WriteLine($"{Nome}, o cisne, está voando");

    public override void Comunicar()
      => Console.WriteLine($"{Nome}, o cisne, está emitindo sons");

    public override void Movimentar()
      => Console.WriteLine($"{Nome}, o cisne, está andando");

    public override void Alimentar()
      => Console.WriteLine($"{Nome}, o cisne, está se alimentando");
  }
}
