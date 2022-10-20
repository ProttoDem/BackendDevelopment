namespace Domain
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = "undefinedCategory";

        public Category(string name)
        {
            this.Name = name;
        }
    }
}
