using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinandoInterfaces
{
  internal abstract class Mamifero : Animal
  {
    public int QtdeMamas { get; init; }
    public bool Pelos { get; init; }
    public string CorPelo { get; init; }

    public abstract void Amamentar();
  }
}
