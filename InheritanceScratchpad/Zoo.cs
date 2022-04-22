using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceScratchpad
{
    public class Zoo
    {
        public List<IAnimal> Animals { get; set; }

        public Zoo()
        {
            Animals = new List<IAnimal>();
        }

        public void ExerciseAllAnimals()
        {
            foreach (IAnimal animal in Animals)
            {
                animal.Move();
            }
        }
    }
}
