using System;

namespace DigitCountChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int number2 = int.Parse(Console.ReadLine());

            bool result = HasSameDigitCount(number1, number2);

            if (result)
            {
                Console.WriteLine("Числа имеют одинаковое количество цифр.");
            }
            else
            {
                Console.WriteLine("Числа имеют разное количество цифр.");
            }
        }

        static bool HasSameDigitCount(int number1, int number2)
        {
            int digitCount1 = Math.Abs(number1).ToString().Length;
            int digitCount2 = Math.Abs(number2).ToString().Length;

            return digitCount1 == digitCount2;
        }
    }
}
