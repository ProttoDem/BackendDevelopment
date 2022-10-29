namespace Domain
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = "undefinedCategory";

        public Category(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
