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
    
    public partial class OrderDetails
    {
        public int OrderDatailId { get; set; }
        public int OrderBatchId { get; set; }
        public string OrderType { get; set; }
        public int InventoryId { get; set; }
        public string DeliveryWay { get; set; }
        public string ExpressNo { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Status { get; set; }
        public System.DateTime CreateTime { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public string Remark { get; set; }
    
        public virtual Inventory Inventory { get; set; }
        public virtual Orders Orders { get; set; }
    }
}
