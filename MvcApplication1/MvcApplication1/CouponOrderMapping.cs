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
    
    public partial class CouponOrderMapping
    {
        public int Id { get; set; }
        public int CouponId { get; set; }
        public int CustomerId { get; set; }
        public int OrderId { get; set; }
    
        public virtual Coupon Coupon { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Order Order { get; set; }
    }
}