using System;

namespace Dot_net
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }

    class Mammal : Animal
    {
        public void givebirth()
        {
            Console.WriteLine("Mammal is giving birth.");
        }
    }

    class Horse : Mammal
    {
        public void swim()
        {
            Console.WriteLine("Horse is swimming.");
        }
    }

    class Program
    {
        static void seal(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            Mammal mammal = new Mammal();
            mammal.Eat();
            mammal.givebirth();

            Horse horse = new Horse();
            horse.givebirth();
            horse.swim();

        }
    }
}
