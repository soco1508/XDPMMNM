//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sach
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sach()
        {
            this.ChiTietSachDaiLyLays = new HashSet<ChiTietSachDaiLyLay>();
            this.ChiTietSachNXBNhaps = new HashSet<ChiTietSachNXBNhap>();
            this.CTHoaDonBans = new HashSet<CTHoaDonBan>();
            this.CTHoaDonNhaps = new HashSet<CTHoaDonNhap>();
        }
    
        public int idSach { get; set; }
        public int idLV { get; set; }
        public string tenSach { get; set; }
        public Nullable<int> soLuong { get; set; }
        public string donGiaBan { get; set; }
        public string donGiaNhap { get; set; }
        public int idCTSach { get; set; }
    
        public virtual ChiTietSach ChiTietSach { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietSachDaiLyLay> ChiTietSachDaiLyLays { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietSachNXBNhap> ChiTietSachNXBNhaps { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHoaDonBan> CTHoaDonBans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHoaDonNhap> CTHoaDonNhaps { get; set; }
        public virtual LinhVuc LinhVuc { get; set; }
    }
}
