﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace smshatirlatma.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OptikDbEntities : DbContext
    {
        public OptikDbEntities()
            : base("name=OptikDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Borc> Borc { get; set; }
        public virtual DbSet<CamTipleri> CamTipleri { get; set; }
        public virtual DbSet<Gozluk> Gozluk { get; set; }
        public virtual DbSet<kayit> kayit { get; set; }
        public virtual DbSet<Marka> Marka { get; set; }
        public virtual DbSet<MesajKontrol> MesajKontrol { get; set; }
        public virtual DbSet<satis> satis { get; set; }
        public virtual DbSet<SekilTipi> SekilTipi { get; set; }
        public virtual DbSet<Sms> Sms { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<AdminGiris> AdminGiris { get; set; }
        public virtual DbSet<GenelLog> GenelLog { get; set; }
    }
}
