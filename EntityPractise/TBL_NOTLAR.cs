//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityPractise
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_NOTLAR
    {
        public int ID { get; set; }
        public Nullable<int> OGRID { get; set; }
        public Nullable<int> DERS { get; set; }
        public Nullable<short> SINAV1 { get; set; }
        public Nullable<short> SINAV2 { get; set; }
        public Nullable<short> SINAV3 { get; set; }
        public Nullable<decimal> ORTALAMA { get; set; }
        public Nullable<bool> DURUM { get; set; }
    
        public virtual TBL_DERSLER TBL_DERSLER { get; set; }
        public virtual TBL_OGRENCI TBL_OGRENCI { get; set; }
    }
}
