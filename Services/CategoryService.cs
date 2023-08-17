using LAP_Skiverleih.Data;
using LAP_Skiverleih.Models;
using LAP_Skiverleih.Services.Interfaces;

namespace LAP_Skiverleih.Services
{
    public class CategoryService : ICategorySerivce
    {
        private readonly ApplicationDbContext dbc;

        public CategoryService(ApplicationDbContext dbc) 
        {
            this.dbc = dbc;
        }

        public void CreateCategory(Category category)
        {
            dbc.Add(category);
            dbc.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            dbc.Remove(category);
            dbc.SaveChanges();
        }

        public List<Category> GetCategories()
        {
            var categories = dbc.Categories.ToList();
            return categories;
        }

        public void UpdateCategory(Category category)
        {
            dbc.Update(category);
            dbc.SaveChanges();
        }
    }
}
