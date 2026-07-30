using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BestFoodCafe.Models
{
    public class OrderItemOption
    {
        
        public int Id { get; set; }

        public int OrderItemId { get; set; }
       
        public string OptionName { get; set; }
        public decimal ExtraPrice { get; set; }

        //Foreign Keys
        public OrderItem OrderItem { get; set; }
    }
}
