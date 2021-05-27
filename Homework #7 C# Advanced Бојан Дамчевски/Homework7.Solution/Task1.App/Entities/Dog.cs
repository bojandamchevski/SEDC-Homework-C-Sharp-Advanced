namespace Task1.App.Entities
{
    public class Dog
    {
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Color { get; set; }

        public Dog(string name, int age, string color)
        {
            Name = name;
            Age = age;
            Color = color;
        }

        public string GetInfo()
        {
            return $"Name: {Name} Age: {Age} Color: {Color}";
        }
    }
}
