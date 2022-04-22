using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceScratchpad
{
    public class Horse : IAnimal
    {
        public string Habitat => "Prairie";

        public void Eat(string food)
        {
            if (food == "plants")
            {
                Console.WriteLine("The horse eats");
            }
            else
            {
                Console.WriteLine("The horse doesn't eat");
            }
        }

        public void Move()
        {
            Console.WriteLine("The horse gallops");
        }
    }
}
