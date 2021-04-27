using System;

namespace Lab1
{
    class Program
    {
        static void ex1()
        {
            string inputString = null;


            Console.ForegroundColor = (ConsoleColor)new Random().Next(1, 7);
            Console.BackgroundColor = (ConsoleColor)new Random().Next(8, 15);
            Console.Clear();

            Console.Beep(440, 300);

            Console.WriteLine("WindowWidth: {0}", Console.WindowWidth);
            Console.WriteLine("WindowHeight: {0}", Console.WindowHeight);

            Console.CursorVisible = false;

            Console.WriteLine("What is your name?");


            inputString = Console.ReadLine();
            Console.WriteLine("Hello, " + inputString);

            Console.Title = (inputString);

            Console.SetWindowSize(50, 50);
            Console.WriteLine("WindowWidth: {0}", Console.WindowWidth);
            Console.WriteLine("WindowHeight: {0}", Console.WindowHeight);

            Console.WriteLine("Is CAPS LOCK on: {0}", Console.CapsLock);
            Console.WriteLine("Is NUMBER LOCK on: {0}", Console.NumberLock);

            Console.CursorVisible = true;
            Console.ReadLine();
        }
        static void ex2()
        {
            double area;
            Console.WriteLine("Input trapezoid area: ");

            while (!double.TryParse(Console.ReadLine(), out area) || area < 0)
            {
                Console.WriteLine("Input positive number!");
            };

            
            Console.WriteLine("Input trapezoid height: ");
            double height;
            while (!double.TryParse(Console.ReadLine(), out height) || height < 0)
            {
                Console.WriteLine("Input positive number!");

            };      

            string aspectRation = "3";

            Console.WriteLine("Trapezoid area: " + area);
            
            Console.WriteLine("Trapezoid height: " + height);
            double k = Convert.ToDouble(aspectRation);

            double sum = 2 * area / height;
            Console.WriteLine("a+b=" + sum);

            double x = sum / (k + 1);
            double a = x * k;
            double b = x;
            Console.WriteLine("Side a: " + a);
            Console.WriteLine("Side b: " + b);
        }
        static void Main(string[] args)
        {
            ex1();
            //ex2();    
        }
             
    }
}
