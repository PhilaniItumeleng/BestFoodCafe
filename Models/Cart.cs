using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BestFoodCafe.Models
{
    public class Cart
    {
        [Key]
        public string Id { get; set; }
        [ForeignKey("UserId")]
        public User UserId { get; set; }

        [ForeignKey("CafeId")]
        public Cafe CafeId { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }

    }
}
