//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Taixevaxe
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ve
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ve()
        {
            this.HoaDons = new HashSet<HoaDon>();
        }
    
        public string MaVe { get; set; }
        public string Ghe { get; set; }
        public string MaXe { get; set; }
        public string GiaVe { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDons { get; set; }
        public virtual XE XE { get; set; }
    }
}