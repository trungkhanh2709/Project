//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Đồ_Án_Cuối_Kỳ___Lập_Trình_Hướng_Đối_Tượng
{
    using System;
    using System.Collections.Generic;
    
    public partial class BanAn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BanAn()
        {
            this.PhieuTamTinhHoaDon = new HashSet<PhieuTamTinhHoaDon>();
        }
    
        public int id { get; set; }
        public string Ten { get; set; }
        public string TinhTrang { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuTamTinhHoaDon> PhieuTamTinhHoaDon { get; set; }
    }
}
