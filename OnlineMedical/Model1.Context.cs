﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineMedical
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MedicalEntities : DbContext
    {
        public MedicalEntities()
            : base("name=MedicalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Lab> Labs { get; set; }
        public virtual DbSet<Provider> Providers { get; set; }
        public virtual DbSet<tbl_InPatient> tbl_InPatient { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
    }
}
