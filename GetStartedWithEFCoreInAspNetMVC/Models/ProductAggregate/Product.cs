using System.ComponentModel.DataAnnotations.Schema;

namespace GetStartedWithEFCoreInAspNetMVC.Models.ProductAggregate
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Decimal Price { get; set; }
    }
}
