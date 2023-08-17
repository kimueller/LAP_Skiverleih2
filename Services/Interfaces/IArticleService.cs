using LAP_Skiverleih.Models;

namespace LAP_Skiverleih.Services.Interfaces
{
    public interface IArticleService
    {
        public List<Article> GetArticles();

        public void CreateArticle(Article article);

        public void UpdateArticle(Article article);

        public void DeleteArticle(Article article);

        public List<Article> GetNotLoanedArticles();

    }
}
