using System;
class Program
{
    static void Main()
    {
        string[] cities = new string[10];
        Console.WriteLine("Enter 10 city names:");
        for (int i = 0; i < 10; i++)
        {
            cities[i] = Console.ReadLine();
        }
        Array.Sort(cities);
        Console.WriteLine("\nCities in Sorted Order:");
        foreach (string city in cities)
        {
            Console.WriteLine(city);
        }
        Console.ReadLine();
    }
}