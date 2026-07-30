using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace BestFoodCafe.Models
{
    public class Category
    {
        
        public int CategoryId { get; set; }
        [ForeignKey("Cafe")]
        public Cafe CafeId { get; set; }

        public string Name { get; set; }
        public int displayOrder { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
