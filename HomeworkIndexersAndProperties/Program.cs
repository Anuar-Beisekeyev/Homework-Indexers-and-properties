using System;

namespace HomeworkIndexersAndProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();            
            bool isItInt; 
            int start = 0, end = 1;           

            do
            {
                Console.Write("Введите начало диапазона: ");
                isItInt = int.TryParse(Console.ReadLine(), out start);
                if (!isItInt)
                {
                    Console.WriteLine("Не верный ввод.");
                }

            } while (!isItInt);

            do
            {
                Console.Write("Введите конец диапазона: ");
                isItInt = int.TryParse(Console.ReadLine(), out end);

                if (!isItInt || start > end)
                {
                    Console.WriteLine("Не верный ввод.");
                }

            } while (!isItInt || start > end);

            RangeOfArray array = new RangeOfArray(start, end);

            for (int i = start; i <= end; i++)
            {
                array[i] = random.Next(0, 100);
                Console.WriteLine($"Массив целых чисел[{i}] = {array[i]}");
            }

            Console.ReadLine();
        }
    }
}
