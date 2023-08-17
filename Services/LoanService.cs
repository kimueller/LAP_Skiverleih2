using LAP_Skiverleih.Data;
using LAP_Skiverleih.Models;
using LAP_Skiverleih.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LAP_Skiverleih.Services
{
    public class LoanService : ILoanService
    {
        private readonly ApplicationDbContext dbc;

        public LoanService(ApplicationDbContext dbc) 
        {
            this.dbc = dbc;
        }

        public void CreateLoan(Loan loan)
        {
            dbc.Add(loan);
            dbc.SaveChanges();
        }

        public void DeleteLoan(Loan loan)
        {
            dbc.Remove(loan);
            var article = dbc.Articles
                          .Include(a => a.Loans)
                          .Where(a => a.ArticleID == loan.ArticleID)
                          .FirstOrDefault();
            article.LoanCount--;
            dbc.SaveChanges();
        }

        public List<Loan> GetLoans()
        {
            var loans = dbc.Loans
                        .Include(l => l.Article)
                        .Include(l => l.Customer)
                        .ToList();
            return loans;
        }

        public void UpdateLoan(Loan loan)
        {
            dbc.Update(loan);
            dbc.SaveChanges();
        }
    }
}
