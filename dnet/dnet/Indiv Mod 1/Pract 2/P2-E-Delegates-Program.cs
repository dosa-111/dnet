using System;

public delegate void Message();
class Test
{
    
    public event Message Notify;
    public void Show()
    {
        Console.WriteLine("Method inside Test class");
       
        Notify();
    }
}

class Program
{
    public static void Display()
    {
        Console.WriteLine("Event Executed Successfully");
    }
    static void Main()
    {
        Test t = new Test();
        // Attaching method to event
        t.Notify += Display;
        t.Show();
        Console.ReadLine();
    }
}



