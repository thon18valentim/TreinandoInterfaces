using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinandoInterfaces
{
  internal class Coruja : Ave, IOviparo, IVoar
  {
    private int altitudeMaximaEmMetros;
    private double velocidadeDoVoo;

    public int AltitudeMaximaEmMetros { get => altitudeMaximaEmMetros; set => altitudeMaximaEmMetros = value; }
    public double VelocidadeDoVoo { get => velocidadeDoVoo; set => velocidadeDoVoo = value; }

    public Coruja(string nome, DateTime nascimento, char sexo, bool carnivoro, bool peconhento, bool rapina, bool comPena, int altitudeMaximaEmMetros, double velocidadeDoVoo)
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
        Console.WriteLine($"{Nome}, a coruja, é macho então não bota ovo");
        return;
      }
      Console.WriteLine($"{Nome}, a coruja, está botando ovos");
    }

    public void Chocar()
      => Console.WriteLine($"{Nome}, a coruja, está chocando ovos");

    public void Voar()
      => Console.WriteLine($"{Nome}, a coruja, está voando");

    public override void Comunicar()
      => Console.WriteLine($"{Nome}, a coruja, está emitindo sons");

    public override void Movimentar()
      => Console.WriteLine($"{Nome}, a coruja, está andando");

    public override void Alimentar()
      => Console.WriteLine($"{Nome}, a coruja, está se alimentando");
  }
}
