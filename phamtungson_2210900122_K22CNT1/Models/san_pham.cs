//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace phamtungson_2210900122_K22CNT1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class san_pham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public san_pham()
        {
            this.chi_tiet_hoa_don = new HashSet<chi_tiet_hoa_don>();
        }
    
        public string ma_sp { get; set; }
        public string ten_sp { get; set; }
        public Nullable<decimal> gia_ban { get; set; }
        public Nullable<int> loai_sp { get; set; }
        public string gioi_tinh { get; set; }
        public string anh { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<chi_tiet_hoa_don> chi_tiet_hoa_don { get; set; }
    }
}
