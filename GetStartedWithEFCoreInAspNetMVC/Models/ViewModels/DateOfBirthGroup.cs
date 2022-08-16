using System.ComponentModel.DataAnnotations;

namespace GetStartedWithEFCoreInAspNetMVC.Models.ViewModels
{
    public class DateOfBirthGroup
    {
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        public int CustomerCount { get; set; }
    }
}
