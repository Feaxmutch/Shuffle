namespace Shuffle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = GenerateNumbers(10, 0, 9);

            Console.WriteLine("Сгенерированый массив:");
            WriteNumbers(numbers);

            Shuffle(numbers);

            Console.WriteLine("\n\n" + "Перемешанный массив:");
            WriteNumbers(numbers);

            Console.ReadKey();
        }

        private static int[] GenerateNumbers(int lenght, int minNumber, int maxNumber)
        {
            int[] array = new int[lenght];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(minNumber, maxNumber + 1);
            }

            return array;
        }

        private static void Shuffle(int[] numbers)
        {
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                int randomIndex = random.Next(0, numbers.Length);
                SwapNumbers(numbers, i, randomIndex);
            }
        }

        private static void WriteNumbers(int[] numbers)
        {
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
        }

        private static void SwapNumbers(int[] array, int firstIndex, int secondIndex)
        {
            int numberBuffer = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = numberBuffer;
        }
    }
}
