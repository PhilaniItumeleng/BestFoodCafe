using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BestFoodCafe.Models
{
    public class CartItem
    {
        [Key]
        public string Id { get; set; }
        [ForeignKey("CartId")]
        public Cart CartId { get; set; }

        [ForeignKey("MenuItemId")]
        public MenuItem MenuItemId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public string Title { get; set; }



    }
}
