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
    
    public partial class LuuTienNoNXB
    {
        public int id { get; set; }
        public int iddl { get; set; }
        public int idnxb { get; set; }
        public Nullable<System.DateTime> ngay { get; set; }
        public string tienNo { get; set; }
    
        public virtual DaiLy DaiLy { get; set; }
        public virtual NhaXuatBan NhaXuatBan { get; set; }
    }
}
