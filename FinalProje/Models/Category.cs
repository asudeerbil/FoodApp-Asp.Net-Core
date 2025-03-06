using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FinalProje.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Display(Name = "Kategori Adı")]
        [Required(ErrorMessage = "Bu Alan Boş Bırakılmaz")]
        public string? CategoryName { get; set; }
        virtual public List<Products>? Products { get; set; }
    }
}
