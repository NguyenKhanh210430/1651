namespace Ex4
{
    internal class Total
    {
        public float Price { get; set; }
        public int Days { get; set; }
        public RoomType RoomType { get; set; }

        public float CalculatePrice(float pricePerDay, int days, RoomType roomtype)
        {
            int mulitplier = (int)roomtype;
            float price = days * pricePerDay * mulitplier;
            return price;
        }
    }

    public enum RoomType
    {
        Normal = 1,
        Vip = 3,
        Luxury = 5,
        President = 10
    }
}
