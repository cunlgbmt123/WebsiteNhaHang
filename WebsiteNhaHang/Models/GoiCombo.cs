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
    
    public partial class GoiCombo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GoiCombo()
        {
            this.MonAn = new HashSet<MonAn>();
        }
    
        public int MaCombo { get; set; }
        public string TenComBo { get; set; }
        public string HinhAnh { get; set; }
        public Nullable<double> Gia { get; set; }
        public string GioiThieu { get; set; }
        public Nullable<int> SoLanDat { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MonAn> MonAn { get; set; }
    }
}
