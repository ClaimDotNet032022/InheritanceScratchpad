using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceScratchpad
{
    public class Dog : IAnimal, ILifeform, IPet
    {
        public string Owner { get; set; }

        public string Habitat 
        { 
            get
            {
                return "House";
            }
        }

        public bool IsAlive { get; private set; } = true;

        public void Move()
        {
            Console.WriteLine("The dog runs");
        }

        public void Eat(string food)
        {
            if (food == "meat")
            {
                Console.WriteLine("Dog eats meat");
            }
            else
            {
                Console.WriteLine("Dog won't eat " + food);
            }
        }

        public void Bark()
        {
            Console.WriteLine("Ruff!");
        }

        public ILifeform Reproduce()
        {
            return new Dog();
        }

        public void Die()
        {
            IsAlive = false;
        }
    }
}
