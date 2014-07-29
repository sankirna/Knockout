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
    
    public partial class Attribute
    {
        public Attribute()
        {
            this.AttributeGroupItems = new HashSet<AttributeGroupItem>();
            this.AttributeItems = new HashSet<AttributeItem>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int SelectionTypeId { get; set; }
        public int OutletId { get; set; }
        public Nullable<byte> AttributeTypeId { get; set; }
        public bool Published { get; set; }
        public bool Deleted { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime ModifiedOn { get; set; }
    
        public virtual AttributeType AttributeType { get; set; }
        public virtual Outlet Outlet { get; set; }
        public virtual SelectionType SelectionType { get; set; }
        public virtual ICollection<AttributeGroupItem> AttributeGroupItems { get; set; }
        public virtual ICollection<AttributeItem> AttributeItems { get; set; }
    }
}