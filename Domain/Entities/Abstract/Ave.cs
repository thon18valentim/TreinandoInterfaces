using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinandoInterfaces
{
  internal abstract class Ave : Animal
  {
    public bool Rapina { get; init; }
    public bool ComPena { get; init; }

    public virtual void Ciscar()
      => Console.WriteLine($"{Nome} está ciscando");
  }
}
