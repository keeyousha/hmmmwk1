using System;
using System.Linq.Expressions;

namespace Task3
{
    public class Task3
    {
        /*
         * Прежде чем приступать к выполнению заданий, допишите к ним тесты.
         */

        /*
         * Задание 3.1. Для данного вещественного x найти значение следующей функции f, принимающей значения целого типа:
         * 	        0,	если x < 0,
         * f(x) = 	1,	если x принадлежит [0, 1), [2, 3), …,
                   −1,	если x принадлежит [1, 2), [3, 4), … .
         */
        internal static double F(double x)
        {
            if (x < 0) return 0;

            if (x == 0) return 1;

            if (x % 2 <= 1) return 1;

            if (x % 2 >= 1) return -1;

            else return -2;
        }

        /*
         * Задание 3.2. Дан номер года (положительное целое число). Определить количество дней в этом году,
         * учитывая, что обычный год насчитывает 365 дней, а високосный — 366 дней. Високосным считается год,
         * делящийся на 4, за исключением тех годов, которые делятся на 100 и не делятся на 400
         * (например, годы 300, 1300 и 1900 не являются високосными, а 1200 и 2000 — являются).
         */
        internal static int NumberOfDays(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0 && year % 400 != 0)
                    return 365;

                return 366;
            }

            return 365;
        }

        /*
         * Задание 3.3. Локатор ориентирован на одну из сторон света («С» — север, «З» — запад,
         * «Ю» — юг, «В» — восток) и может принимать три цифровые команды поворота:
         * 1 — поворот налево, −1 — поворот направо, 2 — поворот на 180°.
         * Дан символ C — исходная ориентация локатора и целые числа N1 и N2 — две посланные команды.
         * Вернуть ориентацию локатора после выполнения этих команд.
         */

        /*                                 0                                                       
         *                                 С                              
         *                            +1 З-|-В -1                          
         *                                 Ю 
         *                                +2                                                                        
         */


        internal static char Rotate1(char orientation, int cmd1)
        {

            switch (cmd1)
            {

                case 1:

                    switch (orientation)
                    {

                        case 'С':

                            return 'З';
                            break;

                        case 'З':

                            return 'Ю';
                            break;

                        case 'В':

                            return 'С';
                            break;

                        case 'Ю':

                            return 'В';
                            break;

                    }
                    break;

                case -1:

                    switch (orientation)
                    {

                        case 'С':

                            return 'В';
                            break;

                        case 'З':

                            return 'С';
                            break;

                        case 'В':

                            return 'Ю';
                            break;

                        case 'Ю':

                            return 'З';
                            break;

                            break;

                    }
                    break;

                case 2:

                    switch (orientation)
                    {

                        case 'С':

                            return 'Ю';
                            break;

                        case 'З':

                            return 'В';
                            break;

                        case 'В':

                            return 'З';
                            break;

                        case 'Ю':

                            return 'С';
                            break;

                            break;

                    }
                    break;

                case 0:

                    return orientation;
                    break;

            }
            return '!';
        }
        internal static char Rotate2(char orientation, int cmd1, int cmd2)
        {

            switch (cmd2)
            {

                case 1:

                    switch (Rotate1(orientation, cmd1))
                    {

                        case 'С':

                            return 'З';
                            break;

                        case 'З':

                            return 'Ю';
                            break;

                        case 'В':

                            return 'С';
                            break;

                        case 'Ю':

                            return 'В';
                            break;

                    }
                    break;

                case -1:

                    switch (Rotate1(orientation, cmd1))
                    {

                        case 'С':

                            return 'В';
                            break;

                        case 'З':

                            return 'С';
                            break;

                        case 'В':

                            return 'Ю';
                            break;

                        case 'Ю':

                            return 'З';
                            break;

                            break;

                    }
                    break;

                case 2:

                    switch (Rotate1(orientation, cmd1))
                    {

                        case 'С':

                            return 'Ю';
                            break;

                        case 'З':

                            return 'В';
                            break;

                        case 'В':

                            return 'З';
                            break;

                        case 'Ю':

                            return 'С';
                            break;

                            break;

                    }
                    break;

                case 0:

                    return Rotate1(orientation, cmd1);
                    break;

            }
            return '!';

        }

        /*
         * Задание 3.4. Дано целое число в диапазоне 20–69, определяющее возраст (в годах).
         * Вернуть строку-описание указанного возраста, обеспечив правильное согласование
         * числа со словом «год», например: 20 — «двадцать лет», 32 — «тридцать два года»,
         * 41 — «сорок один год».
         *
         * Пожалуйста, научитесь делать такие вещи очень аккуратно. Программное обеспечение
         * переполнено некорректными с точки зрения русского языка решениями.
         */
        internal static String AgeDescription(int age)
        {
            string result;

            switch (age - (age % 10))
            {
                case 20:
                    result = "двадцать ";
                    break;
                case 30:
                    result = "тридцать ";
                    break;
                case 40:
                    result = "сорок ";
                    break;
                case 50:
                    result = "пятьдесят ";
                    break;
                case 60:
                    result = "шестьдесят ";
                    break;
                default:
                    return "err";
            }

            switch (age % 10)
            {
                case 1:
                    result += "один год";
                    break;
                case 2:
                    result += "два года";
                    break;
                case 3:
                    result += "три года";
                    break;
                case 4:
                    result += "четыре года";
                    break;
                case 5:
                    result += "пять лет";
                    break;
                case 6:
                    result += "шесть лет";
                    break;
                case 7:
                    result += "семь лет";
                    break;
                case 8:
                    result += "восемь лет";
                    break;
                case 9:
                    result += "девять лет";
                    break;
                case 0:
                    result += "лет";
                    break;
                default:
                    return "err";
            }

            return result;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(F(0));
            Console.WriteLine(NumberOfDays(1332));
            Console.WriteLine(Rotate2('С', -1, 1));
            Console.WriteLine(AgeDescription(25));
        }
    }
}