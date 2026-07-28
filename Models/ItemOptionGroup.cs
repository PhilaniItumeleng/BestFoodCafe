using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BestFoodCafe.Models
{
    public class ItemOptionGroup
    {
        [Key]
        public string Id { get; set; }

        [ForeignKey("MenuItemId")]
        public MenuItem MenuItemId { get; set; }

        public string Name { get; set; }

        public bool isRequired { get; set; }
        public int MinSelection { get; set; }
        public int MaxSelection { get; set; }

    }
}
