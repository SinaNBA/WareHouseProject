//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Receives
    {
        public System.Guid Id { get; set; }
        public System.Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public System.DateTime ReceiveTime { get; set; }
        public int StaffId { get; set; }
        public Nullable<int> SupplierId { get; set; }
    
        public virtual Staffs Staffs { get; set; }
        public virtual Suppliers Suppliers { get; set; }
        public virtual Products Products { get; set; }
    }
}
