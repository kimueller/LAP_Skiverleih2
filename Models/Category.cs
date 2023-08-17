using System.ComponentModel.DataAnnotations;

namespace LAP_Skiverleih.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "Category name is required!")]
        public string CategoryName { get; set; }

        public List<Article> Articles { get; set; }
    }
}
