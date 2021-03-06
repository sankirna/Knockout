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
    
    public partial class Category
    {
        public Category()
        {
            this.ProductCategoryMappings = new HashSet<ProductCategoryMapping>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public Nullable<int> ParentId { get; set; }
        public byte Type { get; set; }
        public int OutletId { get; set; }
        public int DisplayOrder { get; set; }
        public bool Published { get; set; }
        public Nullable<int> OldId { get; set; }
        public Nullable<int> OldParentId { get; set; }
    
        public virtual Outlet Outlet { get; set; }
        public virtual ICollection<ProductCategoryMapping> ProductCategoryMappings { get; set; }
    }
}
