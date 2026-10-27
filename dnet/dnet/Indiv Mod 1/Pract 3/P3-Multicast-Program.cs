using System;

public delegate void Demo();

class Test
{
    public void show()
    {
        Console.WriteLine("Method Show");
    }
    public void display()
    {
        Console.WriteLine("Method Display");
    }
    public void print()
    {
        Console.WriteLine("Method Print");
    }
}

class Program
{
    static void Main()
    {
        Test t = new Test();
        Demo d;
        d = t.show;
        d += t.print;
        d += t.display;
        d();
     
        Console.ReadLine();
    }
}




