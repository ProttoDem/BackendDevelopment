using Domain;

namespace Infrastructure
{
    public sealed class CategoryRepository
    {
        private CategoryRepository() 
        {
            _categories.Add(new Category(1, "category1"));
            _categories.Add(new Category(2, "category2"));
            _categories.Add(new Category(3, "category2"));
        }

        private static CategoryRepository? _instance;

        private List<Category> _categories = new List<Category>();

        public static CategoryRepository GetInstance()
        {
            if (_instance == null)
            {
                _instance = new CategoryRepository();
            }
            return _instance;
        }

        public void AddNewCategory(Category category)
        {
            _categories.Add(category);
        }

        public List<Category> Categories()
        {
            return _categories;
        }

        public Category? Category(int id)
        {
            return _categories.FirstOrDefault(i => i.Id == id);
        }
    }
}