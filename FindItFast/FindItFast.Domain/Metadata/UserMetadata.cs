namespace FindItFast.Domain
{
    using System.ComponentModel.DataAnnotations;

    [MetadataType(typeof(UserMetadata))]
    public partial class User
    {
        class UserMetadata
        {
            [Display(Name ="First Name")]
            public object FirstName { get; set; }

            [Display(Name = "Last Name")]
            public object LastName { get; set; }

            [Display(Name = "Job Title")]
            public object JobTitle { get; set; }            
        }
    }

}
