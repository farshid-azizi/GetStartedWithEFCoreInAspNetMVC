using System.ComponentModel.DataAnnotations.Schema;

namespace GetStartedWithEFCoreInAspNetMVC.Models.OrderAggregate
{
    public enum OrderState
    {
        A,B,C,D,E
    }
    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerID { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public Address? Address { get; set; }
        public OrderState? OrderState { get; set; }

    }
}
