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
    
    public partial class Zadania
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public Zadania()
        //{
        //    this.Uzytkownicy1 = new HashSet<Uzytkownicy>();
        //    this.Zespoly1 = new HashSet<Zespoly>();
        //}
    
        public int IdZadania { get; set; }
        public Nullable<int> IdUzytkownika { get; set; }
        public Nullable<int> IdUzytkownika1 { get; set; }
        public Nullable<int> IdZespolu { get; set; }
        public Nullable<int> IdZespolu1 { get; set; }
        public Nullable<int> IdStatusu { get; set; }
        public string NazwaZadania { get; set; }
        public string OpicZadania { get; set; }
    
        public virtual Statusy Statusy { get; set; }        
        public virtual Uzytkownicy Uzytkownicy1 { get; set; }
        public virtual Uzytkownicy Uzytkownicy { get; set; }
        public virtual Zespoly Zespoly { get; set; }
         public virtual Zespoly Zespoly1 { get; set; }
    }
}
