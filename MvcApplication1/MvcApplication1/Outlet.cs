//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Outlet
    {
        public Outlet()
        {
            this.Attributes = new HashSet<Attribute>();
            this.AttributeGroups = new HashSet<AttributeGroup>();
            this.Categories = new HashSet<Category>();
            this.CouponOutletMappings = new HashSet<CouponOutletMapping>();
            this.CustomerHistories = new HashSet<CustomerHistory>();
            this.Orders = new HashSet<Order>();
            this.OutletBanquets = new HashSet<OutletBanquet>();
            this.OutletBanquetPackages = new HashSet<OutletBanquetPackage>();
            this.OutletBuffets = new HashSet<OutletBuffet>();
            this.OutletContacts = new HashSet<OutletContact>();
            this.OutletCuisineMappings = new HashSet<OutletCuisineMapping>();
            this.OutletDetails = new HashSet<OutletDetail>();
            this.OutletFacilityMappings = new HashSet<OutletFacilityMapping>();
            this.OutletFixedMeals = new HashSet<OutletFixedMeal>();
            this.OutletImageGallaries = new HashSet<OutletImageGallary>();
            this.OutletMedias = new HashSet<OutletMedia>();
            this.OutletOffers = new HashSet<OutletOffer>();
            this.OutletTimings = new HashSet<OutletTiming>();
            this.OutletProductExcludes = new HashSet<OutletProductExclude>();
            this.OutletRatings = new HashSet<OutletRating>();
            this.Products = new HashSet<Product>();
            this.Customers = new HashSet<Customer>();
            this.Customers1 = new HashSet<Customer>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> ParentId { get; set; }
        public string SeoName { get; set; }
        public string ShortCode { get; set; }
        public int LocationId { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public bool IsVeg { get; set; }
        public bool IsNonVeg { get; set; }
        public bool IsAlaCarte { get; set; }
        public bool IsBuffet { get; set; }
        public bool IsFixedMeal { get; set; }
        public bool IsTableBooking { get; set; }
        public bool IsOnlineOrder { get; set; }
        public bool IsTakeAway { get; set; }
        public string TakeAwayTime { get; set; }
        public string TakeAwayCondition { get; set; }
        public bool IsHomeDelivery { get; set; }
        public Nullable<decimal> HomeDeliveryAmount { get; set; }
        public Nullable<int> HomeDeliveryDistance { get; set; }
        public string HomeDeliveryTime { get; set; }
        public Nullable<decimal> HomeDeliveryCharge { get; set; }
        public string HomeDeliveryCondition { get; set; }
        public Nullable<decimal> Rating { get; set; }
        public string Logo { get; set; }
        public bool Published { get; set; }
        public bool Deleted { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public Nullable<int> TaxGroupId { get; set; }
        public string Banner { get; set; }
    
        public virtual ICollection<Attribute> Attributes { get; set; }
        public virtual ICollection<AttributeGroup> AttributeGroups { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<CouponOutletMapping> CouponOutletMappings { get; set; }
        public virtual ICollection<CustomerHistory> CustomerHistories { get; set; }
        public virtual Location Location { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual TaxGroup TaxGroup { get; set; }
        public virtual ICollection<OutletBanquet> OutletBanquets { get; set; }
        public virtual ICollection<OutletBanquetPackage> OutletBanquetPackages { get; set; }
        public virtual ICollection<OutletBuffet> OutletBuffets { get; set; }
        public virtual ICollection<OutletContact> OutletContacts { get; set; }
        public virtual ICollection<OutletCuisineMapping> OutletCuisineMappings { get; set; }
        public virtual ICollection<OutletDetail> OutletDetails { get; set; }
        public virtual ICollection<OutletFacilityMapping> OutletFacilityMappings { get; set; }
        public virtual ICollection<OutletFixedMeal> OutletFixedMeals { get; set; }
        public virtual ICollection<OutletImageGallary> OutletImageGallaries { get; set; }
        public virtual ICollection<OutletMedia> OutletMedias { get; set; }
        public virtual ICollection<OutletOffer> OutletOffers { get; set; }
        public virtual ICollection<OutletTiming> OutletTimings { get; set; }
        public virtual ICollection<OutletProductExclude> OutletProductExcludes { get; set; }
        public virtual ICollection<OutletRating> OutletRatings { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Customer> Customers1 { get; set; }
    }
}
