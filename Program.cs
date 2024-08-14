using System;

namespace TaskJunior5
{
    class Program
    {
        static void Main(string[] args)
        {
            string coffee = "кофе";
            string tea = "чай";
            string temporaryBufferForCoffee = tea;

            Console.WriteLine("Приветствую тебя дорогой пользователь, что решился на тестирование номой программе про замене жидкостей в стаканах" +
                              "\nу нас имеется 2 жидкости и 2 стакана, а именно:\n\n - кружка с кофе\n - кружка с чаем\n");
            Console.WriteLine($"Неправельное содерживое в чашке с кофе, а именно {tea}");
            Console.WriteLine($"Неправельное содерживое в чашке с чаем, а именно {coffee}\n\n");
            Console.WriteLine("Меняем содержимое чашек в правельный\n\n");

            tea = coffee;
            coffee = temporaryBufferForCoffee;

            Console.WriteLine($"Правельное содерживое в чашке с кофе, а именно {tea}");
            Console.WriteLine($"Правельное содерживое в чашке с чаем, а именно {coffee}");
        }
    }
}
