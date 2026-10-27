using System;
class Program
{
    static void Main()
    {
        int a, b, result;
        try
        {
            Console.Write("Enter First Number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            b = Convert.ToInt32(Console.ReadLine());
            result = a / b;
            Console.WriteLine("Result = " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid Input");
        }
        finally
        {
        }
        Console.WriteLine("Program Ended");
        Console.ReadLine();
    }
}