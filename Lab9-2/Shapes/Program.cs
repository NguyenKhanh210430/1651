namespace Shapes
{
    class program
    {
        public static void Main(string[] args)
        {
            Animal cat = new Cat("Pesho", "Cat food");
            Animal dog = new Dog("Gosho", "Meat");

            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());
        }
    }
}