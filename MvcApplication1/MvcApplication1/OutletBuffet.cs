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
    
    public partial class OutletBuffet
    {
        public int Id { get; set; }
        public int OutletId { get; set; }
        public int DineType { get; set; }
        public Nullable<System.DateTime> SpecificDate { get; set; }
        public System.TimeSpan StartTime { get; set; }
        public System.TimeSpan EndTime { get; set; }
        public Nullable<int> Weekday { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Nullable<decimal> NonVegPrice { get; set; }
        public string Note { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime ModifiedOn { get; set; }
    
        public virtual Outlet Outlet { get; set; }
    }
}