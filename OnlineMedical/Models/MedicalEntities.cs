using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using MedicalSystem.BL;

namespace MedicalSystem.Model
{
    public class MedicalEntities : DbContext
    {
        public MedicalEntities()
            : base("name=MedicalEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<tbl_Doctor> tbl_Doctor { get; set; }
        public virtual DbSet<tbl_InPatient> tbl_InPatient { get; set; }
             public virtual DbSet<tbl_Patient> tbl_Patient { get; set; }
        public virtual DbSet<tbl_Provider> tbl_Provider { get; set; }
    }
}