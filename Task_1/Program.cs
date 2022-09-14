//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

namespace Task_1
{
    internal class Program
    {
        public static int[] GetArray(int size)
        {
            var random = new Random();
            int[] array = new int [size]; 
            for (int i = 0; i < array.Length; i++)
            {
                array [i] = random.Next(100, 1000);
            }
            return array;
        }
        public static int CountEvenNumbers(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array [i] % 2 == 0) 
                {
                    Console.WriteLine(array[i]);
                    count++; 
                }
            }
            return count;
        }
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = GetArray(size);
            PrintArray(array);
            Console.WriteLine();
            Console.WriteLine($"Количество четных чисел в массиве = {CountEvenNumbers(array)}");
        }
    }
}