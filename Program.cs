namespace ConsoleApp50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int randomMinNumber = 1;
            int randomMaxNumber = 101;
            int firstDivider1 = 3;
            int firstDivider2 = 5;
            Random random = new Random();
            int number = random.Next(randomMinNumber,randomMaxNumber);

            Console.WriteLine("Случайное число: " + number);

            for (int i = firstDivider1; i <= number; i++)        
            {
                if (i % firstDivider1 == 0 || i % firstDivider2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}