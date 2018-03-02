namespace FindItFast.Domain.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [MetadataType(typeof(UserMetadata))]
    public partial class User
    {
        [Display(Name = "Full Name")]
        [NotMapped]
        public object FullName
        {
            get
            {
                return string.Format("{0} {1}", this.FirstName, this.LastName);
            }
        }

        public class UserMetadata
        {
            [Required]
            [Display(Name ="First Name")]
            public object FirstName { get; set; }

            [Required]
            [Display(Name = "Last Name")]
            public object LastName { get; set; }

            [Display(Name = "Job Title")]
            public object JobTitle { get; set; }            
        }
    }

}
