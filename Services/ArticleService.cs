using LAP_Skiverleih.Data;
using LAP_Skiverleih.Models;
using LAP_Skiverleih.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LAP_Skiverleih.Services
{
    public class ArticleService : IArticleService
    {
        private readonly ApplicationDbContext dbc;

        public ArticleService(ApplicationDbContext dbc) 
        {
            this.dbc = dbc;
        }

        public void CreateArticle(Article article)
        {
            dbc.Add(article);
            dbc.SaveChanges();
        }

        public void DeleteArticle(Article article)
        {
            dbc.Remove(article);
            dbc.SaveChanges();
        }

        public List<Article> GetArticles()
        {
            var articles = dbc.Articles
                           .Include(a => a.Loans)
                           .Include(a => a.Category)
                           .ToList();
            return articles;
        }

        public List<Article> GetNotLoanedArticles()
        {
            var articles = dbc.Articles
                           .Where(a => a.LoanedOut == false)
                           .ToList();
            return articles;
        }

        public void UpdateArticle(Article article)
        {
            dbc.Update(article);
            dbc.SaveChanges();
        }
    }
}
