using System.ComponentModel.DataAnnotations;

namespace LAP_Skiverleih.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "First name is required!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required!")]
        public string LastName { get; set; }

        public List<Loan> Loans { get; set; }

    }
}
