﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MuaBanSachEntities1 : DbContext
    {
        public MuaBanSachEntities1()
            : base("name=MuaBanSachEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ChiTietSach> ChiTietSaches { get; set; }
        public virtual DbSet<ChiTietSachDaiLyLay> ChiTietSachDaiLyLays { get; set; }
        public virtual DbSet<ChiTietSachNXBNhap> ChiTietSachNXBNhaps { get; set; }
        public virtual DbSet<CTHoaDonBan> CTHoaDonBans { get; set; }
        public virtual DbSet<CTHoaDonNhap> CTHoaDonNhaps { get; set; }
        public virtual DbSet<DaiLy> DaiLies { get; set; }
        public virtual DbSet<HoaDonBan> HoaDonBans { get; set; }
        public virtual DbSet<HoaDonNhap> HoaDonNhaps { get; set; }
        public virtual DbSet<LinhVuc> LinhVucs { get; set; }
        public virtual DbSet<NhaXuatBan> NhaXuatBans { get; set; }
        public virtual DbSet<Sach> Saches { get; set; }
        public virtual DbSet<LuuTienNoNXB> LuuTienNoNXBs { get; set; }
    }
}
