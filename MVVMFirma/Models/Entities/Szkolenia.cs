//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVVMFirma.Models.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Szkolenia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Szkolenia()
        {
            this.Uzytkownicy = new HashSet<Uzytkownicy>();
        }
    
        public int IdSzkolenia { get; set; }
        public string Nazwa { get; set; }
        public Nullable<System.DateTime> DataRozpoczecia { get; set; }
        public Nullable<System.DateTime> DataZakonczenia { get; set; }
        public string Prowadzacy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Uzytkownicy> Uzytkownicy { get; set; }
    }
}
