using System.ComponentModel.Design;
using System.Runtime.Intrinsics.X86;

namespace proekt_c_
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите Первое число: ");
			int firstnum = int.Parse(Console.ReadLine()); // парсим string в int
			Console.Write("Введите Второе число: ");
			int secondnum = int.Parse(Console.ReadLine());// парсим string в int
			Console.Write("Введите действия(Деление, умножение, сложение, вычитание): ");
			string operation = Console.ReadLine();

			switch (operation.ToLower() /* не учитываем регистр введённой операции */)
			{
				case "деление":
					Console.WriteLine("Ответ: " + (firstnum / secondnum));
					break;

				case "умножение":
					Console.WriteLine("Ответ: " + (firstnum * secondnum));
					break;

				case "сложение":
					Console.WriteLine("Ответ: " + (firstnum + secondnum));
					break;

				case "вычитание":
					Console.WriteLine("Ответ: " + (firstnum - secondnum));
					break;
			}

			Console.ReadLine();
		}
	}
}
