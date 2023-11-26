using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp89
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 2, 8, 6, 2, 10, 4, 8, 7 };

            Console.WriteLine("Початковий масив:");
            PrintArray(array);

            // Видалення повторюючихся значень
            array = RemoveDuplicates(array);
            Console.WriteLine("\nМасив після видалення дубльованих значень:");
            PrintArray(array);

            // Сортування масиву
            Array.Sort(array);
            Console.WriteLine("\nМасив після сортування:");
            PrintArray(array);

            // Бінарний пошук певного значення
            int searchValue = 8;
            int index = BinarySearch(array, searchValue);

            if (index != -1)
                Console.WriteLine($"\nЗначення {searchValue} знайдено на позиції {index}.");
            else
                Console.WriteLine($"\nЗначення {searchValue} не знайдено в масиві.");
            Console.ReadLine();
        }
        // Функція для видалення повторюючихся значень
        static int[] RemoveDuplicates(int[] array)
        {
            return Array.FindAll(array, x => Array.IndexOf(array, x) == Array.LastIndexOf(array, x));
        }

        // Функція для бінарного пошуку
        static int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == target)
                    return mid;

                if (array[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1; // Значення не знайдено
        }

        // Функція для виведення масиву на екран
        static void PrintArray(int[] array)
        {
            foreach (var element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}
