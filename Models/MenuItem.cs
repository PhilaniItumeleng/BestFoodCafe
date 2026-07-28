using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BestFoodCafe.Models
{
    public class MenuItem
    {
        [Key]
        public string Id { get; set; }
        [ForeignKey("CafeId")]
        public Cafe CafeId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool isAvailable { get; set; }
        public int PreperationMinutes { get; set; }
       

    }
}
