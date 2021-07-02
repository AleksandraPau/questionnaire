using System;

namespace questionnaire
{
    class Program
    {
		static (string Name, string LastName, int Age, bool IsHavePet) EnterUser()
        {
			(string Name, string LastName, int Age, bool IsHavePet) User;
			Console.WriteLine("Введите имя");
			User.Name = Console.ReadLine();

			Console.WriteLine("Введите фамилию");
			User.LastName = Console.ReadLine();

			string age;
			int intage;
			do
			{
				Console.WriteLine("Введите возраст цифрами");
				age = Console.ReadLine();
			} while (CheckNum(age, out intage));

			Console.WriteLine("Имеете ли Вы питомца(ев)? (Да/Нет)");
			if (Console.ReadLine() == "Да")
            {
				User.IsHavePet = true;
				
            }	
			else
            {
				User.IsHavePet = false;
            }

			return User;
        }

		static bool CheckNum(string number, out int correctnumber)
        {
			if(int.TryParse(number, out int intnum))
            {
				if (intnum > 0)
				{
					correctnumber = intnum;
					return true;
				}
            }
            {
				correctnumber = 0;
				return false;
            }
        }

		public static void Main(string[] args)
		{
			
		}
	}
}