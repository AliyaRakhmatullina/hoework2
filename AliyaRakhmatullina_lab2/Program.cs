using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliyaRakhmatullina_lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 задание. 1. Выведите на экран информацию о каждом типе данных в виде:
            //Тип данных – максимальное значение – минимальное значение
            Console.WriteLine("Задание 1");

            Console.WriteLine("Тип данных - Максимальное значение - Минимальное значение");
            Console.WriteLine($"byte - {byte.MaxValue} - {byte.MinValue}");
            Console.WriteLine($"sbyte - {sbyte.MaxValue} - {sbyte.MinValue}");
            Console.WriteLine($"short - {short.MaxValue} - {short.MinValue}");
            Console.WriteLine($"ushort - {ushort.MaxValue} - {ushort.MinValue}");
            Console.WriteLine($"int - {int.MaxValue} - {int.MinValue}");
            Console.WriteLine($"uint - {uint.MaxValue} - {uint.MinValue}");
            Console.WriteLine($"long - {long.MaxValue} - {long.MinValue}");
            Console.WriteLine($"ulong - {ulong.MaxValue} - {ulong.MinValue}");
            Console.WriteLine($"float - {float.MaxValue} - {float.MinValue}");
            Console.WriteLine($"double - {double.MaxValue} - {double.MinValue}");
            Console.WriteLine($"decimal - {decimal.MaxValue} - {decimal.MinValue}");
            Console.WriteLine($"char - {char.MinValue} - {char.MaxValue}");
            
            

            //2 задание.Напишите программу, в которой принимаются данные пользователя в виде имени,
            //города, возраста и PIN-кода. Далее сохраните все значение в соответствующей
            //переменной, а затем распечатайте всю информацию в правильном формате.
            Console.WriteLine("2 задание");

            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();

            Console.Write("Введите ваш город: ");
            string city = Console.ReadLine();

            Console.Write("Введите ваш возраст: ");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.Write("Пожалуйста, введите корректный возраст: ");
            }

            Console.Write("Введите ваш PIN-код: ");
            string pinCode = Console.ReadLine();

        
            Console.WriteLine("\nВаша информация:");
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Город: {city}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"PIN-код: {pinCode}");


            
            }


        }
    }
}
