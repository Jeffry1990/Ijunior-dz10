namespace ConsoleApp50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int randomMinNumber = 1;
            int randomMaxNumber = 101;
            int firstDivider = 3;
            int secondDivider = 5;
            Random random = new Random();
            int number = random.Next(randomMinNumber,randomMaxNumber);

            Console.WriteLine("Случайное число: " + number);

            for (int i = firstDivider; i <= number; i++)        
            {
                if (i % firstDivider == 0 || i % secondDivider == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}