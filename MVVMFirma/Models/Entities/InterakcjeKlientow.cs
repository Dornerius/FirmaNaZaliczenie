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
    
    public partial class InterakcjeKlientow
    {
        public int IdInerakcji { get; set; }
        public Nullable<int> IdKlienta { get; set; }
        public Nullable<int> IdTypuInterakcji { get; set; }
        public Nullable<System.DateTime> Data { get; set; }
        public string Opis { get; set; }
    
        public virtual Klienci Klienci { get; set; }
        public virtual TypyInterakcji TypyInterakcji { get; set; }
    }
}
