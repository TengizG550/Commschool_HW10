namespace Task2
{
    class Program
    {
        static void Main()
        {

            int number = GetInputNumber();
            GenerateMultiplicationTable(number);
        }

        private static void GenerateMultiplicationTable(int number)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string filePath = Path.Combine(currentDirectory, "output.txt");

            for (int i = 1; i <= 9; i++)
            {
                int j = 1;
                for (; j < number; j++)
                {
                    File.AppendAllText(filePath, $"{j} * {i} = {j * i} | ");
                }
                File.AppendAllText(filePath, $"{j} * {i} = {j * i}");

                File.AppendAllText(filePath, Environment.NewLine);
            }
        }

        private static int GetInputNumber()
        {
            Console.WriteLine("Enter a number");
            int inputNumber;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out inputNumber))
                {
                    return inputNumber;
                }
                else
                {
                    Console.WriteLine("Enter number correctly");

                }
            }
        }
    }
}
