using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceScratchpad
{
    public class Bird : IAnimal, ILifeform
    {
        public string Habitat => "Forest";

        public bool IsAlive { get; private set; } = true;

        public void Die()
        {
            IsAlive = false;
        }

        public void Eat(string food)
        {
            Console.WriteLine("Bird eats " + food);
        }

        public void Move()
        {
            Console.WriteLine("The bird flies");
        }

        public ILifeform Reproduce()
        {
            return new Bird();
        }
    }
}
