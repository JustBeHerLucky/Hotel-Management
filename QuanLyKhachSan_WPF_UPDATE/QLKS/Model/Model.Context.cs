﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace QLKS.Model
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class QLKS_IS201Entities : DbContext
{
    public QLKS_IS201Entities()
        : base("name=QLKS_IS201Entities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<BAOCAODICHVU> BAOCAODICHVU { get; set; }

    public virtual DbSet<BAOCAONAM> BAOCAONAM { get; set; }

    public virtual DbSet<CHITIET_HDAU> CHITIET_HDAU { get; set; }

    public virtual DbSet<CHITIET_HDDC> CHITIET_HDDC { get; set; }

    public virtual DbSet<CHITIET_HDGU> CHITIET_HDGU { get; set; }

    public virtual DbSet<CHITIET_HDLT> CHITIET_HDLT { get; set; }

    public virtual DbSet<CHUYENDI> CHUYENDI { get; set; }

    public virtual DbSet<HOADON> HOADON { get; set; }

    public virtual DbSet<LOAIGIATUI> LOAIGIATUI { get; set; }

    public virtual DbSet<LOAIPHONG> LOAIPHONG { get; set; }

    public virtual DbSet<LUOTGIATUI> LUOTGIATUI { get; set; }

    public virtual DbSet<MATHANG> MATHANG { get; set; }

    public virtual DbSet<NHANVIEN> NHANVIEN { get; set; }

    public virtual DbSet<PHONG> PHONG { get; set; }

    public virtual DbSet<TAIKHOAN> TAIKHOAN { get; set; }

    public virtual DbSet<KHUYENMAI> KHUYENMAI { get; set; }

    public virtual DbSet<DATPHONG> DATPHONG { get; set; }

    public virtual DbSet<KHACHHANG> KHACHHANG { get; set; }

}

}

