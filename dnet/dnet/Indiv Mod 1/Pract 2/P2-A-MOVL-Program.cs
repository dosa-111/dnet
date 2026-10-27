using System;

class Addition
{
    public void Add(int a,int b)
    {
        Console.WriteLine("Addition of 2 numbers = " + (a + b));
    }

    public void Add1(int a,int b,int c)
    {
        Console.WriteLine("Addition of 3 numbers = " + (a+b+c));
    }

    class Program
    {
        static void Main(String[]args)
        {
            Addition a = new Addition();
            a.Add(20, 10);
            a.Add1(20, 10,11);
            Console.ReadLine();

        }
    }
}