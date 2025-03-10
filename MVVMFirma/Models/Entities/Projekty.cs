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
    
    public partial class Projekty
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Projekty()
        {
            this.Klienci = new HashSet<Klienci>();
            this.Uzytkownicy1 = new HashSet<Uzytkownicy>();
            this.Zespoly1 = new HashSet<Zespoly>();
        }
    
        public int IdProjektu { get; set; }
        public Nullable<int> IdUzytkownika { get; set; }
        public Nullable<int> IdKlienta { get; set; }
        public Nullable<int> IdZespolu { get; set; }
        public Nullable<int> IdStatusu { get; set; }
        public string NazwaProjektu { get; set; }
        public Nullable<System.DateTime> DataRozpoczecia { get; set; }
        public Nullable<System.DateTime> DataZakonczenia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Klienci> Klienci { get; set; }
        public virtual Klienci Klienci1 { get; set; }
        public virtual Statusy Statusy { get; set; }
        public virtual Uzytkownicy Uzytkownicy { get; set; }
        public virtual Zespoly Zespoly { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Uzytkownicy> Uzytkownicy1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zespoly> Zespoly1 { get; set; }
    }
}
