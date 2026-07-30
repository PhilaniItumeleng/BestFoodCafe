using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BestFoodCafe.Models
{
    public class Review
    {
        
        public int Id { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Cafe")]
        public int CafeId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }

        public DateTime CreatedAt { get; set; }

        public User User { get; set; }
        public Cafe Cafe { get; set; }

    }
}
