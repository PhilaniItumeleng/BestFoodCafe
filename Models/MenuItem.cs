using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BestFoodCafe.Models
{
    public class MenuItem
    {
        
        public int Id { get; set; }       
        public int CafeId { get; set; }       
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool isAvailable { get; set; }
        public int PreperationMinutes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        //Foreign Keys
        public Cafe Cafe { get; set; }
        
        public Category Category { get; set; }
    }
}
