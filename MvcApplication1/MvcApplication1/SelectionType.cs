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
    
    public partial class SelectionType
    {
        public SelectionType()
        {
            this.Attributes = new HashSet<Attribute>();
            this.AttributeItems = new HashSet<AttributeItem>();
        }
    
        public int Id { get; set; }
        public string Type { get; set; }
        public string SelectionValues { get; set; }
    
        public virtual ICollection<Attribute> Attributes { get; set; }
        public virtual ICollection<AttributeItem> AttributeItems { get; set; }
    }
}
