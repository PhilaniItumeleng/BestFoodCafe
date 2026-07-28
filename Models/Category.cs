using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace BestFoodCafe.Models
{
    public class Category
    {
        [Key]
        public string CategoryId { get; set; }
        [ForeignKey("CafeId")]
        public Cafe CafeId { get; set; }

        public string Name { get; set; }
        public int displayOrder { get; set; }
    }
}
