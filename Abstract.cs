abstract class Animal
{
    public abstract void animalSound();
    public void sleep()
    {
        Console.WriteLine("Zzz");
    }
}
class Dog : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The dog says: how how");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.animalSound();
        dog.sleep(); 
    }
}