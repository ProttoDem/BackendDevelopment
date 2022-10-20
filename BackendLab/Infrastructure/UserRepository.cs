using Domain;

namespace Infrastructure
{
    public sealed class UserRepository
    {
        private UserRepository() { }

        private static UserRepository _instance;

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
    }
}