//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Restaurant
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int OrderID { get; set; }
        public Nullable<int> TabNum { get; set; }
        public Nullable<System.DateTime> OrderDatetime { get; set; }
        public Nullable<int> OrderTotal { get; set; }
        public Nullable<bool> OrderStatus { get; set; }
    }
}
