using System.ComponentModel.DataAnnotations;

namespace BestFoodCafe.Models
{
    public class Cafe
    {
        [Key]
        public string CafeId { get; set; }
        public string LocationDescription{ get; set; }
        public TimeOnly openingTime { get; set; }
        public TimeOnly closingTime { get; set; }
        public string imageUrl { get; set; }
        public bool isOpen { get; set; }
        
    }
}
