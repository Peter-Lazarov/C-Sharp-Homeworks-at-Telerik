using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinciplesPart2
{
    public interface IAnimal
    {
        string Name { get; }
        string Speak();
    }
}
