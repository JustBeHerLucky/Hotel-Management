
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
    
public partial class LOAIGIATUI
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public LOAIGIATUI()
    {

        this.LUOTGIATUI = new HashSet<LUOTGIATUI>();

    }


    public int MA_LOAIGU { get; set; }

    public string TEN_LOAIGU { get; set; }

    public Nullable<decimal> DONGIA_LOAIGU { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<LUOTGIATUI> LUOTGIATUI { get; set; }

}

}
