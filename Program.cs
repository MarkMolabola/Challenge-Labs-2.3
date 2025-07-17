namespace Challenge_Labs_2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter the desired width: ");
            int desiredWidth = int.Parse(Console.ReadLine());

            for (int i = desiredWidth; i != 0; i--)
            {
                for (int j = desiredWidth; j != 0; --j)
                { 
                    Console.Write(number);
                }
                desiredWidth--;
                Console.WriteLine("\n");

            }

        }
    }

}
