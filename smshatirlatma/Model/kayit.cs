//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace smshatirlatma.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class kayit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public kayit()
        {
            this.Borc = new HashSet<Borc>();
            this.MesajKontrol = new HashSet<MesajKontrol>();
            this.satis = new HashSet<satis>();
        }
    
        public int id { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string telefon { get; set; }
        public Nullable<System.DateTime> alim { get; set; }
        public Nullable<System.DateTime> sonrakialim { get; set; }
        public string hak { get; set; }
        public Nullable<int> smsgonderim { get; set; }
        public string smsdurum { get; set; }
        public Nullable<bool> aktif { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Borc> Borc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MesajKontrol> MesajKontrol { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<satis> satis { get; set; }
    }
}
