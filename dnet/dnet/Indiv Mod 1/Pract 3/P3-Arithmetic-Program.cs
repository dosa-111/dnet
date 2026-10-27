using System;

namespace Arithaamtic
{
    public delegate void Calculation(int a,int b);

    class Arithmetic
    {
        public void Add(int a,int b)
        {
            Console.WriteLine("Addition =" + (a + b));
        }
        public void Subtract(int a,int b)
        {
            Console.WriteLine("Subtract =" + (a + b));
        }
    }

    class Program
    {
        static void Main()
        {
            Arithmetic obj = new Arithmetic();
            Calculation c;
            c = obj.Add;
            c(20, 10);
            c = obj.Subtract;
            c(20, 10);
            Console.ReadLine();
        }
    }
}