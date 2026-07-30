using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BestFoodCafe.Models
{
    public class CartItem
    {
        
        public int Id { get; set; }
        public int CartId { get; set; }
        public int MenuItemId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public string Title { get; set; }

        public DateTime CreatedAt { get; set; }


        //Foreign Keys 
        public Cart Cart{ get; set; }
        public MenuItem MenuItem { get; set; }
    }
}
