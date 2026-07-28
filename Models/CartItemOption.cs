using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BestFoodCafe.Models
{
    public class CartItemOption
    {
        [Key]
        public string Id { get; set; }

        [ForeignKey("Id")]
        public CartItem CartItemId { get; set; }

        [ForeignKey("Id")]
        public ItemOption ItemOptionId { get; set; }

        public decimal ExtraPrice { get; set; }
    }
}
