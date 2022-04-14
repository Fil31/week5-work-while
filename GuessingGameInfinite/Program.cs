using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            // Игра "угадай номер"
            // Программа генерирует число от 1 до 10
            // Если юзер угадал, поздравляем с победой
            // Количество попыток угадать число неограниченно
            //*случайное число генерируется 1 раз
            int randomNumber = new Random().Next(1, 11);
            while (true)
            {
                Console.WriteLine("Я загадал число от 1 до 10, попробуй его угадать.");
                string input = Console.ReadLine();
                if (input == randomNumber.ToString())
                {
                    Console.WriteLine($"Ты угадал! Число, которое я загадал {randomNumber}!");
                    break;
                }
                Console.WriteLine("Неверно, я загадал другое число.");
            }
            Console.WriteLine("Хорошего дня.");
        }
    }
}
