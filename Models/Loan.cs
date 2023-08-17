using System.ComponentModel.DataAnnotations;

namespace LAP_Skiverleih.Models
{
    public class Loan
    {
        [Key]
        public int LoanID { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "No customer selected!")]
        public int ArticleID { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "No customer selected!")]
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "Loan date is required!")]
        public DateTime LoanDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        public Article Article { get; set; }    

        public Customer Customer { get; set; }

    }
}
