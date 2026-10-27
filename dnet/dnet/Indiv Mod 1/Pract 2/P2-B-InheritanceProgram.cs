using System;

class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal can Eat");
    }
}
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog can Bark");
    }
}

class Puppy : Dog
{
    public void Weep()
    {
        Console.WriteLine("Puppy can Weep");
    }
}

class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine("Cat can Meow");
    }
}
class Program
{
    static void Main()
    {
        
        Dog d = new Dog();
        d.Eat();
        d.Bark();
        
        Puppy p = new Puppy();
        p.Eat();
        p.Bark();
        p.Weep();
        
        Cat c = new Cat();
        c.Eat();
        c.Meow();
        Console.ReadLine();
    }
}
