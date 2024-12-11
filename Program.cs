namespace ConsoleApp50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int randomMinNumber = 1;
            int randomMaxNumber = 101;
            int specifiedNumber1 = 3;
            int specifiedNumber2 = 5;
            Random random = new Random();
            int number = random.Next(randomMinNumber,randomMaxNumber);

            Console.WriteLine("Случайное число: " + number);

            for (int i = specifiedNumber1; i <= number; i++)
            {
                if (i % specifiedNumber1 == 0 || i % specifiedNumber2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}