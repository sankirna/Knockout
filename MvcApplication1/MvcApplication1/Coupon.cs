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
    
    public partial class Coupon
    {
        public Coupon()
        {
            this.CouponOrderMappings = new HashSet<CouponOrderMapping>();
            this.CouponOutletMappings = new HashSet<CouponOutletMapping>();
        }
    
        public int Id { get; set; }
        public string Code { get; set; }
        public System.DateTime ValidityStartDate { get; set; }
        public System.DateTime ValidityEndDate { get; set; }
        public int TotalAvailableCoupons { get; set; }
        public int TotalUsedCoupons { get; set; }
        public int PerCustomerCoupon { get; set; }
        public int CouponType { get; set; }
        public int Amount { get; set; }
        public decimal MinAllowedOrderAmount { get; set; }
        public bool IsApplicableForAllOutlet { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual ICollection<CouponOrderMapping> CouponOrderMappings { get; set; }
        public virtual ICollection<CouponOutletMapping> CouponOutletMappings { get; set; }
    }
}