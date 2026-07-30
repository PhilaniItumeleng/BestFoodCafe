using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BestFoodCafe.Models
{
    public class ItemOption
    {
        public int Id { get; set; }        
        public int OptionGroupId { get; set; }
        public string Name { get; set; }
        public decimal ExtraPrice { get; set; }
        public bool isAvailable { get; set; }


        public ItemOptionGroup OptionGroup { get; set; }
    }
}
