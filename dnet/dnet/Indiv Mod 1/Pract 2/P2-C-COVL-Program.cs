using System;

class Student
{
	public Student()
	{
		Console.WriteLine("Parthh");
	}

	public Student(string name)
	{
		Console.WriteLine("Who's the God = " + name);
	}

	public Student(string name , int age)
	{
		Console.WriteLine("God is one and only =" + name);
		Console.WriteLine("Age of the God =" + age);
	}

	class Program
	{
		public static void Main()
		{
			Student s = new Student();
			Student s1 = new Student("Parthhh");
			Student s2 = new Student("Parthh", 20);

		}
	}
}