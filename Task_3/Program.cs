/*Задача 38: Задайте массив вещественных чисел.
 * Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */


namespace Task_3
{
    internal class Program
    {
        public static double[] GetArray(int size)
        {
            double [] array = new double [size];
            var random = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = random.NextDouble();
            }
            return array;
        }
        public static void PrintArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        public static double GetDiffMaxMin(double[] array)
        {
            double max = array[0];
            double min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                max = Math.Max(max, array[i]);
                min = Math.Min(min, array[i]);
            }
            return max-min;
        }

        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int arrSize = Convert.ToInt32(Console.ReadLine());
            double [] array = GetArray(arrSize);
            PrintArray(array);
            Console.WriteLine();
            Console.WriteLine($"Разница между максимальным и минимальным числом = {GetDiffMaxMin(array)}");

            double[] array_2 = { -0.5, -7.5, 3.5, 4.9, 10, -9.5 };
            PrintArray(array_2);
            Console.WriteLine($"Разница между максимальным и минимальным числом = {GetDiffMaxMin(array_2)}");

        }

    }
}