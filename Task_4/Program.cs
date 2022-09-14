//Задача 37: Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.
//Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6]-> 36 21

namespace Task_4
{
    internal class Program
    {
        public static int[] GetArray(int size)
        {
            var array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(1, 100);
            }
            return array;
        }

        public static int[] MultiEvenList(int[] array)
        {
            int begin = 0;
            int end = array.Length - 1;
            int[] result = new int[array.Length / 2];
            if (array.Length % 2 == 0)
            {

                while (begin < end)
                {
                    result[begin] = array[begin] * array[end];
                    begin++;
                    end--;
                }
            }
            return result;
        }
        public static int[] MultiOddList(int[] array)
        {
            int begin = 0;
            int end = array.Length - 1;
            int[] result = new int[array.Length / 2 + 1];
            while (begin < end)
            {
                result[begin] = array[begin] * array[end];
                begin++;
                end--;
                if (begin == end)
                {
                    result[begin] = array[begin];
                    break;
                }
            }
            return result;
        }
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }

        private static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = GetArray(size);
            PrintArray(array);
            Console.WriteLine();
            if (array.Length % 2 == 0)
            {
                int[] multi1 = MultiEvenList(array);
                PrintArray(multi1);
            }

            if (array.Length % 2 == 1)
            {
                int[] multi2 = MultiOddList(array);
                PrintArray(multi2);
            }

        }
    }
}