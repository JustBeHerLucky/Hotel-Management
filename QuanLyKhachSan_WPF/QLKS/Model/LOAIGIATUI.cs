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
    using QLKS.ViewModel;
    using System;
    using System.Collections.Generic;
    
    public partial class LOAIGIATUI : BaseViewModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAIGIATUI()
        {
            this.LUOTGIATUI = new HashSet<LUOTGIATUI>();
        }

        private int _MA_LOAIGU;
        public int MA_LOAIGU { get => _MA_LOAIGU; set { _MA_LOAIGU = value; OnPropertyChanged(); } }
        private string _TEN_LOAIGU;
        public string TEN_LOAIGU { get => _TEN_LOAIGU; set { _TEN_LOAIGU = value; OnPropertyChanged(); } }
        private Nullable<decimal> _DONGIA_LOAIGU;
        public Nullable<decimal> DONGIA_LOAIGU { get => _DONGIA_LOAIGU; set { _DONGIA_LOAIGU = value; OnPropertyChanged(); } }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LUOTGIATUI> LUOTGIATUI { get; set; }
    }
}