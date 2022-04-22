//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace InheritanceScratchpad
//{
//    public abstract class Animal : IAnimal
//    {
//        public string Color { get; set; }
//        public virtual string Habitat { get; }
//        protected DietType DietType { get; set; }

//        public Animal(DietType dietType)
//        {
//            DietType = dietType;
//        }

//        public abstract void Move();

//        public virtual void Eat(string food)
//        {
//            Console.WriteLine("Animal eats " + food);
//        }

//    }
//}
