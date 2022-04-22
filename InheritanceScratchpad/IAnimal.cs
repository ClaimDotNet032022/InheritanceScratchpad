using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceScratchpad
{
    public interface IAnimal
    {
        string Habitat { get; }

        void Move();
        void Eat(string food);

    }
}
