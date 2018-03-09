namespace FindItFast.Domain.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [MetadataType(typeof(BusinessMetadata))]
    public partial class Business
    {
        public class BusinessMetadata
        {
            [Key]
            public object BusinessId { get; set; }

            [ForeignKey("User")]
            [Display(Name = "Manager")]
            public int ManagerId { get; set; }

            [Required]
            [Display(Name = "Name")]
            public object LegalName { get; set; }

            [Required]
            [Display(Name = "Branch Code")]
            public object BranchCode { get; set; }

            [Required]
            [Display(Name = "Number Of Employees")]
            public object NumberOfEmployees { get; set; }

            [Display(Name = "Business Parent")]
            public object ParentId { get; set; }

            public object Email { get; set; }

            [Display(Name = "Founder By")]
            public object FounderBy { get; set; }

            [Display(Name = "Founder Date")]
            public object FoundingDate { get; set; }

            [Display(Name = "Postal Code")]
            public object PostalCode { get; set; }

            [Display(Name = "Fax")]
            public object FaxNumber { get; set; }

            [Display(Name = "Opening Hours")]
            public object OpeningHours { get; set; }
        }
    }
}
