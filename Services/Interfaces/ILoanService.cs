using LAP_Skiverleih.Models;

namespace LAP_Skiverleih.Services.Interfaces
{
    public interface ILoanService
    {
        public List<Loan> GetLoans();

        public void CreateLoan(Loan loan);

        public void UpdateLoan(Loan loan);

        public void DeleteLoan(Loan loan);

    }
}
