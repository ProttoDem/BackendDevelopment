using Domain;

namespace Infrastructure
{
    public sealed class RecordRepository
    {
        private RecordRepository() 
        {
            _records.Add(new Record(1, 1000, 1, 1));        
            _records.Add(new Record(2, 2000, 2, 2));        
            _records.Add(new Record(3, 3000, 3, 3));        
        }

        private static RecordRepository? _instance;

        private List<Record> _records = new List<Record>();

        public static RecordRepository GetInstance()
        {
            if (_instance == null)
            {
                _instance = new RecordRepository();
            }
            return _instance;
        }

        public void AddNewRecord(Record record)
        {
            _records.Add(record);
        }

        public List<Record> Records()
        {
            return _records;
        }

        public Record? Record(int id)
        {
            return _records.FirstOrDefault(i => i.Id == id);
        }

        public List<Record>? RecordsByUserId(int userId)
        {
            return _records.FindAll(i => i.UserId == userId);
        }

        public List<Record>? RecordsByCategoryId(int categoryId)
        {
            return _records.FindAll(i => i.CategoryId == categoryId);
        }

        public List<Record>? RecordsByCategoryIdAndUserId(int categoryId, int userId)
        {
            return _records.FindAll(i => i.CategoryId == categoryId && i.UserId == userId);
        }
    }
}