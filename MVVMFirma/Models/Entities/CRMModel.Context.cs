﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BazaCRMEntities : DbContext
    {
        public BazaCRMEntities()
            : base("name=BazaCRMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Faktury> Faktury { get; set; }
        public virtual DbSet<InterakcjeKlientow> InterakcjeKlientow { get; set; }
        public virtual DbSet<Klienci> Klienci { get; set; }
        public virtual DbSet<LogiSystemowe> LogiSystemowe { get; set; }
        public virtual DbSet<ProduktyUslugi> ProduktyUslugi { get; set; }
        public virtual DbSet<Projekty> Projekty { get; set; }
        public virtual DbSet<RelacjeMiedzyKlientami> RelacjeMiedzyKlientami { get; set; }
        public virtual DbSet<RodzajePlatnosci> RodzajePlatnosci { get; set; }
        public virtual DbSet<StatusFaktury> StatusFaktury { get; set; }
        public virtual DbSet<Statusy> Statusy { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Szkolenia> Szkolenia { get; set; }
        public virtual DbSet<Transakcje> Transakcje { get; set; }
        public virtual DbSet<TypyInterakcji> TypyInterakcji { get; set; }
        public virtual DbSet<Uzytkownicy> Uzytkownicy { get; set; }
        public virtual DbSet<Zadania> Zadania { get; set; }
        public virtual DbSet<Zamowienia> Zamowienia { get; set; }
        public virtual DbSet<ZapytaniaKlientow> ZapytaniaKlientow { get; set; }
        public virtual DbSet<Zespoly> Zespoly { get; set; }
    }
}
