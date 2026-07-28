using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BestFoodCafe.Models
{
    public class ItemOption
    {
        [Key]
        public string Id { get; set; }

        [ForeignKey("OptionGroupId")]
        public ItemOption OptionGroupId { get; set; }
        public string Name { get; set; }
        public decimal ExtraPrice { get; set; }
        public bool isAvailable { get; set; }
    }
}
