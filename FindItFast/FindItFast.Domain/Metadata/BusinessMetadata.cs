namespace FindItFast.Domain.Models
{
    using System.ComponentModel.DataAnnotations;

    [MetadataType(typeof(BusinessMetadata))]
    public partial class Business
    {
        public class BusinessMetadata
        {
            [Key]
            public object BusinessId { get; set; }

            [Required]
            [Display(Name = "Name")]
            public object LegalName { get; set; }

            [Required]
            [Display(Name = "Branch Code")]
            public object BranchCode { get; set; }

            [Required]
            [Display(Name = "Number Of Employees")]
            public object NumberOfEmployees { get; set; }
        }
    }
}
