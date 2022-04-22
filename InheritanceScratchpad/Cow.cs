using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceScratchpad
{
    public class Cow : IAnimal
    {
        public string Habitat => "Farm";

        public Cow()
        {

        }

        public void Move()
        {
            Console.WriteLine("The cow walks");
        }

        public void Eat(string food)
        {
            
            if (food == "plants")
            {
                Console.WriteLine("Cow eats " + food);
            }
            else
            {
                Console.WriteLine("Cow won't eat " + food);
            }
        }
    }
}
