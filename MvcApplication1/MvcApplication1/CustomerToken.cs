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
    
    public partial class CustomerToken
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Token { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime ExpiresOn { get; set; }
        public System.DateTime AccessOn { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}