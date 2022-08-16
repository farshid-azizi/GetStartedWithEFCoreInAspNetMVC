using System.ComponentModel.DataAnnotations.Schema;

namespace GetStartedWithEFCoreInAspNetMVC.Models.CustomerAggregate
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
