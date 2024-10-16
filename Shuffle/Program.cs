namespace Shuffle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = GenerateArray(10, 0, 9);

            Console.WriteLine("Сгенерированый массив:");
            WriteNumbers(array);

            Shuffle(array);

            Console.WriteLine("\n\n" + "Перемешанный массив:");
            WriteNumbers(array);

            Console.ReadKey();
        }

        private static int[] GenerateArray(int lenght, int minNumber, int maxNumber)
        {
            int[] array = new int[lenght];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minNumber, maxNumber + 1);
            }

            return array;
        }

        private static void Shuffle(int[] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                int IndexForSwap = (random.Next(1, array.Length) + i) % array.Length;
                array = SwapNumbers(array, i, IndexForSwap);
            }
        }

        private static void WriteNumbers(int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
        }

        private static int[] SwapNumbers(int[] array, int firstIndex, int secondIndex)
        {
            if (firstIndex >= array.Length || secondIndex >= array.Length)
            {
                throw new IndexOutOfRangeException();
            }
            else if (firstIndex == secondIndex)
            {
                return array;
            }

            int numberBuffer = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = numberBuffer;

            return array;
        }
    }
}
