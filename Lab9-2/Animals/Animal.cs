namespace Animals
{
    public class Animal
    {
        public string Name { get; protected set; }

        public string FavoriteFood { get; protected set; }

        protected Animal(string name, string favoriteFood)
        {
            this.Name = name;
            this.FavoriteFood = favoriteFood;
        }

        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and my favorite food is {this.FavoriteFood}";
        }
    }
    public class Cat : Animal
    {
        public Cat(string name, string favoriteFood) : base(name, favoriteFood)
        {
        }
        public override string ExplainSelf()
        {
            return base.ExplainSelf() + Environment.NewLine + "MEEOW";
        }
    }
    public class Dog : Animal
    {
        public Dog(string name, string favoriteFood) : base(name, favoriteFood)
        {
        }
        public override string ExplainSelf()
        {
            return base.ExplainSelf() + Environment.NewLine + "GRRRR";
        }
    }
}
