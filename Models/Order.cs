using BestFoodCafe.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BestFoodCafe.Models
{
    public class Order
    {
        
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public string PickupCode { get; set; }
        
        public int UserId { get; set; }
        public int CafeId { get; set; }
        
        public decimal SubTotal { get; set; }
        public decimal Total { get; set; }
        public DateTime PickupTime { get; set; }
        public DateTime EstimatedReadyTime { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        //Enums
        public Status Status { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        


        //Foreign Keys
        public Cafe Cafe { get; set; }
        public User User { get; set; }
    }
}
