namespace StudentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentClass class1 = new StudentClass();
            Console.WriteLine("1. Creates a new student");
            Console.WriteLine("2. Prints information about a student");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Please choose from 1 to 3");
            int ch = int.Parse(Console.ReadLine());
            do
            {
                if (ch == 1)
                {
                    class1.AddAStudentToList();
                }
                else if (ch == 2)
                {
                    Console.WriteLine("Enter your student name");
                    string name = Console.ReadLine();
                    class1.FindByName(name);
                }
                else
                {
                    Console.WriteLine("Exit");
                    break;
                }
                Console.WriteLine("Please choose from 1 to 3");
                ch = int.Parse(Console.ReadLine());
            } while (true);
            Console.ReadLine();
        }
    }
}
