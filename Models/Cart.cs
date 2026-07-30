using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BestFoodCafe.Models
{
    public class Cart
    {
        
        public int Id { get; set; }
        public int UserId { get; set; }        
        public int CafeId { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        //Foreign Keys 
        public User User { get; set; }
        public Cafe Cafe { get; set; }
    }
}
