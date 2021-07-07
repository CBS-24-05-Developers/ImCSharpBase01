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

    public static class ProgramElementEdit
    {
        /*Метод для добавления в массив элементов нового элемента
        Случай упрощённый. Элемент добавляется только в конец массива.
        */
        public static void AddItemToArray<T>(ref T[] itemsArray, T item)
        {
            if (itemsArray is null)
            {
                itemsArray = new T[] { };
            }

            Array.Resize<T>(ref itemsArray, itemsArray.Length + 1);
            itemsArray[itemsArray.Length - 1] = item;
        }

        /*Метод для удаления элементы из массива
         * Случай упрощённый, удаляются только элементы из конца массива
         */
        public static void RemoveItemFromArray<T>(ref T[] itemsArray)
        {
            if (itemsArray.Length > 0)
                Array.Resize<T>(ref itemsArray, itemsArray.Length - 1);
        }

        public static void RemoveItemFromArray<T>(ref T[] itemsArray, T item)
        {
            if (itemsArray.Length > 0)
            {
                int indexToDelete = Array.IndexOf<T>(itemsArray, item);
                int swipeLength = itemsArray.Length - 1 - indexToDelete;

                for(int i = indexToDelete; i <= itemsArray.Length -1; i++)
                {
                    if (i < itemsArray.Length - 1)
                        itemsArray[i] = itemsArray[i + 1];
                }

                Array.Resize<T>(ref itemsArray, itemsArray.Length - 1);

            }
        }
    }
}
