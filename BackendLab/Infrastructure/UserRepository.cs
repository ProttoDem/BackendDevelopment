using Domain;

namespace Infrastructure
{
    public sealed class UserRepository
    {
        private UserRepository() 
        {             
            _users.Add(new User(1, "user1"));
            _users.Add(new User(2, "user2"));
            _users.Add(new User(3, "user3"));
        }

        private static UserRepository? _instance;

        private List<User> _users = new List<User>();

        public static UserRepository GetInstance()
        {
            if (_instance == null)
            {
                _instance = new UserRepository();
            }
            return _instance;
        }

        public void AddNewUser(User user)
        {
            _users.Add(user);
        }

        public List<User> Users()
        {
            return _users;
        }

        public User? User(int id)
        {
            return _users.FirstOrDefault(i => i.Id == id);
        }
    }
}