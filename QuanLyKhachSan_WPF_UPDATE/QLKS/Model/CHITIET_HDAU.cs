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
    using System.Collections.Generic;
    
    public partial class CHITIET_HDAU
    {
        public int MA_CTHDAU { get; set; }
        public int MA_HD { get; set; }
        public int MA_MH { get; set; }
        public Nullable<int> SOLUONG_MH { get; set; }
        public Nullable<decimal> TRIGIA_CTHDAU { get; set; }
        public Nullable<System.DateTime> THOIGIANLAP_CTHDAU { get; set; }
        public int MA_PHONG { get; set; }
    
        public virtual MATHANG MATHANG { get; set; }
        public virtual HOADON HOADON { get; set; }
        public virtual PHONG PHONG { get; set; }
    }
}
