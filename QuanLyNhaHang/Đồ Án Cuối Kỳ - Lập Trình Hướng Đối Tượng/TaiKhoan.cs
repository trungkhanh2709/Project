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
    
    public partial class TaiKhoan
    {
        public int id { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public Nullable<int> idnhanvien { get; set; }
        public string LoaiTaiKhoan { get; set; }
    
        public virtual NhanVien NhanVien { get; set; }
    }
}
