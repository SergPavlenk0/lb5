using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Обычный или усечённый конус?");
            Console.WriteLine("1 - Обычный конус");
            Console.WriteLine("2 - Усечённый конус");
            Console.WriteLine();
            Console.Write("Ваш выбор: ");

            int answer = int.Parse(Console.ReadLine());

            Cone cone;
            if (answer == 1)
                cone = new Cone();
            else if (answer == 2)
                cone = new TruncatedCone();
            else
                throw new Exception("Неизвестный выбор");

            Console.WriteLine();
            Console.WriteLine("Введите параметры");
            cone.ReadFromConsole();

            Console.WriteLine();
            Console.WriteLine("Введённые параметры:");
            cone.PrintToConsole();

            Console.WriteLine();
            Console.WriteLine($"Обьем фигуры: {cone.CalculateV()}");
            Console.WriteLine($"Площадь нижнего основания: {cone.CalculateS()}");
            Console.ReadLine();
        }
    }
}
