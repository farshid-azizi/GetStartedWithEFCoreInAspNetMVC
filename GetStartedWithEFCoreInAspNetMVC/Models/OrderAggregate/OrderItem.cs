namespace GetStartedWithEFCoreInAspNetMVC.Models.OrderAggregate
{
    public class OrderItem
    {

        public int OrderItemID { get; set; }
        public int ProductID { get; set; }
        public int OrderId { get; set; }
        public Order? Order { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }

    }
}