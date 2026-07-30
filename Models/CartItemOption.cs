using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BestFoodCafe.Models
{
    public class CartItemOption
    {
        
        public int Id { get; set; }
        public decimal ExtraPrice { get; set; }
        public int CartItemId { get; set; }
        public int ItemOptionId { get; set; }


        //Foreign Keys
        public CartItem CartItem { get; set; }       
        public ItemOption ItemOption { get; set; }
    }
}
