//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demo_BTL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Traphong
    {
        public string Masothue { get; set; }
        public System.DateTime Ngaytra { get; set; }
        public Nullable<decimal> Tienvipham { get; set; }
    
        public virtual Thuephong Thuephong { get; set; }
    }
}