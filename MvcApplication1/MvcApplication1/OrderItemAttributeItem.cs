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
    
    public partial class OrderItemAttributeItem
    {
        public int Id { get; set; }
        public int OrderItemId { get; set; }
        public int AttributeItemId { get; set; }
        public string SelectionValue { get; set; }
        public decimal AttributeItemPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
    
        public virtual AttributeItem AttributeItem { get; set; }
        public virtual OrderItem OrderItem { get; set; }
    }
}