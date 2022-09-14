/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
 * Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6]-> 0*/



namespace Task_2
{
    internal class Program
    {
        public static int[] GetArray(int size)
        {
            int[] array = new int[size];
            var random = new Random();
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(-1000, 1000);
            }
            return array;
        }
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+ " ");
            }
        }

        public static int SumOddPosition(int[] array)
        {
            int sum = 0;
            for (int i = 1; i < array.Length; i = i + 2)
            {
                sum = sum + array[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int arrSize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[] array = GetArray(arrSize);   
            PrintArray(array);
            Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {SumOddPosition(array)}");
        }
    }
}