

Dog dog = new Dog();
dog.Move();
dog.Eat("meat");
dog.Bark();



IAnimal cow = new Cow();
cow.Move();
cow.Eat("meat");

IAnimal bird = new Bird();
bird.Eat("worms");
bird.Move();

IAnimal animal = new Dog();
animal.Move();


IPet pet = new Dog();
pet.Owner = "Eric";
Console.WriteLine(pet.Owner);
//pet.Bark();


Zoo zoo = new Zoo();
zoo.Animals.Add(new Dog());
zoo.Animals.Add(new Dog());
zoo.Animals.Add(new Cow());
zoo.Animals.Add(new Cow());
zoo.Animals.Add(new Bird());
zoo.Animals.Add(new Bird());
zoo.Animals.Add(new Horse());
zoo.Animals.Add(new Horse());

zoo.ExerciseAllAnimals();

int n = 3;
short s = (short)n;

IAnimal a = new Horse();
Dog d = (Dog)a;

d = a as Dog;
bool isDog = a is Dog;
isDog = a is Dog theDog;

