using System;

namespace Task2
{
    public class Cone
    {
        public float Height { get; protected set; } = 0f;
        public float LowerRadius { get; protected set; } = 0f;
        public virtual void ReadFromConsole()
        {
            Console.Write("Высота: ");
            Height = float.Parse(Console.ReadLine());

            Console.Write("Радиус основания: ");
            LowerRadius = float.Parse(Console.ReadLine());
        }

        public virtual void PrintToConsole()
        {
            Console.WriteLine($"Высота: {Height}");
            Console.WriteLine($"Радиус основания: {LowerRadius}");
        }

        public virtual double CalculateV()
        {
            return 1d / 3d * Math.PI * LowerRadius * LowerRadius * Height;
        }

        public double CalculateS()
        {
            return Math.PI * LowerRadius * LowerRadius;
        }
    }
}
