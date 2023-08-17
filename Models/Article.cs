using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LAP_Skiverleih.Models
{
    public class Article
    {
        [Key]
        public int ArticleID { get; set; }

        [Required(ErrorMessage = "Title is required!")]
        [StringLength(100)]
        public string Title { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }

        [Required(ErrorMessage = "Price per day is required! Format(7,2)")]
        [Column(TypeName = "decimal(7, 2)")]
        public decimal PricePerDay { get; set; }

        public int LoanCount { get; set; }

        public bool LoanedOut { get; set; }


        public List<Loan> Loans { get; set; }
    }
}
