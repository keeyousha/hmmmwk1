using System;
using System.Data.SqlClient;

namespace Task1
{
    public class Task1
    {
        /*
         * Задание 1.1. Напишите функцию `sayHello`, которая печатает строку, состоящую из "Hello ",
         * значения переменной name и символа '!' в конце. В решении следует использовать интерполяцию
         * строк: https://docs.microsoft.com/ru-ru/dotnet/csharp/language-reference/tokens/interpolated. Для печати строки
         * следует использовать функцию `Console.WriteLine`.
         */
        internal static void SayHello(String name)
        {
            Console.WriteLine($"Hello {name}!");
        }

        /*
         * Задание 1.2. Напишите функцию `helloUser`, которая запрашивает имя пользователя с клавиатуры,
         * сохраняет его в переменную (val), а затем приветствует его, вызывая функцию `sayHello`.
         * Для ввода с клавиатуры можно использовать функцию `Console.ReadLine()!`.
         */
        internal static void HelloUser()
        {
            SayHello(Console.ReadLine());
        }

        /*
         * Задание 1.3. Напишите функцию `square`, которая запрашивает у пользователя целое число
         * и печатает его квадрат. Как преобразовать число в строку, можно посмотреть в руководстве
         * https://docs.microsoft.com/ru-ru/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number
         * Вычисление квадрата числа можно производить непосредственно в шаблоне строки.
         */
        internal static void Square()
        {
            string a = Console.ReadLine();

            Console.WriteLine(Math.Pow(int.Parse(a), 2));
        }

        /*
         * Задание 1.4. Напишите функцию `sum`, которая запрашивает у пользователя два целых числа
         * (по одному в каждой строке) и печатает их сумму.
         */
        internal static void Sum()
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();

            Console.WriteLine(int.Parse(a) + int.Parse(b));
        }

        public static void Main(string[] args)
        {
            SayHello("World");
            HelloUser();
            Square();
            Sum();
        }
    }
}