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
    
    public partial class TaxGroup
    {
        public TaxGroup()
        {
            this.Outlets = new HashSet<Outlet>();
            this.TaxGroupItems = new HashSet<TaxGroupItem>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Deleted { get; set; }
    
        public virtual ICollection<Outlet> Outlets { get; set; }
        public virtual ICollection<TaxGroupItem> TaxGroupItems { get; set; }
    }
}
