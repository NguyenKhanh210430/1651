namespace Ex4;

class Program
{
    public static void Main(string[] args)
    {
        Total total = new Total();
        Console.WriteLine("Room price");
        total.Price = float.Parse(Console.ReadLine());
        Console.WriteLine("Days");
        total.Days = int.Parse(Console.ReadLine());
        Console.WriteLine("Room Type");
        string roomtype = Console.ReadLine();
        if (roomtype == "Normal")
        {
            total.RoomType = RoomType.Normal;
        }
        else if (roomtype == "Vip")
        {
            total.RoomType = RoomType.Vip;
        }
        else if (roomtype == "Luxury")
        {
            total.RoomType = RoomType.Luxury;
        }
        else if (roomtype == "President")
        {
            total.RoomType = RoomType.President;
        }
        float price = total.CalculatePrice(total.Price,
                                                     total.Days,
                                                     total.RoomType
                                                     );
        Console.WriteLine("Total: " + price);
    }
}


