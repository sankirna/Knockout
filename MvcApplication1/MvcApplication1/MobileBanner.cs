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
    
    public partial class MobileBanner
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public int DisplayOrder { get; set; }
        public string Description { get; set; }
        public int ContentTypeId { get; set; }
        public string ContentTypeValue { get; set; }
        public bool Deleted { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime ModifiedOn { get; set; }
    
        public virtual ContentType ContentType { get; set; }
    }
}
