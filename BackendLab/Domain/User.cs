namespace Domain
{
    public class User
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = "undefinedUser";

        public User(int id, string name)
        {
            Id = id;
             this.Name = name;
        }
    }
}