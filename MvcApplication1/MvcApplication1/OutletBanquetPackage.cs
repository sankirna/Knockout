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
    
    public partial class OutletBanquetPackage
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Notes { get; set; }
        public int OutletId { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual Outlet Outlet { get; set; }
    }
}
