using System.ComponentModel.DataAnnotations;

namespace FinalProje.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Display(Name = "Ad")]
        public AppUser User { get; set; }
        public int UserId { get; set; }
        [Display(Name = "Sipariş Tarihi")]
        public DateTime OrderDate { get; set; }

        [Display(Name="Sipariş Durumu")]
        
        public string Status { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
