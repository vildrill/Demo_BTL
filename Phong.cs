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
    
    public partial class Phong
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phong()
        {
            this.Thietbi_Phong = new HashSet<Thietbi_Phong>();
            this.Thuephongs = new HashSet<Thuephong>();
            this.Thutienphongs = new HashSet<Thutienphong>();
        }
    
        public string Ma_Phong { get; set; }
        public string Ten_Phong { get; set; }
        public string Ma_Nha { get; set; }
        public string Loai_Phong { get; set; }
        public int So_Nguoi_Toi_Da { get; set; }
        public Nullable<int> So_Nguoi_Dang_O { get; set; }
        public decimal Tien_Thue { get; set; }
        public string Ghi_Chu { get; set; }
    
        public virtual Khu_nha Khu_nha { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Thietbi_Phong> Thietbi_Phong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Thuephong> Thuephongs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Thutienphong> Thutienphongs { get; set; }
    }
}