//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebsiteNhaHang.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DanhSachMonDatBan
    {
        public int MaDatBan { get; set; }
        public int MaMonAn { get; set; }
        public Nullable<int> KieuDatBan { get; set; }
        public Nullable<int> SoLuong { get; set; }
    
        public virtual DatBan DatBan { get; set; }
        public virtual KieuDatBan KieuDatBan1 { get; set; }
    }
}
