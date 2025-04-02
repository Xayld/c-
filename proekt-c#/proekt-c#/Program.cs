using System.ComponentModel.Design;
using System.Runtime.Intrinsics.X86;

namespace proekt_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Введите Первое число: ");
            string numberOne = Console.ReadLine();
            Console.Write("Введите Второе число: ");
            string numberTwo = Console.ReadLine();
            Console.Write("Введите действия(Деление, умножение, сложение, вычитание): ");
            string type = Console.ReadLine();

            int oneToInt = Convert.ToInt32(numberOne);
            int twoToInt = Convert.ToInt32(numberTwo);

            if (type == "Деление")
            {
                Console.Write("Ответ: ");
                Console.Write(oneToInt / twoToInt);


            } else if (type == "Умножение") {
                Console.Write("Ответ: ");
                Console.Write(oneToInt * twoToInt);

            } else if (type == "Сложение")

            {
                Console.Write("Ответ: ");
                Console.Write(oneToInt + twoToInt);
            } else if (type == "Вычитание")
            {
                Console.Write("Ответ: ");
                Console.Write(oneToInt - twoToInt);
            };

            Console.ReadLine();







        }
    }
}
