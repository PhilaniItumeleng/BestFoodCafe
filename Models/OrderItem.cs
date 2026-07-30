using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BestFoodCafe.Models
{
    public class OrderItem
    {
        
        public int Id { get; set; }
         
        public int OrderId { get; set; }
        public int MenuItemId { get; set; }
        public string MenuItemName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }


        //Foreign Keys
        public Order Order { get; set; }
        public MenuItem MenuItem { get; set; }
    }
}
