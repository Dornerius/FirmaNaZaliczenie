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
    
    public partial class Zespoly
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zespoly()
        {
            this.Projekty = new HashSet<Projekty>();
            this.Uzytkownicy = new HashSet<Uzytkownicy>();
            this.Zadania = new HashSet<Zadania>();
            this.Klienci1 = new HashSet<Klienci>();
        }
    
        public int IdZespolu { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public Nullable<int> IdUzytkownikaLider { get; set; }
        public Nullable<int> IdUzytkownika1 { get; set; }
        public Nullable<int> IdUzytkownika2 { get; set; }
        public Nullable<int> IdUzytkownika3 { get; set; }
        public Nullable<int> IdUzytkownika4 { get; set; }
        public Nullable<int> IdProjektu { get; set; }
        public Nullable<int> IdZadania { get; set; }
        public Nullable<int> IdKlienta { get; set; }
    
        public virtual Klienci Klienci { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Projekty> Projekty { get; set; }
        public virtual Projekty Projekty1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Uzytkownicy> Uzytkownicy { get; set; }
        public virtual Uzytkownicy Uzytkownicy1 { get; set; }
        public virtual Uzytkownicy Uzytkownicy2 { get; set; }
        public virtual Uzytkownicy Uzytkownicy3 { get; set; }
        public virtual Uzytkownicy Uzytkownicy4 { get; set; }
        public virtual Uzytkownicy Uzytkownicy5 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zadania> Zadania { get; set; }
        public virtual Zadania Zadania1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Klienci> Klienci1 { get; set; }
        public virtual Klienci Klienci2 { get; set; }
    }
}
