namespace Exercise1;

class Program
{
    static void Main(string[] args)
    {
        Dice roll = new Dice();

        Console.WriteLine("Enter the amount of sides: ");
        int side = int.Parse(Console.ReadLine());
        roll.Side = side;
        int MainNumber = roll.Roll();
        while (true)
        {
            Console.WriteLine("Enter the number you want to try: ");
            int TryNumber = int.Parse(Console.ReadLine());
            if (TryNumber == MainNumber)
            {
                Console.WriteLine("Correct number!");
                break;
            }
            else
            {
                Console.WriteLine("Wrong number!");
                break;
            }
        }


    }
}