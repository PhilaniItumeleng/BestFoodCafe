using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BestFoodCafe.Models
{
    public class ItemOptionGroup
    {
        
        public int Id { get; set; }
        
        public int MenuItemId { get; set; }

        public string Name { get; set; }

        public bool isRequired { get; set; }
        public int MinSelection { get; set; }
        public int MaxSelection { get; set; }

        //Foreign Key
        public MenuItem MenuItem { get; set; }

    }
}
