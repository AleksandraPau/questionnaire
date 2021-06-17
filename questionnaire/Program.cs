using System;

namespace questionnaire
{
    class Program
    {
		public static void Main(string[] args)
		{
			Console.Write("Enter your name: ");
			var Name = Console.ReadLine();

			Console.Write("Enter your age: ");
			var age = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Your name is {0} and age is {1}", Name, age);

			Console.Write("Enter your birthdate: ");

			var birthdate = Console.ReadLine();

			Console.WriteLine("Your birthdate is {0}", birthdate);
		}
	}
}