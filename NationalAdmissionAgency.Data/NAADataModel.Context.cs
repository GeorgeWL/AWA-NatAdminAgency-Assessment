﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NationalAdmissionAgency.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NAAEntities : DbContext
    {
        public NAAEntities()
            : base("name=NAAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<NAA_Application> NAA_Application { get; set; }
        public virtual DbSet<NAA_Profile> NAA_Profile { get; set; }
        public virtual DbSet<NAA_University> NAA_University { get; set; }
    }
}
