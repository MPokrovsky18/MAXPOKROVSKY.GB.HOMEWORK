using System;


namespace MAXPOKROVSKY.GB.HOMEWORK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Вас приветствует математическая программа");

            if(TryGetUserEnter(out int number))
            {
                ExecuteMath(number);
            }
            
            Console.ReadLine();
        }

        private static bool TryGetUserEnter(out int number)
        {
            Console.Write("Пожалуйста, введите неотрицательное число: ");
            number = -1;
            string userInput = Console.ReadLine();

            if (userInput == "q")
            {
                return false;
            }

            if (int.TryParse(userInput, out number) == false || number < 0)
            {
                Console.WriteLine("Некорректный ввод!");
                return false;
            }

            return true;
        }

        private static void ExecuteMath(int number)
        {
            int factorial = 1, sum = 0, maxEven = 0;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
                sum += i;

                if (i % 2 == 0 && i < number)
                {
                    maxEven = i;
                }
            }

            Console.WriteLine("Факториал равен " + factorial);
            Console.WriteLine("Сума от 1 до N равна " + sum);
            Console.WriteLine("Максимальное четное число меньше N равно " + maxEven);
        }
    }
}
