using BestFoodCafe.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BestFoodCafe.Models
{
    public class Payment
    {        
        public int Id { get; set; }
        
        public int OrderId { get; set; }

        public decimal Amount { get; set; }
        public DateTime PaidAt { get; set; }

        public Method Method { get; set; }
        public Status Status { get; set; }

        public DateTime CreatedAt { get; set; }

        public Order Order { get; set; }
    }
}
