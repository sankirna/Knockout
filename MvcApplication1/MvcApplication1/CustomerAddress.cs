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
    
    public partial class CustomerAddress
    {
        public CustomerAddress()
        {
            this.Orders = new HashSet<Order>();
            this.Orders1 = new HashSet<Order>();
        }
    
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string AddressTitle { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Landmark { get; set; }
        public string Location { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Company { get; set; }
        public int Type { get; set; }
        public System.DateTime CreatedOn { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Order> Orders1 { get; set; }
    }
}
