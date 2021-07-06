using System;
using System.Threading;

namespace InputTools
{
    public static class UIFeatures
    {
        public static void DrawSymbolLine(int time, int number, char symbol, ConsoleColor color)
        {
            Console.ForegroundColor = color;

            for (int i = 0; i < number; i++)
            {
                Console.Write(symbol);
                Thread.Sleep(time);
            }

            Console.ResetColor();
            Console.WriteLine();

        }

        public static void DrawSymbolLine(int time, int number, char symbol)
        {
            for (int i = 0; i < number; i++)
            {
                Console.Write(symbol);
                Thread.Sleep(time);
            }
            Console.WriteLine();
        }

        public static void DrawSymbolLine(int number, char symbol)
        {
            Console.WriteLine(new string(symbol, number));

        }

        public static void DrawSymbolLine(int number, char symbol, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(new string(symbol, number));
            Console.ResetColor();

        }
    }
}
