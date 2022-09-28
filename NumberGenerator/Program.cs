namespace NumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random number = new Random();

            int num = number.Next(1, 10000);
            Console.WriteLine("Your pesudo random number is " + num);


            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Beep();
        }
    }
}

