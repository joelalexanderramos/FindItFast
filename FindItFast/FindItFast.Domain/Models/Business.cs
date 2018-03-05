//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FindItFast.Domain.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Business
    {
        public int BusinessId { get; set; }
        public Nullable<int> ParentId { get; set; }
        public Nullable<int> ManagerId { get; set; }
        public string LegalName { get; set; }
        public string BranchCode { get; set; }
        public Nullable<int> FounderBy { get; set; }
        public Nullable<System.DateTime> FoundingDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public Nullable<int> NumberOfEmployees { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string FaxNumber { get; set; }
        public string OpeningHours { get; set; }
        public string Logo { get; set; }
        public bool IsActive { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> LastModifiedDate { get; set; }
        public Nullable<int> LastModifedDateBy { get; set; }
    }
}