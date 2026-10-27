interface Shape
{
    void Area();
}

class Square : Shape
{
    int side = 4;

   public void Area()
    {
        Console.WriteLine(" Area of square :" + (side * side));
    }
}

class Program
{
    public static void Main()
    {
        Square s = new Square();
        s.Area();
        Console.ReadLine();

    }
}