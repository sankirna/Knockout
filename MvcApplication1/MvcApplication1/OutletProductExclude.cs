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
    
    public partial class OutletProductExclude
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int OutletId { get; set; }
        public System.DateTime CreatedOn { get; set; }
    
        public virtual Outlet Outlet { get; set; }
        public virtual Product Product { get; set; }
    }
}
