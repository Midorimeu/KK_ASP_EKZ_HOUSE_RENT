﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HouseRentalMVCProject.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HouseRentalDataEntities : DbContext
    {
        public HouseRentalDataEntities()
            : base("name=HouseRentalDataEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BookingTbl> BookingTbls { get; set; }
        public DbSet<RegisterTbl> RegisterTbls { get; set; }
        public DbSet<TblContact> TblContacts { get; set; }
    }
}
