using System;

namespace Task4
{
    public class Task4
    {
        /*
         * В решениях следующих заданий предполагается использование циклов.
         */

        /*
         * Задание 4.1. Пользуясь циклом for, посимвольно напечатайте рамку размера width x height,
         * состоящую из символов frameChar. Можно считать, что width>=2, height>=2.
         * Например, вызов printFrame(5,3,'+') должен напечатать следующее:

        +++++
        +   +
        +++++
         */
        internal static void PrintFrame(int width, int height, char frameChar = '*') //'*' - означает что это будет печатать если не будет введен свой символ?
        {
            for (int i = 0; i < width; i++)
                Console.Write(frameChar);

            Console.Write("\n");

            for (int i = 0; i < height - 2; i++)
            {
                for (int j = 0; j < width; j++)
                {

                    if (j == 0 || j == width - 1)
                        Console.Write(frameChar);

                    else Console.Write(" ");

                }
                Console.Write("\n");
            }

            for (int i = 0; i < width; i++)
                Console.Write(frameChar);


        }

        /*
         * Задание 4.2. Выполните предыдущее задание, пользуясь циклом while.
         */
        internal static void PrintFrame2(int width, int height, char frameChar = '*')
        {
            int i = 0;
            while (i < width)
            {
                Console.Write(frameChar);
                ++i;
            }

            Console.Write("\n");

            int j = 0;
            while (j < height - 2)
            {

                int k = 0;
                while (k < width)
                {

                    if (k == 0 || k == width - 1)
                        Console.Write(frameChar);
                    else Console.Write(" ");
                    ++k;

                }

                Console.Write("\n");
                ++j;
            }

            i = 0;
            while (i < width)
            {

                Console.Write(frameChar);
                ++i;

            }
        }


        /*
         * Задание 4.3. Даны целые положительные числа A и B. Найти их наибольший общий делитель (НОД),
         * используя алгоритм Евклида:
         * НОД(A, B) = НОД(B, A mod B),    если B ≠ 0;        НОД(A, 0) = A,
         * где «mod» обозначает операцию взятия остатка от деления.
         */
        internal static long Gcd(long a, long b)
        {
            if (b == 0)
                return a;

            else
                return Gcd(b, a % b);
        }

        /*
         * Задание 4.4. Дано вещественное число X и целое число N (> 0). Найти значение выражения
         * 1 + X + X^2/(2!) + … + X^N/(N!), где N! = 1·2·…·N.
         * Полученное число является приближенным значением функции exp в точке X.
         */
        internal static double ExpTaylor(double x, int n)
        {
            double result = 1 + x;

            for (int i = 2; i <= n; i++)

                result += Math.Pow(x, i) / (Factorial(i)); // ничё не понимаю..

            return result;
        }

        internal static long Factorial(double n)
        {
            if (n == 0) return 1;
            long q = 1;

            for (int i = 1; i < n + 1; i++)
                q *= i;

            return q;
        }

        public static void Main(string[] args)
        {
            PrintFrame(5, 3, '+');
            Console.Write("\n");
            PrintFrame2(5, 3, '-');
            Console.Write("\n");
            Console.WriteLine(ExpTaylor(1.0, 10));
            Console.WriteLine(Gcd(18, 66));

        }
    }
}