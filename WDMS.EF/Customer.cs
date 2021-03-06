//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WDMS.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.Orders = new HashSet<Orders>();
        }
    
        public int CustomerId { get; set; }
        public int CustomerTypeId { get; set; }
        public string CustomerName { get; set; }
        public Nullable<int> Gender { get; set; }
        public string Mobile { get; set; }
        public Nullable<System.DateTime> FittingDate { get; set; }
        public Nullable<System.DateTime> FinalFittingDate { get; set; }
        public Nullable<System.DateTime> WeddingDate { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public int Operator { get; set; }
        public string Remark { get; set; }
    
        public virtual CustomerType CustomerType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
