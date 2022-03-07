using System;

namespace Samara
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Программа будет прибавлять два
             * числа введенные пользователем */
            Console.WriteLine("Введите ваше имя");
            String name = Console.ReadLine();
            Console.WriteLine("Здравствуйте " + name);
            int num_1;
            int num_2;
            Console.WriteLine("Введите два любых числа");
            num_1 = Convert.ToInt32(Console.ReadLine());
            num_2 = Convert.ToInt32(Console.ReadLine());
            int sum = num_1 + num_2;
            Console.Write("Сумма ваших чисел составляет " + sum);
        }
    }
}
