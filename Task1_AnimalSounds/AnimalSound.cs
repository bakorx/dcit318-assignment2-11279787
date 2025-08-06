using System;

namespace AnimalSoundApp
{
    
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("This animal makes a sound.");
        }
    }

    
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog says: Woof! Woof!");
        }
    }

    
    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat says: Meow! Meow!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal genericAnimal = new Animal();
            Animal dog = new Dog();
            Animal cat = new Cat();

            Console.WriteLine("Animal Sounds:");
            genericAnimal.MakeSound();
            dog.MakeSound();
            cat.MakeSound();
        }
    }
}
