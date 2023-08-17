using LAP_Skiverleih.Models;

namespace LAP_Skiverleih.Services.Interfaces
{
    public interface ICategorySerivce
    {
        public List<Category> GetCategories();

        public void CreateCategory(Category category);

        public void UpdateCategory(Category category);

        public void DeleteCategory(Category category);

    }
}
