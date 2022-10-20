namespace Domain
{
    public class Record
    {
        public int Id { get; set; }
        public int Sum { get; set; }        
        public int UserId { get; set; }
        public int CategoryId { get; set; }

        public readonly DateTime CreationTime;

        public Record(int sum, int userId, int categoryId)
        {
            this.Sum = sum;
            this.UserId = userId;
            this.CategoryId = categoryId;
            CreationTime = DateTime.Now;
        }
    }
}
